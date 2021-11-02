using System;

namespace thirdthird
{
    class Third
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x1, y1;
            if(N > M)
            {
                x1 = M - x;
                y1 = N - y;
                if((x < y) && (x < x1) && (x < y1))
                {
                    Console.WriteLine(x);
                }
                if ((x1 < y) && (x1 < x) && (x1 < y1))
                {
                    Console.WriteLine(x1);
                }
                if ((y1 < y) && (y1 < x1) && (y1 < x))
                {
                    Console.WriteLine(y1);
                }
                if ((y < x) && (y < x1) && (y < y1))
                {
                    Console.WriteLine(x);
                }
            }
            if (N < M)
            {
                x1 = N - x;
                y1 = M - y;
                if ((x < y) && (x < x1) && (x < y1))
                {
                    Console.WriteLine(x);
                }
                if ((x1 < y) && (x1 < x) && (x1 < y1))
                {
                    Console.WriteLine(x1);
                }
                if ((y1 < y) && (y1 < x1) && (y1 < x))
                {
                    Console.WriteLine(y1);
                }
                if ((y < x) && (y < x1) && (y < y1))
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
