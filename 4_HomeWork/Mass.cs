using System;
using System.Collections.Generic;

namespace thirdthird
{
    class Mass
    {
		static int[] sum(int[] one_dim, int[] one_dim_sec)//находит сумму одномерных массивов
		{
			int[] sum = new int[one_dim.Length];
			for(int i = 0; i < one_dim.Length; i++)
            {
				sum[i] = one_dim[i] + one_dim_sec[i]; 
            }
			return sum;
		}
		static int srznach(int num, int num_two)//находит среднее значение двух массивов 
		{
			int sr = 0, col1 = 0, col2 = 0, sum1 = 0, sum2 = 0;
			if (((num == 1) && (num_two == 2)) || ((num == 2) && (num_two == 1)))
            {
				int[] one_dim = enter();
				int[,] two_dim = enter_two();
				int col_str = two_dim.GetLength(0); //кол-во строк
				int col_stl = two_dim.GetLength(1); //кол-во столбцов
				for (int i = 0; i < one_dim.Length; i++)
                {
					col1++;
					sum1 += one_dim[i];
                }
				for (int i = 0; i < col_str; i++)
				{
					for (int j = 0; j < col_stl; j++)
					{
						col2++;
						sum2 += two_dim[i, j];
					}
				}
				sr = (sum1 + sum2) / (col1 + col2);
			}
			else if ((num == 1) && (num_two == 1))
            {
				int[] one_dim = enter();
				int[] one_dim_sec = enter();
				for (int i = 0; i < one_dim.Length; i++)
				{
					col1++;
					sum1 += one_dim[i];
				}
				for (int i = 0; i < one_dim_sec.Length; i++)
				{
					col2++;
					sum2 += one_dim_sec[i];
				}
				sr = (sum1 + sum2) / (col1 + col2);
			}
			else if ((num == 2) && (num_two == 2))
            {
				int[,] two_dim = enter_two();
				int col_str = two_dim.GetLength(0); //кол-во строк
				int col_stl = two_dim.GetLength(1); //кол-во столбцов
				int[,] two_dim_sec = enter_two();
				int col_str_sec = two_dim.GetLength(0); //кол-во строк
				int col_stl_sec = two_dim.GetLength(1); //кол-во столбцов
				for (int i = 0; i < col_str; i++)
				{
					for (int j = 0; j < col_stl; j++)
					{
						col1++;
						sum1 += two_dim[i, j];
					}
				}
				for (int i = 0; i < col_str_sec; i++)
				{
					for (int j = 0; j < col_stl_sec; j++)
					{
						col2++;
						sum2 += two_dim[i, j];
					}
				}
				sr = (sum1 + sum2) / (col1 + col2);
			} 
			else
            {
				Console.WriteLine("Error");
            }
			Console.WriteLine("Среднее значение всех элементов первого и второго массивов:");
			return sr;
		}
		static void max_min_two(int[,] two_dim)//находит минимальный и максимальный элемент двумерного массива и их количество
		{
			int col_str = two_dim.GetLength(0); //кол-во строк
			int col_stl = two_dim.GetLength(1); //кол-во столбцов
			int max = 0, min = two_dim[0, 0], colm = 0, colmi = 0;
			for (int i = 0; i < col_str; i++)
			{
				for (int j = 0; j < col_stl; j++)
				{
					if(two_dim[i, j] > max)
                    {
						max = two_dim[i, j];
                    }
					if(two_dim[i, j] < min)
                    {
						min = two_dim[i, j];
                    }
					if (two_dim[i, j] == max)
					{
						colm++;
					}
					if (two_dim[i, j] == min)
					{
						colmi++;
					}
				}
			}
			Console.WriteLine("Максимальное и минимальное значение массива и сколько раз они встречаются:");
			Console.WriteLine(max + ", встречается " + colm + " раз|" + min + ", встречается " + colmi + " раз");
		}
		static void max_min_one(int[] one_dim)//находит минимальный и максимальный элемент одномерного массива и их количество
		{
			int max = 0, min = one_dim[0], colm = 0, colmi = 0;
			for(int i = 0; i < one_dim.Length; i++)
            {
				if(one_dim[i] > max)
                {
					max = one_dim[i];
                }
				if(one_dim[i] < min)
                {
					min = one_dim[i];
                }
				if(one_dim[i] == max)
                {
					colm++;
                }
				if (one_dim[i] == min)
				{
					colmi++;
				}
			}
			Console.WriteLine("Максимальное и минимальное значение массива и сколько раз они встречаются:");
			Console.WriteLine(max + ", встречается " + colm + " раз|" + min + ", встречается " + colmi + " раз");
		}
		static int[,] enter_two()//функция ввода двумерного массива
		{
			int col_stl, col_str;
			int[,] two_dim;
			Console.WriteLine("Введите кол-во строк:");
			col_str = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите кол-во столбцов:");
			col_stl = int.Parse(Console.ReadLine());
			two_dim = new int[col_str, col_stl];
			Console.WriteLine("Введите элементы массива:");
			for (int i = 0; i < col_str; i++)
			{
				for (int j = 0; j < col_stl; j++)
				{
					two_dim[i, j] = int.Parse(Console.ReadLine());
				}
			}
			return two_dim;
		}

		static int[] enter()//функция ввода одномерного массива
		{
			int col;
			int[] one_dim;
			Console.WriteLine("Введите кол-во элементов в массиве:");
			col = int.Parse(Console.ReadLine());
			one_dim = new int[col];
			Console.WriteLine("Введите элементы массива:");
			for (int i = 0; i < col; i++)
			{
				one_dim[i] = int.Parse(Console.ReadLine());
			}
			return one_dim;
		}

		static void first(int num)//объединяющая функция(для удобства)
		{
			int col_mass;
			if (num == 1)
			{
				int[] one_dim = enter();
				Console.WriteLine("Введённый массив:");
				for (int i = 0; i < one_dim.Length; i++)
                {
					Console.Write(one_dim[i] + "|");
                }
				Console.WriteLine();
				max_min_one(one_dim);

			}
			if (num == 2)
			{
				int[,] two_dim = enter_two();
				int col_str = two_dim.GetLength(0); //кол-во строк
				int col_stl = two_dim.GetLength(1); //кол-во столбцов
				Console.WriteLine("Введённый массив:");
				for (int i = 0; i < col_str; i++)
				{
					for (int j = 0; j < col_stl; j++)
					{
						Console.Write(two_dim[i, j] + "|");
					}
					Console.WriteLine();
				}
				Console.WriteLine();
				max_min_two(two_dim);
			}
			if (num == 3)
			{
				Console.WriteLine("Введите кол-во массивов:");
				col_mass = int.Parse(Console.ReadLine());
				string[][] mass = new string[col_mass][];
				Console.WriteLine("Введите элемнты массивов через пробел и каждый массив на отдельной строке:");
				for (int i = 0; i < col_mass; i++)
				{
					mass[i] = Console.ReadLine().Split(',');
				}
				Console.WriteLine("Введённый массив:");
				for (int i = 0; i < col_mass; i++)
				{
					for (int j = 0; j < mass[i].Length; j++)
					{
						Console.Write(mass[i][j] + "|");
					}
					Console.WriteLine();
				}
			}
		}
		static int procent(int num, int num_two)
        {
			int col = 0, otv = 0;
			if ((num == 1) && (num_two == 1))
			{
				int[] one_dim = enter();
				int[] one_dim_sec = enter();
				int min = Math.Min(one_dim.Length, one_dim_sec.Length);//находит минимальную длину среди двух массивов
				for (int i = 0; i < min; i++)
				{
					if(one_dim[i] == one_dim_sec[i])
                    {
						col++;
                    }
				}
				otv = (col / min) * 100;
			}
			else
			{
				int[,] two_dim = enter_two();
				int col_str = two_dim.GetLength(0); //кол-во строк
				int col_stl = two_dim.GetLength(1); //кол-во столбцов
				int[,] two_dim_sec = enter_two();
				int col_str_sec = two_dim.GetLength(0); //кол-во строк
				int col_stl_sec = two_dim.GetLength(1); //кол-во столбцов
				int min_str = Math.Min(col_str, col_str_sec);//находит минимальную длину строк среди двух массивов
				int min_stl = Math.Min(col_stl, col_stl_sec);//находит минимальное количество столбцов среди двух массивов
				for (int i = 0; i < min_str; i++)
				{
					for (int j = 0; j < min_stl; j++)
					{
						if(two_dim[i, j] == two_dim_sec[i, j])
                        {
							col++;
                        }
					}
				}
				otv = (col / (min_str + min_stl)) * 100;
			}
			return otv;
		}
		public static void Main(string[] args)
		{
			Console.WriteLine("ВВОД И ВЫВОД МАССИВА И ЕГО МАКСИМАЛЬНОЕ И МИНИМАЛЬНОЕ ЗНАЧЕНИЯ:");
			Console.WriteLine();
			Console.WriteLine("Выбирите какйо массив использовать:) \n 1.Одномерный; \n 2.Двумерный; \n 3.Масив масивов;");
			int num, num_two;
			do {
				num = int.Parse(Console.ReadLine());
				if (num > 3 && num < 1)
				{
					Console.WriteLine("Так нельзя!");
				}
			}
			while ((num > 3) && (num < 1));
			first(num);
			Console.WriteLine();
			Console.WriteLine("СРЕДНЕЕ ЗНАЧЕНИЕ МАССИВОВ:");
			Console.WriteLine();
			Console.WriteLine("Выбирите какие массивы использовать:) \n 1.Одномерный; \n 2.Двумерный;");
			do
			{
				num = int.Parse(Console.ReadLine());
				num_two = int.Parse(Console.ReadLine());
				if ((num > 2 && num < 1) || (num_two > 2 && num_two < 1))
				{
					Console.WriteLine("Так нельзя!");
				}
			}
			while ((num > 2) && (num < 1) || (num_two > 2 && num_two < 1));
			Console.WriteLine(srznach(num, num_two));
			Console.WriteLine();
			Console.WriteLine("ВЫЧИСЛЕНИЕ СУММЫ ОДНОМЕРНЫХ МАССИВОВ:");
			Console.WriteLine();
			int[] one_dim;
			int[] one_dim_sec;
            do
            {
				one_dim = enter();
				one_dim_sec = enter();
				if(one_dim.Length != one_dim_sec.Length)
                {
					Console.WriteLine("Так нельзя!");
                }
			}
			while(one_dim.Length != one_dim_sec.Length);
			int[] su = sum(one_dim, one_dim_sec);
			for(int i = 0; i < su.Length; i++)
            {
				Console.Write(su[i] + "|");
            }
			Console.WriteLine();
			Console.WriteLine("НАХОЖДЕНИЕ ПРОЦЕНТНОГО СОВПАДЕНИЯ ЭЛЕМЕНТОВ В ДВУХ МАССИВАХ:");
			Console.WriteLine();
			Console.WriteLine("Выбирите какие массивы использовать:) \n 1.Одномерный; \n 2.Двумерный;");
			do
			{
				num = int.Parse(Console.ReadLine());
				num_two = int.Parse(Console.ReadLine());
				if ((num > 2 && num < 1) || (num_two > 2 && num_two < 1))
				{
					Console.WriteLine("Так нельзя!");
				}
				if(num != num_two)
                {
					Console.WriteLine("Так нельзя! Числа должны быть одинаковыми.");
                }
			}
			while (((num > 2) && (num < 1) || (num_two > 2 && num_two < 1)) && (num != num_two));
			Console.WriteLine("Процентное соотношение совпадающих элементов массивов к подмасиву:");
			Console.WriteLine(procent(num, num_two));
		}
	}
}
