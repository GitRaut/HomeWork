using System;
using System.Collections.Generic;

namespace WASP_ACADEMY
{
    class Stepen
    {
		public static void Main(string[] args)
		{
            double x, col = 0, sum = 0, chisl = 0, otv = 0;
            List<double> mass = new List<double>();
            do
            {
                x = double.Parse(Console.ReadLine());
                mass.Add(x);
            }
            while (x != 0);
            for(int i = 0; i < mass.Count - 1; i++)
            {
                col++;
                sum += mass[i];
            }
            double sr = sum / col;
            double znam = col - 1;
            for (int i = 0; i < mass.Count - 1; i++)
            {
                chisl += Math.Pow(mass[i] - sr, 2); 
            }
            otv = Math.Sqrt(chisl / znam);
            Console.WriteLine(otv);
        }
	}
}
