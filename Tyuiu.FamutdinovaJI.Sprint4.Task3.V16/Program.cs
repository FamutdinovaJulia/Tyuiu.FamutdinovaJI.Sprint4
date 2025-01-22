using Tyuiu.FamutdinovaJI.Sprint4.Task3.V16.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint4.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mtrx = new int[5, 5]{ { 5, 8, 5, 8, 4},
                                         { 2, 3, 4, 6, 3},
                                         { 1, 1, 2, 9, 9},
                                         { 6, 7, 4, 1, 2},
                                         { 5, 7, 1, 8, 7} };

            Console.WriteLine("* Исходный массив:                                                        *");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j < 5; j++)
                {
                    Console.Write($"{mtrx[i,j]} \t");
                }
                Console.WriteLine();
            }

            int res = ds.Calculate(mtrx);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Минимальный элемент в последнем столбце массива = " + res);

            Console.ReadLine();
        }
    }
}
