using Tyuiu.MinullinDF.Sprint6.Task3.V2.Lib;
namespace Tyuiu.MinullinDF.Sprint6.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = { {-12, -4, -20, 5, -5 },
                              { 2, 15, 1, -20, 7 },
                              { 15, -15, 2, 11, 5 },
                              { -19, -9, 16, 0, 1 },
                              { 17, 16, 5, 12, -8 }};


            var result = ds.Calculate(matrix);
            int[,] wait = { { 0, 0, 0, 5, -5 },
                            { 2, 15, 1, -20, 7 },
                            { 15, -15, 2, 11, 5 },
                            { -19, -9, 16, 0, 1 },
                            { 17, 16, 5, 12, -8 }};

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
