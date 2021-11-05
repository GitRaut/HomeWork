using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача C2.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию ChangeCent(int money), которая принимает количество американской валюты в центах и
    // возвращает список из четырех значений, который показывает наименьшее количество монет, используемых для составления этой суммы. 
    // Рассматриваются только монетные номиналы: Pennie (1 цент), Nickel (5 центов), Dime (10 центов) and Quarter (25 центов).
    // Возвращаемый список должен быть формата [кол-во Pennie, кол-во Nickel, кол-во Dime, кол-во Quarter].
    // Если в функцию передается вещественное число, его значение сперва должно быть округлено в меньшую сторону.
    // 
    // Пример:
    // ChangeCent(56) ==> [1,1,0,2] --> 1 * 1 + 1 * 5 + 0 * 10 + 2 * 25.
    public static class TaskC2
    {
        public static List<int> ChangeCent(double money)
        {
            money = Math.Truncate(money);
            List<int> otv = new List<int>() { 0, 0, 0, 0 };
            int count = 0;
            while (count * 25 < money - 25)
            {
                count++;
            }
            otv[3] = count;
            money -= count * 25;
            count = 0;
            while (count * 10 < money - 10)
            {
                count++;
            }
            otv[2] = count;
            money -= count * 10;
            count = 0;
            while (count * 5 < money - 5)
            {
                count++;
            }
            otv[1] = count;
            money -= count * 5;
            count = 0;
            while (money != 0)
            {
                money--;
                count++;
            }
            otv[0] = count;

            return otv;
        }
    }
}
