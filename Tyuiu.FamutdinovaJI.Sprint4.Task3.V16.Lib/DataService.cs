using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FamutdinovaJI.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array)
        {

            int min = 15;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j < 5; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }

                }

            }
            return min;
        }
    }
}
