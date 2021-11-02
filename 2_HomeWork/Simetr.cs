using System;

namespace WASP_ACADEMY
{
	class Simetr
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			int result = 0, point = 0;
			while(num > 0)
            {
				point = num % 10;
				result = result * 10 + point;
				num = num / 10;
            }
			Console.WriteLine(result);
		}
	}
}