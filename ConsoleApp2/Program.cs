using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2, b = 3;
            for(double c = 0; c <= 10; c++)
            {
                libGPT.GPTB2 g = new libGPT.GPTB2(a, b, c);
                Console.WriteLine($"ptb2 a={a} b={b} c={c} -> kq: {g.Giai()}");
            }
            Console.ReadKey(true);
        }
    }
}
