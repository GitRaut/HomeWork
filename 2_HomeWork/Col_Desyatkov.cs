using System;

namespace WASP_ACADEMY
{
	class Last_num
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			int last_num = num % 100;
			int result = last_num / 10;
			Console.WriteLine(result);
		}
	}
}