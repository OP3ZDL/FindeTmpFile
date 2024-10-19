using ClassLibrary1;
namespace TMPFile
{
    [TestClass]
    public class TTmpFile
    {
        [TestMethod]
        public void TestConstruct()
        {

            TmpFile tmpFile = new TmpFile("Временной.tmp", "C:/TempF/");

            TmpFile tmpFile2 = new TmpFile("Временно.tmp", "C:/UI/");

            TmpFile tmpFile3 = new TmpFile("Временн.tmp", "C:/YY/");


            bool R = tmpFile.CreateF();
            Assert.AreEqual(true, R);

            bool Q = tmpFile2.CreateF();
            Assert.AreEqual(true, Q);

            bool W = tmpFile3.CreateF();
            Assert.AreEqual(true, W);

            Assert.AreEqual("C:/TempF/", tmpFile.Path);
            Assert.AreEqual("Временной.tmp", tmpFile.Name);


        }

        

    }
}