using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapaniMedicine_v2.Database
{
    // Этот класс можно было написать лучше, но на тот момент - как смог.
    /// <summary>
    /// Класс, описывающий действия при операции.
    /// </summary>
    public class Action
    {
        // Номер нужен для определения правильного порядка при проведении операции.
        public int number;

        // Сколько времени должно занимать действие? (OBSOLETE)
        public int time = new Random().Next(500, 1000);

        // Описание действия для диалогового окна при ожидании (OBSOLETE)
        public string procdesc = "Применение...";

        // Тип действия
        public Type type;

        public enum Type
        {
            DEFIBRILATOR,
            CLOSEINJ,
            FIXBONE,
            FIXNERV,
            FIXVEIL,
            REMOVEDMGSKIN,
            ADDFIXBANDAGE,
            CUT,
            MDCN_BACTA,
            MDCN_SALT,
            MDCN_SKINHERMETIC,
            MDCN_RILL,
            MDCN_STIM,
            MDCN_PHYS
        }

        public Action(Type srcType)
        {
            type = srcType;

            // Создаваемые объекты имеют предопределённый набор параметров, зависящий от типа.
            switch (srcType)
            {
                case Type.DEFIBRILATOR:
                    {
                        procdesc = "Разряд дефибрилятора...";
                        number = 1;
                        time = new Random().Next(900, 1500);
                        break;
                    }
                case Type.CLOSEINJ:
                    {
                        procdesc = "Закрытие раны...";
                        time = new Random().Next(6000, 9000);
                        number = 2;
                        break;
                    }
                case Type.FIXBONE:
                    {
                        procdesc = "Вправление кости...";
                        time = new Random().Next(5000, 9000);
                        number = 3;
                        break;
                    }
                case Type.FIXNERV:
                    {
                        procdesc = "Восстановление нерва...";
                        time = new Random().Next(9000, 13000);
                        number = 4;
                        break;
                    }
                case Type.FIXVEIL:
                    {
                        procdesc = "Восстановление сосуда...";
                        time = new Random().Next(8000, 15000);
                        number = 5;
                        break;
                    }
                case Type.REMOVEDMGSKIN:
                    {
                        procdesc = "Удаление поражённых участков кожи...";
                        time = new Random().Next(10000, 20000);
                        number = 6;
                        break;
                    }
                case Type.ADDFIXBANDAGE:
                    {
                        procdesc = "Наложение фиксирующей повязки...";
                        time = new Random().Next(2000, 4000);
                        number = 7;
                        break;
                    }
                case Type.CUT:
                    {
                        procdesc = "Проведение разреза...";
                        time = new Random().Next(1000, 3000);
                        number = 8;
                        break;
                    }
                case Type.MDCN_BACTA:
                    {
                        procdesc = "Ввод бакты...";
                        number = 11;
                        break;
                    }
                case Type.MDCN_SALT:
                    {
                        procdesc = "Ввод фосован-соли...";
                        number = 12;
                        break;
                    }
                case Type.MDCN_SKINHERMETIC:
                    {
                        procdesc = "Нанесение кожного герметика...";
                        number = 13;
                        break;
                    }
                case Type.MDCN_RILL:
                    {
                        procdesc = "Ввод рилла...";
                        number = 14;
                        break;
                    }
                case Type.MDCN_STIM:
                    {
                        procdesc = "Ввод стимулятора...";
                        number = 15;
                        break;
                    }
                case Type.MDCN_PHYS:
                    {
                        procdesc = "Ввод физраствора...";
                        number = 16;
                        break;
                    }
            }
        }

        /// <summary>
        /// Возвращает тип действия, исходя из его названия.
        /// </summary>
        public static Type GetTypeByName(string name)
        { // Это необходимо для использования кнопок. Не лучшее решение, но уж как есть.
            switch (name)
            {
                case "Дефибрилятор": return Type.DEFIBRILATOR;
                case "Зашить рану": return Type.CLOSEINJ;
                case "Вправить кость": return Type.FIXBONE;
                case "Соединить нерв": return Type.FIXNERV;
                case "Соединить сосуд": return Type.FIXVEIL;
                case "Удалить поражённые участки кожи": return Type.REMOVEDMGSKIN;
                case "Нанести фиксирующую повязку": return Type.ADDFIXBANDAGE;
                case "Выполнить надрез": return Type.CUT;
                case "Бакта": return Type.MDCN_BACTA;
                case "Фосован-соль": return Type.MDCN_SALT;
                case "Лечебный кожный герметик": return Type.MDCN_SKINHERMETIC;
                case "Рилл": return Type.MDCN_RILL;
                case "Стимулятор": return Type.MDCN_STIM;
                case "Физраствор": return Type.MDCN_PHYS;
                default:
                    { // Подобного случаться не должно, поэтому необходимо сообщить об ошибке.
                        TapaniMedicine_v2.Classes.Forms.GUIMessageBox.ShowDlg("Неверный ввод действия \"" + name + "\".");
                        return Type.MDCN_PHYS;
                    }
            }
        }
    }
}