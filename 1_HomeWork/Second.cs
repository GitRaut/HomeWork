using System;

namespace WASP_ACADEMY
{
	class Second
	{
		static void Main(string[] args)
		{
			int x = int.Parse(Console.ReadLine());
			int y = int.Parse(Console.ReadLine());
			int x1 = int.Parse(Console.ReadLine());
			int y1 = int.Parse(Console.ReadLine());

			if ((x != x1) & (y != y1))
			{
				Console.WriteLine("NO");
			}
			if ((x == x1) & (y == y1))
			{
				Console.WriteLine("NO");
			}
			if ((x == x1) && (y != y1))
			{
				Console.WriteLine("YES");
			}
			if ((y == y1) && (x != x1))
			{
				Console.WriteLine("YES");
			}
		}
	}
}
