using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static int Fib(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        static void Main(string[] args)
        {
            Console.Write("یک عدد وارد کنید: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("سری فیبوناچی تا عدد {0} :", n);

            for (int i = 1; i <= n; i++)
            {
                Console.Write(Fib(i) + " ");
            }

            Console.ReadKey();
        }

    }
}
