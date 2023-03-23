using System;
using System.Collections.Generic;
using System.Text;

namespace gptb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 3) {
                double a = double.Parse(args[0]);
                double b = double.Parse(args[1]);
                double c = double.Parse(args[2]);

                libGPT.GPTB2 gptb2 = new libGPT.GPTB2(a, b, c);
                string kq = gptb2.Giai();  //gọi 1 method Giai để thu đc kq

                //in ra màn hình
                Console.WriteLine(kq);


                Console.ReadKey(true);
            }
        }
    }
}
