using Tyuiu.MinullinDF.Sprint6.Task7.V1.Lib;
namespace Tyuiu.MinullinDF.Sprint6.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\TYUIU\Tyuiu.MinullinDF.Sprint6\Tyuiu.MinullinDF.Sprint6.Task5.V12\bin\Debug\InPutDataFileTask6V29.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
