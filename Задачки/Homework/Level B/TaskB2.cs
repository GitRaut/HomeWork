using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B2.
    // Кол-во стингеров: 🔹
    //
    // Написать функцию OrderWeight(List<int> list), которая сортирует список положительных чисел.
    // Критерий сортировки - возрастание веса числа (сумма всех цифр числа).
    // Если два числа имеют одинаковый вес, сортировать их так, словно они строки.
    //
    // Пример:
    // [56, 65, 74, 100, 99, 68, 86, 180, 90] ==>
    // [100, 180, 90, 56, 65, 74, 68, 86, 99]
    public static class TaskB2
    {
        public static int first_num(int n)
        {
            int fr = 0;
            while(n > 0)
            {
                fr = n % 10;
                n = n / 10;
            }
            return fr;
        }
        public static List<int> OrderWeight(List<int> list)
        {
            List<int> prom = new List<int>();
            List<int> otv = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                otv.Add(list[i]);
            }
            int sum = 0, flag, point;
            for (int i = 0; i < list.Count; i++)
            {
                while (list[i] > 0)
                {
                    sum += list[i] % 10;
                    list[i] = list[i] / 10;
                }
                prom.Add(sum);
                sum = 0;
            }
            for (int i = 0; i < prom.Count; i++)
            {
                for (int j = 0; j < prom.Count - 1; j++)
                {
                    if (prom[j] > prom[j + 1])
                    {
                        flag = otv[j];
                        otv[j] = otv[j + 1];
                        otv[j + 1] = flag;
                        point = prom[j];
                        prom[j] = prom[j + 1];
                        prom[j + 1] = point;
                    }
                    if ((prom[j] == prom[j + 1]) && (first_num(otv[j]) > first_num(otv[j + 1])))
                    {
                        flag = otv[j];
                        otv[j] = otv[j + 1];
                        otv[j + 1] = flag;
                        point = prom[j];
                        prom[j] = prom[j + 1];
                        prom[j + 1] = point;
                    }
                }
            }
            return otv;
        }
    }
}
