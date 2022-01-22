using System;

namespace Lab_11_Структуры
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation MyEquation;

            Console.WriteLine("Введите коэффициенты линейного уравнения вида 0 = kX + b:");
            Console.WriteLine("Введите коэффициент k:");
            MyEquation.k = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b:");
            MyEquation.b = Convert.ToSingle(Console.ReadLine());
            MyEquation.Root();
            
        }

        public struct LinearEquation
        {
            public float k;
            public float b;

            public void Root()
            {
                Console.WriteLine("Корень уравнения: {0}", -b/k);
            }
        }
    }
}
