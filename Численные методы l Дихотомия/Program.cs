namespace Численные_методы_l_Дихотомия
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int accuracy, startGapA, endGapB;

                Console.WriteLine("\t\t\tМетод дихотомии:");
                Console.WriteLine("Пример: 2^x - 5*x - 3");
                Console.WriteLine("Введите точность: ");
                accuracy = IsNumber(Console.ReadLine());

                Console.WriteLine("Введите начало промежутка (a): ");
                startGapA = IsNumber(Console.ReadLine());

                Console.WriteLine("Введите конец промежутка (b): ");
                endGapB = IsNumber(Console.ReadLine());

                int intX = IsX(startGapA, endGapB);
                FX(intX);
                FA(startGapA);

                Console.ReadLine();
            }
        }

        static int IsNumber(string str)
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

        static int IsX(int a, int b)
        {
            int result = (a + b) / 2;
            Console.Write($"X: {result}\t");
            return result;
        }

        static int FA(int a)
        {
            int result = 2^a - 5 * a - 3;
            Console.Write($"F(a): {result}\t");
            return result;
        }

        static int FX(int x)
        {
            int result = 2 ^ x - 5 * x - 3;
            Console.Write($"F(x): {result}\t");
            return result;
        }

        static int FAxFX(int fa, int fx)
        {
            int result = fa * fx;
            Console.Write($"{result}\t");
            return result;
        }
        
        static void AccuracyCheck(int accuracy, int input)
        {
            if (input <= accuracy)
            {
                Console.WriteLine("Выполнено!");
            }
            else
            {
                Console.WriteLine("---------");
            }
        }
    }
}