using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TapaniMedicine_v2.Classes.Forms
{
    // Это окно - переходный этап между пассивным состоянием программы и, собственно, операцией.
    // Здесь отображаются данные класса Database.CharacterData.
    public partial class PatientInfo : Form
    {
        // Пациент, данные которого необходимо отобразить
        private Database.CharacterData patient;

        public PatientInfo(Database.CharacterData _patient)
        {
            InitializeComponent();
            patient = _patient;

            // Отображаем данные о личности и идентификатор
            TB_Name.Text = patient.Person["name"];
            TB_Surname.Text = patient.Person["surname"];
            TB_Title.Text = patient.Person["title"];
            TB_ID.Text = patient.id;

            // В зависимости от состояния пациента, покрасить текст состояния, 
            // а также спрятать или отобразить кнопку разморозки.
            switch (patient.state)
            {
                case Database.CharacterData.State.ALIVE:
                    {
                        LB_State.Text = "ЖИВ";
                        LB_State.ForeColor = Color.ForestGreen;

                        BT_Criofreeze.Visible = false;
                        break;
                    }
                case Database.CharacterData.State.DEAD:
                    {
                        LB_State.Text = "МЁРТВ";
                        LB_State.ForeColor = Color.DarkRed;

                        BT_Criofreeze.Visible = false;
                        break;
                    }
                case Database.CharacterData.State.FROZEN:
                    {
                        LB_State.Text = "В СТАЗИСЕ";
                        LB_State.ForeColor = Color.SkyBlue;

                        BT_Criofreeze.Visible = true;
                        break;
                    }
            }

            // Отобразить стандартные для пациента значения характеристик 
            TB_Blood.Text = patient.Stats["blood"].ToString();
            TB_HPressure.Text = patient.Stats["hpres"].ToString();
            TB_LPressure.Text = patient.Stats["lpres"].ToString();
            TB_Pulse.Text = patient.Stats["pulse"].ToString();

            // Если ранее были сделаны заметки врача - отобразить и их.
            if (patient.docNotes != null)
                RTB_DocNotes.Lines = patient.docNotes;
        }

        // По клику кнопки решаем, нужно ли перейти к операции.
        private void BT_ToOperation_Click(object sender, EventArgs e)
        {
            switch (patient.state)
            {
                case Database.CharacterData.State.ALIVE:
                    { // Пациент жив - операцию можно проводить.
                      // (технически - возвращаемся в Hub.cs с положительным результатом)
                        DialogResult = DialogResult.OK;
                        patient.docNotes = RTB_DocNotes.Lines;
                        Close();
                        break;
                    }
                case Database.CharacterData.State.DEAD:
                    { // Пациент мёртв - нельзя провести операцию.
                        GUIMessageBox.ShowDlg("Нельзя провести операцию над мёртвым пациентом.");                        
                        break;
                    }
                case Database.CharacterData.State.FROZEN:
                    { // Пациент в криостазисе - уведомить врача о необходимости разморозки.
                        GUIMessageBox.ShowDlg(new string[] { "Пациент находиться в состоянии криогенной заморозки.",
                        "Перед продолжением проведите разморозку." });
                        break;
                    }
            }
        }

        private void BT_Criofreeze_Click(object sender, EventArgs e)
        {
            switch (patient.state)
            {
                case Database.CharacterData.State.ALIVE:
                case Database.CharacterData.State.DEAD:
                    { // По какой-то причине кнопка видна - прячем её.
                        BT_Criofreeze.Visible = false;
                        break;
                    }
                case Database.CharacterData.State.FROZEN:
                    { // Размораживаем пациента
                        DialogResult result = GUIMessageBox.ShowDlg(GUIMessageBox.Type.CONFIRMATION, "Вы дейсвтительно хотите разморозить пациента?");
                        if (result == DialogResult.Yes)
                        {
                            /* Нереализованный контент - задержки сделаны в корне неправильно.
                         
                            GUIMessageBox box = GUIMessageBox.ShowTimedMessage("Начинается процедура разморозки...");
                            Thread.Sleep(2500);
                            box.Dispose();

                            box = GUIMessageBox.ShowTimedMessage("Восстановление жизненных показателей...");
                            Thread.Sleep(3000);
                            box.Dispose();

                            box = GUIMessageBox.ShowTimedMessage("Разгерметизация кожного покрова...");
                            Thread.Sleep(4000);
                            box.Dispose();

                            box = GUIMessageBox.ShowTimedMessage("Стабилизация температуры...");
                            Thread.Sleep(5000);
                            box.Dispose();

                            GUIMessageBox.ShowDlg(new string[] { "", "Процедура разморозки завершена." });
                            */

                            LB_State.Text = "ЖИВ";
                            LB_State.ForeColor = Color.ForestGreen;

                            patient.state = Database.CharacterData.State.ALIVE;

                            BT_Criofreeze.Visible = false;
                        }
                        break;
                    }
            }
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            // Перед тем как выйти, сохраним заметки врача в объект данных пациента.
            patient.docNotes = RTB_DocNotes.Lines;
            Close();
        }

        // Методы воспроизведения звуков кнопок
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
