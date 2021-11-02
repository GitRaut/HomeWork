using System;
using System.Collections.Generic;

namespace WASP_ACADEMY
{
    class Once_elem
    {
		public static void Main(string[] args)
		{
            int col = int.Parse(Console.ReadLine());
            int[] mass = new int[col];
            string[] mas = Console.ReadLine().Split(" ");
            int flag = 0, num = 0;
            for(int i = 0; i < col; i++)
            {
                mass[i] = int.Parse(mas[i]);
            }
            for(int i = 0; i < mass.Length; i++) 
            {
                for (int j = 0; j < col; j++)
                {
                    if (mass[i] == mass[j])
                    {
                        flag++;
                    }
                }
                if(flag == 1)
                {
                    Console.Write(mass[i] + " ");
                }
                flag = 0;
            }
        }
	}
}
