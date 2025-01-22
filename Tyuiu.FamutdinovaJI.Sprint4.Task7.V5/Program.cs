using Tyuiu.FamutdinovaJI.Sprint4.Task7.V5.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint4.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];

            string str = "246813579";

            int index = 0;
            Console.WriteLine("* \nMассив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            int res = ds.Calculate(n, m, str);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество четных чисел = " + res);

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
