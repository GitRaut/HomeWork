using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B5.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Frame(string text, char symbol), которая заключает
    // список строк text в рамку из символов char и возвращает данную строку.
    //
    // Пример:
    // frame(['Create', 'a', 'frame'], '+') ==>
    // ++++++++++
    // + Create +
    // + a      +
    // + frame  +
    // ++++++++++
    public static class TaskB5
    {
        public static int Max(List<string> text)//находит самый длинный элмемнт списка
        {
            int max = 0;
            for (int i = 0; i < text.Count; i++)
            {
                if (text[i].Length > max)
                {
                    max = text[i].Length;
                }
            }
            return max;
        }
        public static string Frame(List<string> text, char symbol)
        {
            int max = Max(text);
            string s;
            for (int i = 0; i < text.Count; i++)
            {
                s = new string(' ', max - text[i].Length);
                text[i] = symbol + " " + text[i] + s + " " + symbol;
            }
            s = new string(symbol, Max(text));
            text.Add(s);
            text.Insert(0, s);//добавляет элемент в начало списка
            string res = string.Join("\n", text.ToArray());
            return res;
        }
    }
}
