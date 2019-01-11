using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TapaniMedicine_v2.Classes;
using TapaniMedicine_v2.Classes.Forms;
using TapaniMedicine_v2.Database;

namespace TapaniMedicine_v2
{
     /*
      Этот файл - своего рода перепутье, в котором собираются и обрабатываются все данные программы.

        Код был написан второпях, поэтому конкретно в этом файле можно увидеть не самые лучшие
        решения (см. последствия операций со 104 строки). 

        Здесь прокомментировано практически всё.
     */

    public partial class Hub : Form
    {
        // Объект данных операции находиться уже здесь, потому что данные добавляются постепенно,
        // когда форма Hub вызывает различные диалоговые окна для сбора информации (например, выбор повреждений).
        public OperationInfo operationInfo;

        // Словарь, хранящий информацию о персонажах. В качестве ключей используются ID.
        public Dictionary<string, CharacterData> database = new Dictionary<string, CharacterData>();

        // Флаг, используемый в случае некорректного запуска программы (а именно - неверно составленной базы данных, или вообще её отсутствия).
        private bool isCorrectLaunch = true;

        // Имя файла базы данных и начало имени файлов бэкапа (да, можно было сделать лучше)
        private const string dbFileName = "database.txt";
        private const string bakFileName = "database";

        // При создании объекта формы нужно загрузить в память список персонажей, обработав файл базы данных.
        public Hub()
        {
            InitializeComponent();

            // В этом блоке производится чтение и обработка файла
            try
            {
                // Считываем весь файл в массив строк, открывая файл всего на мгновение
                string[] db = File.ReadAllLines(dbFileName, Encoding.UTF8);
                foreach (string line in db)
                { // а теперь обрабатываем полученный массив
                    
                    /* Файл базы данных структурирован построчно.
                     
                     Это означает, что строки могут быть расположены в любом порядке,
                      но каждая строка имеет строго определённый порядок аргументов:
                     
                      ID#Титул#Имя#Фамилия#Состояние

                     Аргументы фамилии и состояния могут отсутствовать.
                     
                     */

                    // пустые строки и строки-комментарии обрабатывать не нужно
                    if (!line.Trim().StartsWith("#") && line.Trim() != "")
                    {
                        int paramsCnt = line.Split('#').Length;

                        // строка должна содержать минимум три аргумента (просто решётка после имени обозначит отсутствие фамилии)
                        if (paramsCnt >= 3)
                        { 
                            string[] lines = line.Split('#');

                            // файл составлен с ошибкой - программа не будет работать, 
                            // говорим об этом пользователю
                            if (database.Keys.Contains(lines[0]))
                            { 
                                GUIMessageBox.ShowDlg("В базе данных обнаружены конфликтующие ID! Удалите все дубликаты перед повторным запуском.");
                                BT_Next.Visible = false;
                                TB_ID.Visible = false;
                                isCorrectLaunch = false;
                            }

                            // создаём объект класса CharacterData с прочитанными данными,
                            // и добавляем его в словарь database
                            database.Add(lines[0],
                                new CharacterData(lines[0], lines[1], lines[2], lines[3], 
                                    (lines.Length <= 4) ? 0 : int.Parse(lines[4])));
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            { // Файл не существует (или неправильно назван)
              // В этом случае решение проблемы лучше предоставить мастеру.
                GUIMessageBox.ShowDlg(new string[] { "Не найден файл базы данных.",
                    "Обратитесь к мастеру по медицине." });
                BT_Next.Visible = false;
                TB_ID.Visible = false;
                isCorrectLaunch = false;              
            }
        }

        // Этот метод - результат выкрутасов моего компилятора, это здесь не нужно.
        private void Hub_Load(object sender, EventArgs e)
        {

        }

        // В этом методе происходит всё основное действо.
        // К сожалению, из-за спешки, представленный здесь код - далеко не лучший результат работы
        // моего ума, поэтому тут я вообще каждую строчку прокомментирую.
        private void BT_Next_Click(object sender, EventArgs e)
        {
            // Простая проверка на длину ID.
            if (TB_ID.Text.Length == 4)
            {
                // Удостоверимся, что введённый ID присутствует в базе.
                if (database.Keys.Contains(TB_ID.Text))
                {
                    // Создаём объект данных операции, указав объект данных пациента.
                    operationInfo = new OperationInfo(database[TB_ID.Text]);

                    // Открываем окно с информацией о пациенте.
                    DialogResult dlgResult = OpenPatientInfo();

                    // Последующие окна нужно открывать, только если была нажата соответствующая кнопка.
                    if (dlgResult == DialogResult.OK)
                    {
                        // Открываем диалоговое окно ввода повреждений
                        dlgResult = OpenInjuriesInput();

                        // Продолжаем, только если операция не отменена.
                        if (dlgResult == DialogResult.OK)
                        {
                            // Открываем окно операции.
                            Operation opWindow = new Operation(operationInfo);
                            dlgResult = opWindow.ShowDialog();

                            switch (dlgResult)
                            {
                                // Операция провалена.
                                case DialogResult.None:
                                    { 
                                        operationInfo.patient.state = CharacterData.State.DEAD;
                                        break;
                                    }

                                // Операция успешна.
                                case DialogResult.OK:
                                    {
                                        // Далее описаны hardcoded последствия операции, зависящие от общего количества
                                        // ошибочных действий во время операции (и самую малость - от рандома).
                                        switch (operationInfo.fails)
                                        {
                                            case 0:
                                                {
                                                    GUIMessageBox.ShowDlg(new string[] { "", "Операция успешно завершена без последствий для пациента!" });
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    GUIMessageBox.ShowDlg(new string[] { "", "Операция успешно завершена без последствий для пациента!" });
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    GUIMessageBox.ShowDlg(GUIMessageBox.Type.BIGMESSAGE, new string[]
                                                    {
                                                        "",
                                                        "",
                                                        "",
                                                        "Операция успешно завершена!",
                                                        "",
                                                        "Пациенту необходима реабилитация длительностью " + new Random().Next(12, 20).ToString() + " минут."
                                                    });
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    GUIMessageBox.ShowDlg(GUIMessageBox.Type.BIGMESSAGE, new string[]
                                                    {
                                                        "",
                                                        "",
                                                        "",
                                                        "Операция успешно завершена!",
                                                        "",
                                                        "Пациенту необходима реабилитация длительностью " + new Random().Next(25, 30).ToString() + " минут.",
                                                        "В течение двух часов пациент будет испытывать проблемы с выносливостью (-1 макс. хит)."
                                                    });
                                                    break;
                                                }
                                            case 4:
                                                {
                                                    int rand = new Random().Next(1, 4);
                                                    string limb = "левой руки";
                                                    
                                                    switch (rand)
                                                    {
                                                        case 1:
                                                            {
                                                                limb = "левая рука";
                                                                break;
                                                            }
                                                        case 2:
                                                            {
                                                                limb = "правая рука";
                                                                break;
                                                            }
                                                        case 3:
                                                            {
                                                                limb = "левая нога";
                                                                break;
                                                            }
                                                        case 4:
                                                            {
                                                                limb = "правая нога";
                                                                break;
                                                            }
                                                    }
                                                    GUIMessageBox.ShowDlg(GUIMessageBox.Type.BIGMESSAGE, new string[]
                                                    {
                                                        "",
                                                        "",
                                                        "",
                                                        "Операция успешно завершена!",
                                                        "",
                                                        "Пациенту необходима реабилитация длительностью " + new Random().Next(20, 25).ToString() + " минут.",
                                                        "Пациент теперь будет испытывать проблемы с выносливостью (-1 хит до конца игры).",
                                                        "Парализована " + limb + ".",
                                                        "Возможны припадки (от громких звуков теряет сознание).",
                                                        "Пациент ослеп на " + new Random().Next(20, 40) + " минут."
                                                    });
                                                    break;
                                                }
                                            case 5:
                                                {
                                                    int rand = new Random().Next(1, 4);
                                                    string limb = "левая рука";
                                                    string limb2 = "правая рука";

                                                    switch (rand)
                                                    {
                                                        case 1:
                                                            {
                                                                limb = "левая рука";
                                                                limb2 = "левая нога";
                                                                break;
                                                            }
                                                        case 2:
                                                            {
                                                                limb = "правая рука";
                                                                limb2 = "правая нога";
                                                                break;
                                                            }
                                                        case 3:
                                                            {
                                                                limb = "левая нога";
                                                                limb2 = "правая рука";
                                                                break;
                                                            }
                                                        case 4:
                                                            {
                                                                limb = "правая нога";
                                                                limb2 = "левая рука";
                                                                break;
                                                            }
                                                    }
                                                    GUIMessageBox.ShowDlg(GUIMessageBox.Type.BIGMESSAGE, new string[]
                                                    {
                                                        "",
                                                        "",
                                                        "",
                                                        "Операция успешно завершена!",
                                                        "",
                                                        "Пациенту необходима реабилитация длительностью " + new Random().Next(20, 25).ToString() + " минут.",
                                                        "Пациент теперь будет испытывать проблемы с выносливостью (-1 хит до конца игры).",
                                                        "У пациента будут припадки от громких звуков, очень яркого света, агрессивного поведения (теряет сознание).",
                                                        "Парализована " + limb + " и " + limb2 + ".",
                                                        "Пациент ослеп и оглох на " + new Random().Next(30, 50) + " минут."
                                                    });
                                                    break;
                                                }
                                            case 6:
                                                {
                                                    int rand = new Random().Next(1, 2);
                                                    string limb = "левая рука";
                                                    string limb2 = "правая рука";

                                                    switch (rand)
                                                    {
                                                        case 1:
                                                            {
                                                                limb = "левая рука";
                                                                limb2 = "правая рука";
                                                                break;
                                                            }
                                                        case 2:
                                                            {
                                                                limb = "левая нога";
                                                                limb2 = "правая нога";
                                                                break;
                                                            }
                                                    }
                                                    GUIMessageBox.ShowDlg(GUIMessageBox.Type.BIGMESSAGE, new string[]
                                                    {
                                                        "",
                                                        "",
                                                        "",
                                                        "Операция успешно завершена!",
                                                        "",
                                                        "Пациенту необходима реабилитация длительностью " + new Random().Next(30, 45).ToString() + " минут.",
                                                        "Пациент теперь будет испытывать проблемы с выносливостью (-1 хит до конца игры).",
                                                        "У пациента будут припадки от громких звуков, очень яркого света, агрессивного поведения (теряет сознание).",
                                                        "Парализована " + limb + " и " + limb2 + ".",
                                                        "Пациент ослеп и оглох на " + new Random().Next(40, 60) + " минут."
                                                    });
                                                    break;
                                                }
                                            case 7:
                                                {
                                                    int rand = new Random().Next(1, 2);
                                                    string limb = "левая рука";
                                                    string limb2 = "правая рука";

                                                    switch (rand)
                                                    {
                                                        case 1:
                                                            {
                                                                limb = "левая рука";
                                                                limb2 = "правая рука";
                                                                break;
                                                            }
                                                        case 2:
                                                            {
                                                                limb = "левая нога";
                                                                limb2 = "правая нога";
                                                                break;
                                                            }
                                                    }
                                                    GUIMessageBox.ShowDlg(GUIMessageBox.Type.BIGMESSAGE, new string[]
                                                    {
                                                        "",
                                                        "",
                                                        "",
                                                        "Операция успешно завершена!",
                                                        "",
                                                        "Пациенту необходима реабилитация длительностью " + new Random().Next(40, 55).ToString() + " минут.",
                                                        "Пациент теперь будет испытывать проблемы с выносливостью (-1 хит до конца игры)",
                                                        "У пациента будут припадки от громких звуков, очень яркого света, агрессивного поведения (теряет сознание).",
                                                        "Парализована " + limb + " и " + limb2 + ".",
                                                        "Пациент ослеп и оглох на " + new Random().Next(50, 70) + " минут."
                                                    });
                                                    break;
                                                }
                                        }
                                        break;
                                    }

                                // Операция отменена.
                                case DialogResult.Abort:
                                    { // Пациента нужно поместить в криостазис.
                                        GUIMessageBox.ShowDlg(new string[] {
                                            "Операция прервана.",
                                            "Пациент был помещён в криосон." });
                                        operationInfo.patient.state = CharacterData.State.FROZEN;
                                        break;
                                    }
                            }

                            // Деструктируем объект окна операции.
                            opWindow.Dispose();
                        }
                    }

                    // Блок перезаписи существующей базы данных и создания бэкапа.
                    {
                        string[] newDB = new string[database.Count];
                        int i = 0;
                        foreach (CharacterData value in database.Values)
                        {
                            newDB[i] = value.ToString();
                            i++;
                        }

                        // создание бэкапа (в имени указывается текущее время)
                        File.WriteAllLines(bakFileName + DateTime.Now.ToShortTimeString().Replace(':', '_') + ".bak", File.ReadAllLines(dbFileName, Encoding.UTF8), Encoding.UTF8);

                        // перезапись файла
                        File.WriteAllLines(dbFileName, newDB, Encoding.UTF8);
                    }
                }
                else
                { // Несуществующий пациент
                    GUIMessageBox.ShowDlg("Пациента с указанным ID не существует!");
                }
            }
            else
            { // Ошибка ввода
                GUIMessageBox.ShowDlg("ID должен состоять из 4 цифр!");
            }
        }

        // Диалоговое окно информации о пациенте.
        private DialogResult OpenPatientInfo()
        {
            PatientInfo patientInfo = new PatientInfo(operationInfo.patient);
            patientInfo.ShowDialog();
            DialogResult result = patientInfo.DialogResult;
            return result;
        }

        // Диалоговое окно ввода информации о повреждениях.
        // В этом же методе происходит запись полученных данных в объект данных об операции.
        private DialogResult OpenInjuriesInput()
        {
            InjuriesInput injuriesInput = new InjuriesInput();
            injuriesInput.ShowDialog();
            DialogResult result = injuriesInput.DialogResult;

            if (result == DialogResult.OK)
            { // Сохраняем введённые данные в объект операции
                operationInfo.damageList = OperationInfo.InjuriesToDamages(injuriesInput.input.ToArray());
            }

            injuriesInput.Dispose();
            return result;
        }

        // Два метода, предназначенные для отображения справочной информации TextBox'a.
            private void TB_ID_Focused(object sender, EventArgs e)
            {
                if (TB_ID.Text == "Введите ID пациента...")
                    TB_ID.Text = "";                
            }

            private void TB_ID_Unfocused(object sender, EventArgs e)
            {
                if (TB_ID.Text == "")
                    TB_ID.Text = "Введите ID пациента...";
            }

        // Выход из программы.
        private void TB_Exit_Click(object sender, EventArgs e)
        {
            // Запрашивать подтверждение, но только если программа запущена без ошибок в базе данных.
            if (isCorrectLaunch)
            {
                DialogResult result = GUIMessageBox.ShowDlg(GUIMessageBox.Type.CONFIRMATION, "Вы действительно хотите закрыть программу управления?");
                if (result == DialogResult.Yes)
                    Dispose();
            }
            else Dispose();
        }

        // Метод, ограничивающий допустимый набор символов в поле ID. 
        private void TB_ID_KeyDown(object sender, KeyEventArgs e)
        { // Разрешаются:
            if (!((e.KeyData >= Keys.D0 && e.KeyData <= Keys.D9) // ...цифры основной клавиатуры
                || (e.KeyData >= Keys.NumPad0 && e.KeyData <= Keys.NumPad9) // ...цифры numpad'a
                || (e.KeyData == Keys.Back) // ...backspace
                || (TB_ID.Text.Length >= 4))) // ...но только 4 символа.

            { // Если нажатая клавиша не попадает в набор разрешённых - предотвращаем ввод.
                e.SuppressKeyPress = true;
            }
        }

        // Методы воспроизведения звука на кнопках.
            private void MouseDownEvent(object sender, MouseEventArgs e)
            {
                SoundLibrary.PlaySound(SoundLibrary.SoundType.MouseDown_01);
            }

            private void MouseEnterEvent(object sender, EventArgs e)
            {
                SoundLibrary.PlaySound(SoundLibrary.SoundType.MouseEnter_01);
            }
    }
}
