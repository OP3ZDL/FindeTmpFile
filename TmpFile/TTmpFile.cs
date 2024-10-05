using ClassLibrary1;
namespace TMPFile
{
    [TestClass]
    public class TTmpFile
    {
        [TestMethod]
        public void TestConstruct()
        {
            TmpFile tmpFile = new TmpFile("Временной", "D/:");
            Console.WriteLine(tmpFile);

            Assert.AreEqual("D/:", tmpFile.Path);
            Assert.AreEqual("Временной", tmpFile.Name);
        }
    }
}