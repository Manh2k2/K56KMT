using System;
using System.Collections.Generic;
using System.Text;

namespace libGPT
{
    public class GPTB1
    {
        private double a, b;
        public GPTB1(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public String giai()
        {
            if (a == 0 && b == 0)
            {
                return ("pt co vo so nghiem");
            }
            else
            {
                if (a == 0)
                {
                    return ("PT vo nghiem");
                }
                else
                {
                    //double x = -b / a;
                    return ($"PT co 1 nghiem thuc: {-b / a}");
                }
            }
        }

    }
}
