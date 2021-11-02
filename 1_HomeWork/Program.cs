using System;

namespace frog
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x1, y1;
            if (N > M)
            {
                x1 = M - x;
                y1 = N - y;
                int res1 = Math.Min(x, y);
                int res2 = Math.Min(x1, y1);
                Console.WriteLine(Math.Min(res1, res2));
            }
            if (N < M)
            {
                x1 = N - x;
                y1 = M - y;
                int res1 = Math.Min(x, y);
                int res2 = Math.Min(x1, y1);
                Console.WriteLine(Math.Min(res1, res2));
            }
            if (N == M)
            {
                x1 = N - x;
                y1 = M - y;
                int res1 = Math.Min(x, y);
                int res2 = Math.Min(x1, y1);
                Console.WriteLine(Math.Min(res1, res2));
            }
        }
    }
}
