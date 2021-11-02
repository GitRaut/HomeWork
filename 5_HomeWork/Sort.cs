using System;
using System.Collections.Generic;

namespace WASP_ACADEMY
{
    class Sr_deviation
    {
		public static void Main(string[] args)
		{
            int col = int.Parse(Console.ReadLine());
            int[] mass = new int[col];
            int flag = 0;
            string[] spl = Console.ReadLine().Split(" ");
            for(int i = 0; i < mass.Length; i++)
            {
                mass[i] = int.Parse(spl[i]);
            }
            for(int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length - 1; j++)
                {
                    if(mass[j] < mass[j + 1])
                    {
                        flag = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = flag;
                    }
                }
            }
            for(int i = mass.Length - 1; i > 0; i--)
            {
                Console.Write(mass[i] + " ");
            }
        }
	}
}
