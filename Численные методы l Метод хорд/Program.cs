namespace Численные_методы_l_Метод_хорд
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double beg, end;

                Console.WriteLine("Введите начало промежутка: ");
                beg = IsNumber(Console.ReadLine());

                Console.WriteLine("Введите конец промежутка: ");
                end = IsNumber(Console.ReadLine());

                if (beg > end)
                {
                    Console.WriteLine("Начал промежутка не может быть больше, чем его конец!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Уравнение: x^3-cos(x); Точность: 0,0001");

                Calculations(beg, end);

                Console.ReadLine();
            }
        }

        static double IsNumber(string str)
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

        static void Calculations(double beg, double end, double accuracy = 0.0001, double x = 0)
        {
            double fa, fb, fx, abs, c;

            c = x;

            fa = Math.Pow(3,beg) - Math.Cos(beg);
            fb = Math.Pow(3,end) - Math.Cos(end);

            x = beg - (end - beg) * fa/(fb - fa);
            fx = Math.Pow(3, x) - Math.Cos(x);

            //Сделано по блок-схеме из pril5
            Console.Write($"F(A): {fa}   F(B): {fb}   X: {x}    F(X) {fx}");
            if (fx * fa < 0)
            {
                end = x;
            }
            else
            {
                beg = x;
            }

            if (Math.Abs(x - c) < accuracy)
            {
                Console.WriteLine($"X: {x}");
            }
            else
            {
                Calculations(beg, end, accuracy, x);
            }
        }
    }
}