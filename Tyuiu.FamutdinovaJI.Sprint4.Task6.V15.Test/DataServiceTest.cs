using Tyuiu.FamutdinovaJI.Sprint4.Task6.V15.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint4.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var str = new string[] { "������", "�������", "������", "�����������", "���-�������", "���-�����", "������" };

            int res = ds.Calculate(str);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}