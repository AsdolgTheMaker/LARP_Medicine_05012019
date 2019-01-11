using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapaniMedicine_v2.Classes.Forms
{
    // Этот класс отвечает за месседж бокс с кастомизированным интерфейсом. По сути, это
    // минималистичная версия майкрософтоского MessageBox. 
    // Не буду утруждаться комментированием, должно быть и так всё понятно.
    public partial class GUIMessageBox : Form
    {
        Type gtype = Type.MESSAGE;
        int time = 0;
        public enum Type
        {
            BIGMESSAGE,
            MESSAGE,
            MESSAGE_TIMED,
            CONFIRMATION
        }

        public GUIMessageBox(Type type, string message)
        {
            InitializeComponent();

            TB_Msg.Text = message;

            gtype = type;
            switch (type)
            {
                case Type.MESSAGE:
                    {
                        BT_Next.Visible = true;
                        BT_No.Visible = false;
                        BT_Yes.Visible = false;
                        break;
                    }
                case Type.BIGMESSAGE:
                    {
                        Size = new Size(700, 400);
                        BT_Next.Visible = true;
                        BT_No.Visible = false;
                        BT_Yes.Visible = false;
                        break;
                    }
                case Type.CONFIRMATION:
                    {
                        BT_Next.Visible = false;
                        BT_No.Visible = true;
                        BT_Yes.Visible = true;
                        break;
                    }
                case Type.MESSAGE_TIMED:
                    {
                        BT_Next.Visible = false;
                        BT_No.Visible = false;
                        BT_Yes.Visible = false;
                        break;
                    }
            }
        }
        public GUIMessageBox(Type type, string[] message)
        {
            InitializeComponent();

            TB_Msg.Lines = message;

            gtype = type;
            switch (type)
            {
                case Type.MESSAGE:
                    {
                        BT_Next.Visible = true;
                        BT_No.Visible = false;
                        BT_Yes.Visible = false;
                        break;
                    }
                case Type.BIGMESSAGE:
                    {
                        Size = new Size(700, 400);
                        BT_Next.Visible = true;
                        BT_No.Visible = false;
                        BT_Yes.Visible = false;
                        break;
                    }
                case Type.CONFIRMATION:
                    {
                        BT_Next.Visible = false;
                        BT_No.Visible = true;
                        BT_Yes.Visible = true;
                        break;
                    }
                case Type.MESSAGE_TIMED:
                    {
                        BT_Next.Visible = false;
                        BT_No.Visible = false;
                        BT_Yes.Visible = false;
                        break;
                    }
            }
        }
        public GUIMessageBox(Type type, string message, int _time)
        {
            InitializeComponent();

            TB_Msg.Text = message;

            gtype = type;
            switch (type)
            {
                case Type.MESSAGE:
                    {
                        BT_Next.Visible = true;
                        BT_No.Visible = false;
                        BT_Yes.Visible = false;
                        break;
                    }
                case Type.CONFIRMATION:
                    {
                        BT_Next.Visible = false;
                        BT_No.Visible = true;
                        BT_Yes.Visible = true;
                        break;
                    }
                case Type.MESSAGE_TIMED:
                    {
                        BT_Next.Visible = false;
                        BT_No.Visible = false;
                        BT_Yes.Visible = false;
                        time = _time;
                        break;
                    }
            }
        }

        private void BT_Next_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        }

        // call with undefined type automatically defines MESSAGE type
        public static DialogResult ShowDlg(string message)
        {
            GUIMessageBox box = new GUIMessageBox(Type.MESSAGE, message);
            return box.ShowDialog();
        }
        public static DialogResult ShowDlg(string[] message)
        {
            GUIMessageBox box = new GUIMessageBox(Type.MESSAGE, message);
            return box.ShowDialog();
        }

        // defined type
        public static DialogResult ShowDlg(Type type, string message)
        {
            GUIMessageBox box = new GUIMessageBox(type, message);
            return box.ShowDialog();
        }
        public static DialogResult ShowDlg(Type type, string[] message)
        {
            GUIMessageBox box = new GUIMessageBox(type, message);
            return box.ShowDialog();
        }
        public static DialogResult ShowDlg(Type type, string message, int time)
        {
            GUIMessageBox box = new GUIMessageBox(type, message, time);
            return box.ShowDialog();
        }

        /// <summary>
        /// WARNING! This method will call a window which will not disappear! However it will return created class instance, so the object can be discarded manually.
        /// </summary>
        public static GUIMessageBox ShowTimedMessage(string message)
        {
            return new GUIMessageBox(Type.MESSAGE_TIMED, message);
        }

        private void BT_Yes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Dispose();
        }

        private void BT_No_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Dispose();
        }

        private void OnShow(object sender, EventArgs e)
        {

        }
        
        private void OnClose(object sender, FormClosingEventArgs e)
        {
            
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