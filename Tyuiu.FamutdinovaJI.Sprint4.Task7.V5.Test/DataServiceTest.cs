using Tyuiu.FamutdinovaJI.Sprint4.Task7.V5.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint4.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;

            int[,] mtrx = new int[n, m];
            string str = "246813579";

            int res = ds.Calculate(n, m, str);
            int wait = 4;
            
            Assert.AreEqual(wait, res);
        }
    }
}