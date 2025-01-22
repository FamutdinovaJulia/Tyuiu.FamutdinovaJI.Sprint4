using Tyuiu.FamutdinovaJI.Sprint4.Task5.V21.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[5, 5]{ { -3, 2, -7, -1, 0},
                                         { -5, -6, 1, 0, -2},
                                         { -5, 2, -3, -4, -6},
                                         { -5, 2, -7, 1, -5},
                                         { -6, -3, 1, -7, -7} };

            int [,] res = ds.Calculate(mtrx);
            int [,] wait = new int [5, 5]{ { -3, 1, -7, -1, 0},
                                           { -5, -6, 1, 0, -2},
                                           { -5, 1, -3, -4, -6},
                                           { -5, 1, -7, 1, -5},
                                           { -6, -3, 1, -7, -7} };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}