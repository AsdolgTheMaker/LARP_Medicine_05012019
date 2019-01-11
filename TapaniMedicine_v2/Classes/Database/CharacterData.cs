using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapaniMedicine_v2.Database
{ 
    /// <summary>
    /// Класс данных о персонаже. Содержит информацию о личности и идентификаторе персонажа, его состоянии и характеристиках, а также заметки врача.
    /// </summary>
    public class CharacterData
    {
        // ID персонажа.
        public string id = "0000";

        // Состояние персонажа.
        public State state = State.ALIVE;

        public enum State
        {
            ALIVE,
            DEAD,
            FROZEN
        }

        // Словарь личностных идентификаторов персонажа.
        public Dictionary<string, string> Person = new Dictionary<string, string>()
        {
            ["name"] = "",
            ["surname"] = "",
            ["title"] = ""
        };

        // Словарь характеристик персонажа.
        public Dictionary<string, int> Stats = new Dictionary<string, int>()
        {
            ["blood"] = 5400,
            ["hpres"] = 120, 
            ["lpres"] = 80,    
            ["pulse"] = 60
        };

        // Заметки врача не сохраняются вне сессии (т.е. теряются при закрытии программы).
        public string[] docNotes;

        /// <summary>
        /// Главный конструктор класса.
        /// </summary>
        /// <param name="_id">4-циферный идентификатор персонажа.</param>
        /// <param name="title">Титул персонажа (если нет - любой ОДИН символ).</param>
        /// <param name="name">Имя персонажа.</param>
        /// <param name="surname">Фамилия персонажа (можно вставить пустую строку).</param>
        /// <param name="_state">Состояние персонажа (0 - жив, 1 - мёртв, 2 - заморожен).</param>
        public CharacterData(string _id, string title, string name, string surname, int _state)
        {
            // Переносим данные из аргументов в поля.
            id = _id;
            Person["name"] = name;
            Person["surname"] = surname;
            Person["title"] = (title.Length == 1) ? "Нет титула" : title;

            if (_state == 1)
                state = State.DEAD;
            else if (_state == 2)
                state = State.FROZEN;
            else state = State.ALIVE;

            RandomizeStats(new Random().Next(1000, 100000000));
        }

        // Вспомогательный конструктор, который, по-хорошему, использовать не следует.
        public CharacterData()
        { 
            RandomizeStats(new Random().Next(1000, 100000000));
        }

        // При создании объекта в характеристики вносится фактор рандома.
        private void RandomizeStats(int seed)
        {
            Random random = new Random(seed);
            Stats["blood"] += random.Next(-250, 250);
            Stats["hpres"] += random.Next(-12, 12);
            Stats["lpres"] += random.Next(-7, 7);
            Stats["pulse"] += random.Next(-5, 5);
        }

        public override string ToString()
        {
            string result = id + "#" +
                (Person["title"] == "Нет титула" ? "%" : Person["title"]) + "#" +
                Person["name"] + "#" +
                Person["surname"] + "#" +
                ((int)state).ToString();

            return result;
        }
    }
}