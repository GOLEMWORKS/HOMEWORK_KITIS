namespace Численные_методы_l_Вычисление_по_формуле_Симпсона
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tРешение интеграла по формуле Симпсона");
            Console.WriteLine("\nПример: dx/(1+x^2) | h = 0,25; a = 0; b = 2");

            Integral(0.25);
        }

        static void Integral(double h, int count = 0, double res = 0, double x = 0)
        {
            double y;
            int pos;

            count++;

            y = 0;

            if (count % 2 == 0)
            {
                pos = 4;
            }
            else if (count % 3 == 0)
            {
                pos = 2;
            }
            else
            {
                pos = 1;
            }

            if (x < 1)
            {
                y = pos / 1 + Math.Pow(x, 2);
                x += h;   
            }
            else
            {
                res = res * h/ 3;
                Console.WriteLine(res);
                return;
            }

            res += y;

            Integral(h, count, res, x);
        }
    }
}