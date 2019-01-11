using System.Collections.Generic;
using TapaniMedicine_v2.Classes.Forms;

namespace TapaniMedicine_v2.Database
{
    /// <summary>
    /// Ключевой класс программы, представляющий и обрабатывающий данные о текущей операции и её пациенте.
    /// </summary>
    public class OperationInfo
    {
        // Полный список повреждений, которые необходимо вылечить.
        public List<Damage> damageList = new List<Damage>();

        // Данные пациента (подлежат изменению!)
        public CharacterData patient;

        // Завершена ли операция?
        public bool isFinished = false;


        // Тут нужно сделать небольшое пояснение. 
        // Ошибочной попыткой считается нажатие кнопки, не соответствующей порядку лечения 
        // повреждения. Однако после лечения повреждения происходит "стабилизация", 
        // компенсирующая одну ошибочную попытку. Т.е. можно совершить больше, 
        // чем maxAttempts ошибок за операцию. Однако ВСЕ ошибочные попытки будут учитываться
        // при формировании последствий операции.

        // Ошибочные попытки без учёта стабилизации
        public int fails = 0;
            
        // Текущее кол-во попыток, учитывающее стабилизацию
        public int attempt = 0;
            
        // Максимально возможное кол-во попыток, при котором операция проваливается.
        public const int maxAttempts = 6;


        // Словарь со стандартными характеристиками. Честно говоря, уже не помню, зачем он нужен.
        // Скорее всего, он не используется вообще (как и характеристика 'stability').
        public Dictionary<string, int> DefaultStats = new Dictionary<string, int>()
        {
            ["stability"] = 100,
            ["blood"] = 5400,
            ["hpres"] = 120,
            ["lpres"] = 80,
            ["pulse"] = 60,
            ["pain"] = 0
        };

        // Словарь критических значений характеристик, при которых пациент получает критическое состояние.
        // На деле же, этот словарь необходим, чтобы характеристики случайно не вышли за разумные пределы.
        public Dictionary<string, int> CriticalStats = new Dictionary<string, int>()
        {
            ["stability"] = 0,
            ["blood"] = 400,
            ["hpres"] = 220,
            ["lpres"] = 150,
            ["pulse"] = 120,
            ["pain"] = 100
        };

        // Словарь текущих характеристик. Тут и комментировать нечего.
        public Dictionary<string, int> Stats = new Dictionary<string, int>()
        {
            ["stability"] = 100,
            ["blood"] = 5400,
            ["hpres"] = 120,
            ["lpres"] = 80,
            ["pulse"] = 60,
            ["pain"] = 0
        };

        public OperationInfo(CharacterData data, Injury[] injuries)
        {
            patient = data;
            damageList = InjuriesToDamages(injuries);
            PatientDataToStats();
        }

        public OperationInfo(CharacterData data)
        {
            patient = data;
            PatientDataToStats();
        }

        // Характеристики получают стандартные для пациента значения. 
        // Почему я просто не приравнял один словарь к другому? Да хоть убей - не помню.
        private void PatientDataToStats()
        {
            Stats["blood"] = patient.Stats["blood"];
            Stats["hpres"] = patient.Stats["hpres"];
            Stats["lpres"] = patient.Stats["lpres"];
            Stats["pulse"] = patient.Stats["pulse"];
        }

        // Наносим урон пациенту, основываясь на текущем состоянии (чем больше ошибок совершено - тем больше урон).
        public void HurtStats()
        {
            if (fails < 7) fails++;
            int dmgLevel = attempt;

            Stats["blood"] -= 250 * dmgLevel;
            Stats["hpres"] += 5 * dmgLevel;
            Stats["lpres"] += 4 * dmgLevel;
            Stats["pulse"] += 3 * dmgLevel;
            Stats["pain"] += 5 * dmgLevel;

            if (Stats["blood"] < 0)
                Stats["blood"] = 0;
            if (Stats["pain"] > 100)
                Stats["pain"] = 100;
        }

        // Лечим пациента на один уровень, т.е. проводим реверс последнего метода HurtStats.
        public void HealStats()
        {            
            int dmgLevel = attempt;

            Stats["blood"] += 250 * dmgLevel;
            Stats["hpres"] -= 5 * dmgLevel;
            Stats["lpres"] -= 4 * dmgLevel;
            Stats["pulse"] -= 3 * dmgLevel;
            Stats["pain"] -= 5 * dmgLevel;

            if (attempt > 0)
                attempt--;
        }

        // Возвращаем пациента в норму по завершению операции
        public void Healed()
        {
            Stats = patient.Stats;
            isFinished = true;
        }

        // Пациент умирает.
        public void Dead()
        {
            patient.state = CharacterData.State.DEAD;
            Stats["pulse"] = 0;
            Stats["pain"] = 100;
        }

        /// <summary>
        /// Находится ли пациент в критическом состоянии?
        /// </summary>
        public bool IsCritical()
        {
            if (attempt >= maxAttempts - 1)
                return true;
            else return false;
        }


        // Конвертация массива ранений в список повреждений
        public static List<Damage> InjuriesToDamages(Injury[] injuries)
        {
            List<Damage> dmg = new List<Damage>();
            for (int i = 0; i < injuries.Length; i++)
            {
                for (int j = 0; j < injuries[i].damages.Count; j++)
                {
                    dmg.Add(injuries[i].damages[j]);
                }
            }
            return dmg;
        }

        // Конвертация массива повреждений в массив их наименований
        public static string[] DamagesToString(Damage[] damages)
        {
            string[] result = new string[damages.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = damages[i].name;
            }
            return result;
        }
    }
}
