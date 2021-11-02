using System;

namespace WASP_ACADEMY
{
	class Belochki
	{
		static void Main(string[] args)
		{
			int col = int.Parse(Console.ReadLine());
			int nut = int.Parse(Console.ReadLine());
			int result = nut / col;
			Console.WriteLine(result);
		}
	}
}