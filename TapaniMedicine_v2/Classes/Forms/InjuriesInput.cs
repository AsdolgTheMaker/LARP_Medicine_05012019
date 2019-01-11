using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapaniMedicine_v2.Classes.Forms
{
    // Форма, отвечающая за ввод ранений персонажа.
    public partial class InjuriesInput : Form
    {
        // Список объектов ранений.
        // Через эту переменную список передаётся в Hub.cs.
        public List<Database.Injury> input = new List<Database.Injury>();

        public InjuriesInput()
        {
            InitializeComponent();

            // Добавляем все существующие типы ранений в список возможных.
            LB_PossibleInj.Items.AddRange(Database.Injury.names);
        }

        private void BT_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BT_Next_Click(object sender, EventArgs e)
        {
            // Проверка, было ли добавлено хотя бы одно ранение.
            if (LB_ActualInj.Items.Count == 0)
                GUIMessageBox.ShowDlg(new string[] { "", "Сначала внесите инорфмацию о повреждениях." });
            else
            { 
                // Нужно перевести интерфейсное представление введённых ранений в программное.

                List<object> checkedList = new List<object>();
                for (int i = 0; i < LB_ActualInj.Items.Count; i++)
                {
                    object item = LB_ActualInj.Items[i];
                    if (!checkedList.Contains(item))
                    {
                        checkedList.Add(item);

                        int count = 0;
                        for (int j = 0; j < LB_ActualInj.Items.Count; j++)
                        {
                            if (item.ToString() == LB_ActualInj.Items[j].ToString() && (j != i))
                            {
                                count++;
                            }
                        }

                        input.Add(new Database.Injury(
                            Database.Injury.FindTypeByName(item.ToString()),
                            (Database.Injury.Amount)count)
                            );
                    }
                }

                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            if (ObjectsAmount(LB_ActualInj, LB_PossibleInj.SelectedItem) >= 3)
                GUIMessageBox.ShowDlg("Не больше трёх ранений одного типа!");
            else
            {
                if (LB_PossibleInj.SelectedItem != null)
                    LB_ActualInj.Items.Add(LB_PossibleInj.SelectedItem);
                else
                    GUIMessageBox.ShowDlg("Сначала выберите тип ранения.");
            }
        }

        /// <summary>
        /// Возвращает количество вхождений данного объекта в данный список.
        /// </summary>
        private int ObjectsAmount(ListBox listBox, object item)
        {
            int cnt = 0;

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (listBox.Items[i].Equals(item))
                    cnt++;
            }

            return cnt;
        }

        private void BT_Remove_Click(object sender, EventArgs e)
        {
            if (LB_ActualInj.SelectedItem != null)
                LB_ActualInj.Items.Remove(LB_ActualInj.SelectedItem);
            else
                GUIMessageBox.ShowDlg("Сначала выберите ранение.");
        }

        // Методы воспроизведения звука кнопок
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
