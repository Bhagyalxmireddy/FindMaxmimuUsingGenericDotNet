using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumValueUsingGenerics;
using FindMaximumValueUsingGenerics;

namespace FindMaximumValueTest
{
    [TestClass]
    public class UnitTest1
    {
       // FindMaximumValue maximumValue = new FindMaximumValue();

        [TestMethod]
        public void givenThreeIntegers_WhenFirstPositionIsMax_ShouldReturnSameNumber()
        {
            int maxvalue = new FindMaximumValue.GenericMaximu<int>(5, 3, 2).maximumMethod();
            Assert.AreEqual(5, maxvalue);
        }
        [TestMethod]
        public void givenThreeIntegers_WhenSecondPositionIsMax_ShouldReturnSameNumber()
        {
            int maxvalue = new FindMaximumValue.GenericMaximu<int>(3, 5, 2).maximumMethod();
            Assert.AreEqual(5, maxvalue);
        }
        [TestMethod]
        public void givenThreeIntegers_WhenThirdPositionIsMax_ShouldReturnSameNumber()
        {
            int maxvalue = new FindMaximumValue.GenericMaximu<int>(2, 3, 5).maximumMethod();
            Assert.AreEqual(5, maxvalue);
        }
        [TestMethod]
        public void givenThreeFloats_WhenFirstPositionIsMax_ShouldReturnSameNumber()
        {
            float maxvalue = new FindMaximumValue.GenericMaximu<float>(5.3f, 3.9f, 2.4f).maximumMethod();
            Assert.AreEqual(5.3f, maxvalue);
        }
        [TestMethod]
        public void givenThreeFloats_WhenSecondPositionIsMax_ShouldReturnSameNumber()
        {
            float maxvalue = new FindMaximumValue.GenericMaximu<float>(3.9f,5.3f, 2.4f).maximumMethod();
            Assert.AreEqual(5.3f, maxvalue);
        }
        [TestMethod]
        public void givenThreeFloats_WhenThirdPositionIsMax_ShouldReturnSameNumber()
        {
            float maxvalue = new FindMaximumValue.GenericMaximu<float>(2.4f, 3.9f, 5.3f).maximumMethod();
            Assert.AreEqual(5.3f, maxvalue);
        }
        [TestMethod]
        public void givenThreeStrings_WhenFirstPositionIsMax_ShouldReturnSameNumber()
        {
            string maxvalue = new FindMaximumValue.GenericMaximu<string>("Peach", "Apple", "Banana").maximumMethod();
            Assert.AreEqual("Peach", maxvalue);
        }
        [TestMethod]
        public void givenThreeStrings_WhenSecondPositionIsMax_ShouldReturnSameNumber()
        {
            string maxvalue = new FindMaximumValue.GenericMaximu<string>("Apple","Peach", "Banana").maximumMethod();
            Assert.AreEqual("Peach", maxvalue);
        }
        [TestMethod]
        public void givenThreeStrings_WhenThirdPositionIsMax_ShouldReturnSameNumber()
        {
            string maxvalue = new FindMaximumValue.GenericMaximu<string>("Apple", "Banana", "Peach").maximumMethod();
            Assert.AreEqual("Peach", maxvalue);
        }
    }
}
