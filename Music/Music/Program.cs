using System;
using System.Collections.Generic;

namespace Music
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("MusicRelax", "г.Москва, ул.Манговая, д.Тропический");
            Audio kino = new Audio("Группа Кино", "Мелодия", 10, "Группа Крови", "Русский рок");
            Audio pik = new Audio("Пикник", "г.Москва", 12, "Королевство кривых", "Русский рок");
            DVD har = new DVD("Джоан Кэтлин Роулинг", "WarnerBros", 1179, "Гарри Поттер и кубок Огня", "Adventure, Fantasy");
            DVD one = new DVD("Хаяо Миядзаки", "Хаяо Миядзаки", 119, "Ходячий замок", "Аниме");
            har.Burn("Platform", "HORROR", "Гальдер Гастелу-Уррутия", "Netflix", "94");
            store += kino;
            store += pik;
            store += har;
            store += one;
            Console.WriteLine(store.ToString());
            string audio = "";
            string dvd = "";
            foreach(Audio i in store.GetAudio)
            {
                audio += string.Join("\n", "\n" + i.GetName + " - " + i.GetSize);
            }
            foreach(DVD i in store.GetDvds)
            {
                dvd += string.Join("\n", "\n" + i.GetName + " - " + i.GetSize);
            }
            Console.WriteLine("\n" + audio + "\n" + dvd);
        }
    }
}