using Tyuiu.GizatullinAP.Sprint6.Task5.V24.Lib;
namespace Tyuiu.GizatullinAP.Sprint6.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V24.txt";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);

        }
    }
}