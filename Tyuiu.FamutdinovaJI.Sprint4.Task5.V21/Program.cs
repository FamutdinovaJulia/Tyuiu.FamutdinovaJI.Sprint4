using Tyuiu.FamutdinovaJI.Sprint4.Task5.V21.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint4.Task5.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random rnd = new Random();
            int[,] mtrx = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mtrx[i, j] = rnd.Next(-8,3);
                }
            }

            Console.WriteLine("* \nИсходный массив: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            int[,] res = ds.Calculate(mtrx);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Новый массив = ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"{res[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
