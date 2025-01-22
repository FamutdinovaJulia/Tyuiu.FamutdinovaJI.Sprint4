using Tyuiu.FamutdinovaJI.Sprint4.Task6.V15.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint4.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var str = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

            Console.WriteLine("* Исходный массив: ");
            for (int i = 0; i <= str.Length - 1; i++)
            {
                Console.WriteLine(str[i]);
            }

            int res = ds.Calculate(str);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество элементов, длина которых < 7 = " + res);

            Console.ReadLine();
        }
    }
}
