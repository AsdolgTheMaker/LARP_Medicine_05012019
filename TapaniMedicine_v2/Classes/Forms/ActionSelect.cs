using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TapaniMedicine_v2.Database;
using TapaniMedicine_v2.Classes.Forms;

namespace TapaniMedicine_v2.Classes.Forms
{
    // Окно, в котором происходит, собственно, процесс лечения.
    public partial class ActionSelect : Form
    {
        // Объект данных операции.
        OperationInfo operation;

        // Объект данных повреждения, которое нужно вылечить.
        Damage damage;

        // Счётчик попыток, работающий только в рамках именно этого повреждения. 
        // Нужен для возможности отмены лечения без последствий.
        int locattempt = 0;

        // Текущий номер верного действия.
        int currentAction;

        public ActionSelect(OperationInfo _operation, Damage _damage)
        {
            InitializeComponent();

            operation = _operation;
            damage = _damage;
            currentAction = damage.order.Dequeue();

            TMR_StatsRandomize.Enabled = true;

            PB_Process.Value = 0;
            PB_Process.Minimum = 0;
            PB_Process.Maximum = damage.order.Count + 1;

            LB_Injury.Text = damage.name;

            LB_InjSelection.SelectedIndex = 0;

            // Контроллер индикатора крит. состояния
            if (!operation.IsCritical())
            {
                LB_Critical.Visible = false;
                TMR_CriticalFlickering.Enabled = false;
            }
            else
            {
                LB_Critical.Visible = true;
                TMR_CriticalFlickering.Enabled = true;
            }
        }

        // Метод вызывается по клику кнопок действий.
        private void AttemptAction(Database.Action action)
        {
            locattempt++;

            if (action.number == currentAction)
            { // Выбрано верное действие
                PB_Process.Value++;

                // Проверяем, сколько ещё повреждений. Если их не осталось,
                // возвращаемся в окно операции, а также нейтрализуем одну ошибку.
                if (damage.order.Count > 0)
                    currentAction = damage.order.Dequeue();
                else
                {
                    DialogResult = DialogResult.OK;

                    // "Стабилизация" пациента.
                    operation.HealStats();

                    TMR_CriticalFlickering.Enabled = false;
                    LB_Critical.Visible = false;

                    GUIMessageBox.ShowDlg(new string[] 
                    { "", "Повреждение вылечено.",
                    "Дроид стабилизирует пациента..." });

                    Close();
                }
            }
            else // Неверное действие
            {
                operation.attempt++;
                operation.HurtStats();

                if (operation.attempt >= OperationInfo.maxAttempts)
                {
                    DialogResult = DialogResult.No;
                    Close();
                }
                else if (operation.IsCritical())
                {
                    GUIMessageBox.ShowDlg(new string[] 
                    { "", "Пациент в критическом состоянии!"});
                }
                else
                {
                    GUIMessageBox.ShowDlg(new string[]
                    { "", "Состояние пациента ухудшилось." });
                }

                if (operation.IsCritical())
                {
                    LB_Critical.Visible = true;
                    TMR_CriticalFlickering.Enabled = true;
                }
            }
        }

        // Обновление интерфейса (характеристики).
        private void GUIUpdateStats()
        {
            TB_Blood.Text = operation.Stats["blood"].ToString();
            TB_HPressure.Text = operation.Stats["hpres"].ToString();
            TB_LPressure.Text = operation.Stats["lpres"].ToString();
            TB_Pulse.Text = operation.Stats["pulse"].ToString();
            TB_Pain.Text = operation.Stats["pain"].ToString();
        }

        // Обновление интерфейса, ВИЗУАЛЬНО рандомизирующее характеристики пациента.
        private void GUIUpdateStatsRandomize()
        {
            Random random = new Random(new Random().Next());

           
            TB_Blood.Text = operation.Stats["blood"].ToString();
            TB_HPressure.Text = (operation.Stats["hpres"] + random.Next(-9, 9)).ToString();
            TB_LPressure.Text = (operation.Stats["lpres"] + random.Next(-6, 6)).ToString();

            if (operation.Stats["pulse"] != 0)
                TB_Pulse.Text = (operation.Stats["pulse"] + random.Next(-6, 6)).ToString();

            if (operation.Stats["pain"] <= 1 || operation.Stats["pain"] >= 98)
                TB_Pain.Text = operation.Stats["pain"].ToString();
            else
                TB_Pain.Text = (operation.Stats["pain"] + random.Next(-1, 1)).ToString();
        }

        private void OnTimer(object sender, EventArgs e)
        {
            GUIUpdateStatsRandomize();
            TMR_StatsRandomize.Interval = new Random().Next(500, 1500);
        }

        private void OnTimerCrit(object sender, EventArgs e)
        {
            LB_Critical.Visible = !LB_Critical.Visible;
        }

        // ВНИМАНИЕ! Этот и следующий методы ЗАВИСИМЫ от ТЕКСТА НА КНОПКЕ, т.к. с его помощью
        // определяется тип действия. Ввод текста несуществующего действия приведёт к ошибке и стопору системы.
        private void BT_Inject_Click(object sender, EventArgs e)
        {
            Database.Action.Type actType = Database.Action.GetTypeByName(LB_InjSelection.SelectedItem.ToString());
            Database.Action action = new Database.Action(actType);
            AttemptAction(action);
        }

        private void ActionSelected(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Database.Action action = new Database.Action(Database.Action.GetTypeByName(button.Text));
            AttemptAction(action);
        }

        // Если медик хочет прервать процедуру лечения...
        private void BT_Return_Click(object sender, EventArgs e)
        {
            // Проверяем кол-во предпринятых действий
            if (locattempt == 0)
            { // Если лечение не начиналось - никаких последствий, возвращаемся в меню.
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            { // Если же было совершено хотя бы одно действие - проверяем, находится ли пациент в критическом состоянии.
                if (operation.attempt == OperationInfo.maxAttempts - 1)
                { 
                    GUIMessageBox.ShowDlg(new string[] 
                    { "", "Пациент в критическом состоянии!",
                    "Невозможно отменить лечение." });
                }
                else // Если состояние не критическое - возвращаемся в меню операции (спросив подтверждения).
                { 
                    DialogResult result = GUIMessageBox.ShowDlg(GUIMessageBox.Type.CONFIRMATION,
                        new string[] { "Вы собираетесь прервать уже начатую процедуру лечения." +
                        "Дроид сведёт урон к минимуму, но состояние пациента всё равно ухудшится.",
                        "Вы уверены?"});
                    if (result == DialogResult.Yes)
                    {
                        DialogResult = DialogResult.Abort;
                        Close();
                    }
                }
            }
        }

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
