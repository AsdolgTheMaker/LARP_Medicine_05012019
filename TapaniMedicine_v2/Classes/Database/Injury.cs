using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapaniMedicine_v2.Database
{
    /// <summary>
    /// Класс, представляющий информацию о ранении и нанесённых им повреждениях.
    /// </summary>
    public class Injury
    {
        // Список повреждений от ранения.
        public List<Damage> damages;

        // Наименование
        public string name;

        // Тип
        public Type type;

        // Тяжесть
        public Amount amount;

        public enum Type
        {
            BLASTER,
            GRENADE,
            BREAK,
            ELECTRO,
            VIBRO,
            LIGHT,
            NONE
        }
        public enum Amount
        {
            LIGHT,
            MEDIUM,
            HEAVY
        }

        // Список имён
        public static string[] names = new string[]
        {
            "Выстрел из бластера",
            "Осколочные ранения",
            "Перелом",
            "Поражение электричеством",
            "Рана от виброклинка",
            "Рана от светового меча"
        };

        // Словарь для конвертации. Да, не очень.
        public static Dictionary<string, Type> NamesTypesDictionary = new Dictionary<string, Type>()
        {
            [names[0]] = Type.BLASTER,
            [names[1]] = Type.GRENADE,
            [names[2]] = Type.BREAK,
            [names[3]] = Type.ELECTRO,
            [names[4]] = Type.VIBRO,
            [names[5]] = Type.LIGHT
        };

        public Injury(Type srcType, Amount srcAmount)
        {
            damages = new List<Damage>();
            amount = srcAmount;
            type = srcType;

            // Далее идёт формирование объекта, исходя из типа и тяжести ранения.
            switch (srcType)
            {
                case Type.BLASTER:
                    {
                        name = names[0];
                        switch (srcAmount)
                        {
                            case Amount.LIGHT:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.OPEN)
                                    });
                                    break;
                                }
                            case Amount.MEDIUM:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.NERV)
                                    });
                                    break;
                                }
                            case Amount.HEAVY:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.VEIL),
                                        new Damage(Damage.Type.NERV)
                                    });
                                    break;
                                }
                        }
                        break;
                    }
                case Type.GRENADE:
                    {
                        name = names[1];
                        switch (srcAmount)
                        {
                            case Amount.LIGHT:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN)
                                    });
                                    break;
                                }
                            case Amount.MEDIUM:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.BURN)
                                    });
                                    break;
                                }
                            case Amount.HEAVY:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.BURN)
                                    });
                                    break;
                                }
                        }
                        break;
                    }
                case Type.BREAK:
                    {
                        name = names[2];
                        switch (srcAmount)
                        {
                            case Amount.LIGHT:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.BREAK)
                                    });
                                    break;
                                }
                            case Amount.MEDIUM:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.BREAK),
                                        new Damage(Damage.Type.BREAK),
                                        new Damage(Damage.Type.NERV)
                                    });
                                    break;
                                }
                            case Amount.HEAVY:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.BREAK),
                                        new Damage(Damage.Type.BREAK),
                                        new Damage(Damage.Type.BREAK),
                                        new Damage(Damage.Type.NERV),
                                        new Damage(Damage.Type.VEIL)
                                    });
                                    break;
                                }
                        }
                        break;
                    }
                case Type.ELECTRO:
                    {
                        name = names[3];
                        switch (srcAmount)
                        {
                            case Amount.LIGHT:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.VEIL)
                                    });
                                    break;
                                }
                            case Amount.MEDIUM:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.VEIL),
                                        new Damage(Damage.Type.VEIL)
                                    });
                                    break;
                                }
                            case Amount.HEAVY:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.VEIL),
                                        new Damage(Damage.Type.VEIL),
                                        new Damage(Damage.Type.VEIL),
                                        new Damage(Damage.Type.NERV),
                                    });
                                    break;
                                }
                        }
                        break;
                    }
                case Type.VIBRO:
                    {
                        name = names[4];
                        switch (srcAmount)
                        {
                            case Amount.LIGHT:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.VEIL)
                                    });
                                    break;
                                }
                            case Amount.MEDIUM:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.VEIL),
                                        new Damage(Damage.Type.NERV)
                                    });
                                    break;
                                }
                            case Amount.HEAVY:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.NERV),
                                        new Damage(Damage.Type.VEIL)
                                    });
                                    break;
                                }
                        }
                        break;
                    }
                case Type.LIGHT:
                    {
                        name = names[5];
                        switch (srcAmount)
                        {
                            case Amount.LIGHT:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.VEIL)
                                    });
                                    break;
                                }
                            case Amount.MEDIUM:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.VEIL),
                                        new Damage(Damage.Type.VEIL),
                                        new Damage(Damage.Type.NERV)
                                    });
                                    break;
                                }
                            case Amount.HEAVY:
                                {
                                    damages.AddRange(new Damage[]
                                    {
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.BURN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.OPEN),
                                        new Damage(Damage.Type.VEIL),
                                        new Damage(Damage.Type.VEIL),
                                        new Damage(Damage.Type.VEIL),
                                        new Damage(Damage.Type.NERV)
                                    });
                                    break;
                                }
                        }
                        break;
                    }
                case Type.NONE:
                    {
                        name = "";
                        amount = Amount.LIGHT;
                        break;
                    }
            }
        }

        /// <summary>
        /// Возвращает тип ранения исходя из наименования.
        /// </summary>
        public static Type FindTypeByName(string name)
        {
            return NamesTypesDictionary[name];
        }
    }
}