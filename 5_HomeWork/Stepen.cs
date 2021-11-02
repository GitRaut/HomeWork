using System;
using System.Collections.Generic;

namespace WASP_ACADEMY
{
    class Stepen
    {
		public static void Main(string[] args)
		{
            int num = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int n = num;
            while(num < step)
            {
                num = num * n;
            }
            if(num == step)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
	}
}
