using System;

namespace Methods
{
    class Program
    {
        public static int Sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;

        }

        public static void Cem(int n)
        {
            int cem = 0;
            for (int a = 1; a <= n; a++)
            {
                if (a % 2 == 0)
                {
                    cem += a;
                }
            }
            Console.WriteLine(cem);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(26));

            //Cem(29);




            Console.Write("n ededini daxil edin: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 7 == 0)
            {
                Console.WriteLine($"{n} 7-ye bolunur");

            }
            else

            {
                int remainder = n % 7;
                if (remainder > 3)
                {
                    while (n % 7 != 0)
                    {
                        n++;
                    }
                }
                else
                {
                    while (n % 7 != 0)
                    {
                        n--;
                    }
                }
                Console.WriteLine(n);
            }

        }
    }
}
