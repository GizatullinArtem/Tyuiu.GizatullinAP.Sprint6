using Tyuiu.GizatullinAP.Sprint6.Task6.V29.Lib;
namespace Tyuiu.GizatullinAP.Sprint6.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask6V29.txt";
            var res = ds.CollectTextFromFile(path);
            string wait = "gMxrJi rvzAEwiXzIsLRa xakZKciG";
            Assert.AreEqual(wait, res);
        }
    }
}