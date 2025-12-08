using Tyuiu.MinullinDF.Sprint6.Task2.V3.Lib;
namespace Tyuiu.MinullinDF.Sprint6.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var result = ds.GetMassFunction(-5, 5);
            double[] wait = [-12.18,16.03,18.87,4.96,-9.99,-2,2.16,-7.54,-22.76,-20.45,7.77];
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            CollectionAssert.AreEqual(wait, result);
        }
    }
}
