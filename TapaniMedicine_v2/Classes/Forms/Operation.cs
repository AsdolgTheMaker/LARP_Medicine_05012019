using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TapaniMedicine_v2.Classes.Forms;
using TapaniMedicine_v2.Database;

namespace TapaniMedicine_v2.Classes.Forms
{
    public partial class Operation : Form
    {
        // Объект данных операции.
        OperationInfo info;

        // Вывод отформатированного сообщения в журнал.
        private void LogMessage(string message)
        {
            RTB_Journal.AppendText(DateTime.Now.TimeOfDay.Hours.ToString() + ':' +
                DateTime.Now.TimeOfDay.Minutes.ToString() + ':' +
                DateTime.Now.TimeOfDay.Seconds.ToString() +
                " || " + message + '\n');
            RTB_Journal.Select(RTB_Journal.TextLength, 0);
            RTB_Journal.ScrollToCaret();

            TMR_Pulse.Enabled = true;
        }

        public Operation(OperationInfo opInfo)
        {
            InitializeComponent();
            info = opInfo;

            // Загружаем данные о личности в интерфейс.
            TB_Name.Text = info.patient.Person["name"];
            TB_Surname.Text = info.patient.Person["surname"];
            TB_Title.Text = info.patient.Person["title"];
            TB_ID.Text = info.patient.id;

            LogMessage("Начало операции над " + TB_Name.Text + " " + TB_Surname.Text);

            // Загружаем данные о ранениях и характеристиках в интерфейс.
            GUIUpdateStats();
            GUIUpdateDamages();

            // Прячем индикатор крит. состояния и деактивируем таймер мерцания.
            LB_Critical.Visible = false;
            TMR_CritFlickering.Enabled = false;
        }

        private void Operation_Load(object sender, EventArgs e)
        { // Как только загрузились - начинаем по таймеру рандомизировать характеристики.
            TMR_StatsRandomize.Start();
            TMR_StatsRandomize.Enabled = true;
            TMR_StatsRandomize.Interval = 1;
        }

        private void BT_Heal_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрано ли вообще повреждение.
            if (LB_Damages.SelectedItem != null)
            {

                // Создаём объект повреждения для передачи в следующее диалоговое окно и вывода в журнал.
                Damage selectedDamage = new Damage(Damage.GetTypeByName(LB_Damages.SelectedItem.ToString()));
                LogMessage("Лечение повреждения \"" + selectedDamage.name + "\"");

                ActionSelect action = new ActionSelect(info, selectedDamage);
                DialogResult dlgResult = action.ShowDialog(); // вызываем окно
                
                switch (dlgResult)
                {
                    // Повреждение вылечено
                    case DialogResult.OK:
                        { 
                            // убрать вылеченное из списка
                            LB_Damages.Items.Remove(selectedDamage.ToString());

                            LogMessage("Повреждение устранено.");

                            // если повреждений больше нет - операция успешно завершена
                            if (LB_Damages.Items.Count == 0)
                            {
                                LogMessage("Пациент вылечен!");

                                info.isFinished = true;

                                DialogResult = DialogResult.OK;
                                Close();
                            }
                            break;
                        }
                    case DialogResult.Cancel:
                        { // процедура лечения ОТМЕНЕНА (т.е. не было произведено ни одного действия)
                            LogMessage("Процедура лечения отменена.");
                            break;
                        }
                    case DialogResult.Abort:
                        { // процедура лечения ПРЕРВАНА (т.е. действие было совершено, неважно - ошибочное или нет)
                            LogMessage("Процедура лечения прервана.");

                            // Наносим пациенту один уровень урона. 
                            // Это не может его убить, т.к. прерывать лечение в критическом состоянии запрещено.
                            info.HurtStats();
                            break;
                        }
                    case DialogResult.No:
                        { // Попытки закончились, операция провалена. Убиваем пациента.
                            info.isFinished = true;

                            TMR_Pulse.Enabled = false;
                            TMR_Pulse.Dispose();
                            SoundLibrary.PlaySoundLooping(SoundLibrary.SoundType.BEEEEEEP);

                            info.Dead();
                            GUIUpdateStats();
                            TMR_StatsRandomize.Enabled = false;
                            LogMessage("Пациент скончался.");
                            GUIMessageBox.ShowDlg(new string[] { "", "Пациент скончался." });

                            DialogResult = DialogResult.None;

                            Close();

                            SoundLibrary.Stop();
                            break;
                        }
                }

                // Контроль индикатора крит. состояния.
                if (info.IsCritical())
                {
                    LogMessage("Пациент в критическом состоянии!");
                    LB_Critical.Visible = true;
                    TMR_CritFlickering.Enabled = true;
                }
                else
                {
                    TMR_CritFlickering.Enabled = false;
                    LB_Critical.Visible = false;
                }
            }
            else
                GUIMessageBox.ShowDlg(new string[] { "", "Сначала выберите повреждение." });
        }

        // Обновление интерфейса (характеристики)
        private void GUIUpdateStats()
        {
            TB_Blood.Text = info.Stats["blood"].ToString();
            TB_HPressure.Text = info.Stats["hpres"].ToString();
            TB_LPressure.Text = info.Stats["lpres"].ToString();
            TB_Pulse.Text = info.Stats["pulse"].ToString();
            TB_Pain.Text = info.Stats["pain"].ToString();
        }

        // ВИЗУАЛЬНОЕ (!!!) обновление интерфейса, рандомизирующее характеристики в небольшом диапазоне
        private void GUIUpdateStatsRandomize()
        {
            Random random = new Random(new Random().Next());

            TB_Blood.Text = info.Stats["blood"].ToString();
            TB_HPressure.Text = (info.Stats["hpres"] + random.Next(-9, 9)).ToString();
            TB_LPressure.Text = (info.Stats["lpres"] + random.Next(-6, 6)).ToString();

            if (info.Stats["pulse"] != 0)
                TB_Pulse.Text = (info.Stats["pulse"] + random.Next(-6, 6)).ToString();

            if (info.Stats["pain"] <= 1 || info.Stats["pain"] >= 98)
                TB_Pain.Text = info.Stats["pain"].ToString();
            else
                TB_Pain.Text = (info.Stats["pain"] + random.Next(-1, 1)).ToString();
        }

        // Обновление интерфейса (повреждения)
        private void GUIUpdateDamages()
        {
            LB_Damages.Items.Clear();
            LB_Damages.Items.AddRange(OperationInfo.DamagesToString(info.damageList.ToArray()));
        }

        private void TB_Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        // Когда вызывается закрытие (через кнопку, или же через Alt+F4), необходимо
        // сначала решить, нужно ли закрывать, и, при необходимости, прервать процедуру.
        private void CloseCalled(object sender, FormClosingEventArgs e)
        {
            // Спрашивать подтверждения нужно только в том случае, если пациент ещё жив И операция ещё не закончена.
            if ((info.patient.state != CharacterData.State.DEAD) && !info.isFinished)
            {
                DialogResult result = GUIMessageBox.ShowDlg(GUIMessageBox.Type.CONFIRMATION,
                    new string[] {
                    "Если вы прервёте операцию, дроид автоматически начнёт процедуру ввода пациента в криостазис.",
                    "Вы уверены, что хотите прервать операцию?" });

                // Решаем, нужно ли прервать закрытие.
                if (result == DialogResult.Yes)
                {
                    // Прерываем.
                    e.Cancel = false;

                    // Замораживаем пациента.
                    info.patient.state = CharacterData.State.FROZEN;
                    DialogResult = DialogResult.Abort;


                    /* Нереализованный контент, из-за неверной имплементации задержек.
                    
                    LogMessage("Начинаю криогенную заморозку...");
                    Thread.Sleep(2500);
                    LogMessage("Герметизация кожного покрова...");
                    Thread.Sleep(3000);
                    LogMessage("Остановка жизненных показателей...");
                    TMR_StatsRandomize.Enabled = false;
                    Thread.Sleep(3000);
                    TMR_CritFlickering.Enabled = false;                    
                    Thread.Sleep(1500);
                    */

                    LB_Critical.Visible = false;
                    LogMessage("Пациент заморожен.");
                }
                else e.Cancel = true;
            }
        }

        // Таймер рандомизации характеристик.
        private void OnTimer(object sender, EventArgs e)
        {
            GUIUpdateStatsRandomize();
            TMR_StatsRandomize.Interval = new Random().Next(500, 1500);
        }

        // Таймер моргания надписи "Критическое состояние".
        private void OnTimerCrit(object sender, EventArgs e)
        {
            LB_Critical.Visible = !LB_Critical.Visible;
        }

        // Таймер звуков пульса.
        private void OnTimerPulse(object sender, EventArgs e)
        {
            if (info.isFinished)
                TMR_Pulse.Enabled = false;
            else
            {
                SoundLibrary.PlaySound(SoundLibrary.SoundType.BEEP);

                // Расчитываем время до воспроизведения следующего звука, основываясь на значении пульса.
                // Грубо говоря, нужно конвертировать значение из 'ударов в минуту' в 'миллисекунд в удар'.
                int pulse = int.Parse(TB_Pulse.Text);
                TMR_Pulse.Interval = (int)Math.Round((60.0 / (pulse == 0 ? 60 : pulse)) * 1000);
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