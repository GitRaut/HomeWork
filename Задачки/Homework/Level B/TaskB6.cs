using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B6.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Reverser, которая меняет порядок букв в каждом слове заданного
    // предложения на противоположный, порядок слов, при этом, должен сохраниться.
    //
    // Пример:
    // Reverser("reverse letters") ==> "esrever srettel".
    public static class TaskB6
    {
        public static string Reverser(string s)
        {
            char[] rev = s.ToCharArray();//преобразует строку в массив типа char
            Array.Reverse(rev);//переворачивает массив
            s = new string(rev);
            string[] otv = s.Split(' ');
            Array.Reverse(otv);
            string result = string.Join(" ", otv);//соединяет элементы массива в строке через заданный символ в кавычках(" ");
            return result;
        }
    }
}
