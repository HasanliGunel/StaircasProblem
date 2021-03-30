using System;

namespace Tapshiriq_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0 & n <= 100)
            {
                for (int i = 1; i <= n; i++)
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("#");
                        if (i == j)
                            Console.Write('\n');
                    }

            }
            else
                Console.WriteLine("n 0 < n <= 100 araliginda olmalidir.");
                
        }
    }
}
