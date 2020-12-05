using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumValueUsingGenerics;

namespace FindMaximumValueTest
{
    [TestClass]
    public class UnitTest1
    {
        FindMaximumValue maximumValue = new FindMaximumValue();

        [TestMethod]
        public void givenThreeIntegers_WhenFirstPositionIsMax_ShouldReturnSameNumber()
        {
            int maxvalue = maximumValue.MaximumNumber(5, 3, 2);
            Assert.AreEqual(5, maxvalue);
        }
        [TestMethod]
        public void givenThreeIntegers_WhenSecondPositionIsMax_ShouldReturnSameNumber()
        {
            int maxvalue = maximumValue.MaximumNumber(3, 5, 2);
            Assert.AreEqual(5, maxvalue);
        }
        [TestMethod]
        public void givenThreeIntegers_WhenThirdPositionIsMax_ShouldReturnSameNumber()
        {
            int maxvalue = maximumValue.MaximumNumber(3, 2, 5);
            Assert.AreEqual(5, maxvalue);
        }
        [TestMethod]
        public void givenThreeFloats_WhenFirstPositionIsMax_ShouldReturnSameNumber()
        {
            double maxvalue = maximumValue.MaximumNumberFloat(5.3, 3.2, 2.1);
            Assert.AreEqual(5.3, maxvalue);
        }
        [TestMethod]
        public void givenThreeFloats_WhenSecondPositionIsMax_ShouldReturnSameNumber()
        {
            double maxvalue = maximumValue.MaximumNumberFloat(3.2, 5.3, 2.1);
            Assert.AreEqual(5.3, maxvalue);
        }
        [TestMethod]
        public void givenThreeFloats_WhenThirdPositionIsMax_ShouldReturnSameNumber()
        {
            double maxvalue = maximumValue.MaximumNumberFloat(3.2, 2.1, 5.3);
            Assert.AreEqual(5.3, maxvalue);
        }
    }
}
