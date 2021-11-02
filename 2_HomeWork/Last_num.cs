using System;

namespace WASP_ACADEMY
{
	class Last_num
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			int result = num % 10;
			Console.WriteLine(result);
		}
	}
}