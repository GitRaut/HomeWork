using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B4.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию CheckBrackets(string s), которая определяет,
    // правильно ли расставлены скобки () {} [] <> в предложении.
    //
    // Примеры:
    // CheckBrackets("(abc)[]{0:1}") ==> true;
    // CheckBrackets("(abc)]{0:1}[") ==> false.
    public static class TaskB4
    {
        public static bool check(string s, char tip, char tip_rev)
        {
            int count = 0;
            bool symbol;
            char last = tip_rev;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == tip)
                {
                    count++;
                    last = s[i];
                }
                if (s[i] == tip_rev && last == tip)
                {
                    count--;
                }
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckBrackets(string s)
        {
            List<bool> res = new List<bool>();
            res.Add(check(s, '(', ')'));
            res.Add(check(s, '{', '}'));
            res.Add(check(s, '[', ']'));
            res.Add(check(s, '<', '>'));
            int count = 0;
            for (int i = 0; i < res.Count; i++)
            {
                if (res[i] == false)
                {
                    return false;
                    break;
                }
                if (res[i] == true)
                {
                    count++;
                }
            }
            if (count == res.Count)
            {
                return true;
            }
            return false;
        }
    }
}
