using System;
using System.Collections.Generic;
using System.Text;

namespace libGPT
{
    public enum LoaiKQ
    {
        KO_PHAI_PTB2,
        VO_NGHIEM,
        NGHIEM_KEP,
        HAI_NGHIEM
    }
    public class GPTB2
    {
        double a, b, c;
        public LoaiKQ loaiKQ;
        public double x1, x2;
        public GPTB2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string Giai()
        {
            if (a == 0)
            {
                loaiKQ = LoaiKQ.KO_PHAI_PTB2;
                return "ko phai ptb2";
            }
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                loaiKQ = LoaiKQ.VO_NGHIEM;
                return "ptb2 ko co nghiem thuc";
            }
            else if (delta == 0)
            {
                loaiKQ = LoaiKQ.NGHIEM_KEP;
                x1 = x2 = -b / 2 / a;
                return $"ptb2 co nghiem kep x1=x2={x1}";
            }
            else
            {
                loaiKQ = LoaiKQ.HAI_NGHIEM;
                x1 = (-b - Math.Sqrt(delta)) / 2 / a;
                x2 = (-b + Math.Sqrt(delta)) / 2 / a;
                return $"ptb2 co 2 nghiem thuc x1={x1} x2={x2}";
            }
        }
    }
}
