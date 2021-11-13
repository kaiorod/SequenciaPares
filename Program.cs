using System;
using System.Threading;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p = 0;

            Console.Beep();
            Console.Clear();
            Console.Write("Numeros pares de 0 até : ");
            n = int.Parse(Console.ReadLine());

            while(p < n)
            {
                Thread.Sleep(50);
                Console.Write($" {p}");
                p = p + 2;
            }
        }
    }
}
