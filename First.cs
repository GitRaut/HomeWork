using System;

namespace WASP_ACADEMY
{
    class Program
    {
        static void Main(string[] args)
        {
			int first = int.Parse(Console.ReadLine());
			int second = int.Parse(Console.ReadLine());
			int third = int.Parse(Console.ReadLine());

			if ((first == second) & (first == third))
			{
				Console.WriteLine(3);
			}
			if ((first == second) & (first != third))
			{
				Console.WriteLine(2);
			}
			if ((first == third) & (first != second))
			{
				Console.WriteLine(2);
			}
			if((first != second) & (first != third) & (second != third))
			{
				Console.WriteLine(0);
			}
		}
    }
}
