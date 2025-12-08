using Tyuiu.MinullinDF.Sprint6.Task0.V25.Lib;
namespace Tyuiu.MinullinDF.Sprint6.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var result = ds.Calculate(2);
            double wait = 0.816;
            Assert.AreEqual(wait, result);
        }
    }
}
