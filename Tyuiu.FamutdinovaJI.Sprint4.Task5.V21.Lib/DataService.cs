using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.FamutdinovaJI.Sprint4.Task5.V21.Lib
{
    public class DataService : ISprint4Task5V21
    {
        public int[,] Calculate(int[,] matrix)
        {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }

                }

            }
            return matrix;
        }
    }
}
