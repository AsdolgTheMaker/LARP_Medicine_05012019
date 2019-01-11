using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapaniMedicine_v2.Classes.Forms;

namespace TapaniMedicine_v2.Database
{
    /// <summary>
    /// Класс, представляющий данные о повреждении, а именно - его имени и порядке лечения.
    /// </summary>
    public class Damage
    {
        // Название повреждения
        public string name;

        // Очередь лечения
        public Queue<int> order = new Queue<int>();

        // Тип повреждения
        public Type type;

        public enum Type
        {
            BURN,
            OPEN,
            BREAK,
            VEIL,
            NERV
        }

        public Damage(Type srcDmg)
        {
            // Порядок лечения и наименование зависят от выбранного типа
            switch (srcDmg)
            {
                case Type.BURN:
                    {
                        name = "Ожог";
                        order.Enqueue(12);
                        order.Enqueue(6);
                        order.Enqueue(13);
                        break;
                    }
                case Type.OPEN:
                    {
                        name = "Открытая рана";
                        order.Enqueue(12);
                        order.Enqueue(2);
                        break;
                    }
                case Type.BREAK:
                    {
                        name = "Перелом";
                        order.Enqueue(13);
                        order.Enqueue(3);
                        order.Enqueue(7);
                        break;
                    }
                case Type.VEIL:
                    {
                        name = "Разорваный сосуд";
                        order.Enqueue(12);
                        order.Enqueue(8);
                        order.Enqueue(14);
                        order.Enqueue(5);
                        order.Enqueue(2);
                        break;
                    }
                case Type.NERV:
                    {
                        name = "Разорваный нерв";
                        order.Enqueue(12);
                        order.Enqueue(8);
                        order.Enqueue(15);
                        order.Enqueue(4);
                        order.Enqueue(2);
                        break;
                    }
            }
            type = srcDmg;
        }

        /// <summary>
        /// Возвращает тип повреждения, исходя из имени.
        /// </summary>
        public static Type GetTypeByName(string tgName)
        {
            switch (tgName)
            {
                case "Ожог": return Type.BURN;
                case "Открытая рана": return Type.OPEN;
                case "Перелом": return Type.BREAK;
                case "Разорваный сосуд": return Type.VEIL;
                case "Разорваный нерв": return Type.NERV;

                default:
                    { // Такого происходить не должно, поэтому сообщаем об ошибке.
                        GUIMessageBox.ShowDlg("Попытка получить несуществующий тип повреждения \"" + tgName + "\".");
                        return Type.BURN;
                    }
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}