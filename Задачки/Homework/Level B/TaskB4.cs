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
        public static bool CheckBrackets(string s)
        {
            Stack<char> otv = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char skob = s[i];
                if (skob == '[' || skob == '{' || skob == '(' || skob == '<')
                    otv.Push(skob);
                else if (skob == ']' || skob == '}' || skob == ')' || skob == '>')
                {
                    if (!otv.Any())
                    {
                        return false;
                    }
                    switch (skob)
                    {
                        case ']':
                            if (otv.Pop() != '[')
                            {
                                return false;
                            }
                            break;
                        case '}':
                            if (otv.Pop() != '{')
                            {
                                return false;
                            }
                            break;
                        case ')':
                            if (otv.Pop() != '(')
                            {
                                return false;
                            }
                            break;
                        case '>':
                            if (otv.Pop() != '<')
                            {
                                return false;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            if (!otv.Any())
            {
                return true;
            }
            return false;
        }
    }
}
