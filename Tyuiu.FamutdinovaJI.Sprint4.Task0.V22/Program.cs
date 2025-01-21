using Tyuiu.FamutdinovaJI.Sprint4.Task0.V22.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint4.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            
            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            Console.WriteLine("* Исходный массив:                                                        *");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            int res = ds.GetSumOddArrEl(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма нечетных элементов массива = " + res);

            Console.ReadLine();
        }
    }
}
