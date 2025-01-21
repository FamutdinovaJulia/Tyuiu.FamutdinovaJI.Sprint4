using Tyuiu.FamutdinovaJI.Sprint4.Task2.V6.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint4.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 6, 6, 3, 6, 9, 3, 8, 2, 7, 5, 7, 4, 5, 7, 4 };

            int res = ds.Calculate(numsArray);
            int wait = 694575;

            Assert.AreEqual(wait, res);
        }
    }
}