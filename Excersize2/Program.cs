using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize2
{
    internal class Program
    {
        void CheckPrImeOrNot()
        {
            Console.WriteLine("Enter Number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int Count = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Count++;
                }
            }
            if (n > 1 && Count == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("NOt Prime Number");
            }
        }
        void PrintSeries()
        {
            for (int i = 1; i <= 19; i += 2)
            {
                Console.Write(i + "/" + (i + 1));

                if (i < 19)
                    Console.Write(" + ");
            }
        }
        void FabinacciSeries()
        {
            int a = 1, b = 2, c;

            Console.Write(a + " " + b + " ");

            for (int i = 3; i <= 10; i++)
            {
                c = a + b;
                Console.Write(c + " ");

                a = b;
                b = c;
            }
        }
        void CountDigit()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            n = Math.Abs(n);

            while (n > 0)
            {
                count++;
                n = n / 10;
            }

            Console.WriteLine("Digit Count = " + count);
        }
        void ReverseNumber()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int rem, rev = 0;

            while (n > 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }

            Console.WriteLine("Reverse = " + rev);
        }
        static void Main(string[] args)
        {
            Program e2 = new Program();
            //e2.CheckPrImeOrNot();
            //e2.PrintSeries();
            //e2.FabinacciSeries();
            //e2.CountDigit();
            e2.ReverseNumber();
        }
    }
}
