using Tyuiu.MinullinDF.Sprint6.Task4.V28.Lib;
using System.Text;
using System.Globalization;
namespace Tyuiu.MinullinDF.Sprint6.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var result = ds.GetMassFunction(-5, 5);
            double[] wait = [-11.22, -8.65, -4.76, -6.47, -2.98, 1, 1.82, 3.55, 6.99, 7.74, 9.03];
            CollectionAssert.AreEqual(wait, result);
        }
    }
}
