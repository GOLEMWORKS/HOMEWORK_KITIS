namespace Численные_методы_l_Дихотомия
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double startGapA, endGapB, accuracy;

                Console.WriteLine("\t\t\tМетод дихотомии:");
                Console.WriteLine("Пример: 2^x - 5*x - 3");
                Console.WriteLine("Введите точность: ");
                accuracy = AccuracyChecker(Console.ReadLine());//!cвой метод!!!

                Console.WriteLine("Введите начало промежутка (a): ");
                startGapA = AccuracyChecker(Console.ReadLine());

                Console.WriteLine("Введите конец промежутка (b): ");
                endGapB = IsNumber(Console.ReadLine());

                Calculations(accuracy, startGapA, endGapB, (startGapA + endGapB) / 2);

                Console.ReadLine();
            }
        }

        static double AccuracyChecker(string str)
        {
            if (double.TryParse(str, out double result))
            {
                return result;
            }
            else
            {
                return 1;
            }
        }
        static int IsNumber(string str)//!
        {
            if (int.TryParse(str, out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

        static void Calculations(double accuracy, double startGapA, double endGapB, double x)
        {
            double fa, fx, fa_x_fx;

            fa = Math.Pow(2, startGapA) - 5 * startGapA - 3;
            fx = Math.Pow(2, x) - 5 * x - 3;

            fa_x_fx = fa * fx;

            Console.Write($"F(a): {fa}\tF(x): {fx}\tF(a)*F(x): {fa_x_fx}");

            if (Math.Abs(fx) < accuracy) //!
            {
                Console.WriteLine("\tРезультат получен!");
                return;
            }
            else
            {
                Console.WriteLine("\t----------");
            }

            if(fa_x_fx < 0)
            {
                endGapB = startGapA;
            }

            if(fa_x_fx > 0)
            {
                startGapA = x;
            }
            
            Calculations(accuracy, startGapA, endGapB, x);
        }
    }
}