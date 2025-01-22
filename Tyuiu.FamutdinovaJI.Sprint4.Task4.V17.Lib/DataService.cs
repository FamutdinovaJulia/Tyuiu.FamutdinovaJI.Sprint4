using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FamutdinovaJI.Sprint4.Task4.V17.Lib
{
    public class DataService : ISprint4Task4V17
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] % 2 ==0)
                    {
                        sum += matrix[i, j];
                    }

                }

            }
            return sum;
        }
    }
}
