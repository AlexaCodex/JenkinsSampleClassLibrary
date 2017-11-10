using JenkinsSampleClassLibrary;
using NUnit.Framework;

namespace JenkinsSampleClassLibraryTests
{
    [TestFixture]
    public class ProgamTest
    {
        [Test]
        public void MainTest_ConvertAndReturnString()
        {
            var program = new Program();

            var result = program.Main("false");

            Assert.AreEqual(false, result);
        }
    }
}
