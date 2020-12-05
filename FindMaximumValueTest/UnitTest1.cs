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
            int maxvalue = FindMaximumValue.MaximumNumber(5, 3, 2);
            Assert.AreEqual(5, maxvalue);
        }
        [TestMethod]
        public void givenThreeIntegers_WhenSecondPositionIsMax_ShouldReturnSameNumber()
        {
            int maxvalue = FindMaximumValue.MaximumNumber(3, 5, 2);
            Assert.AreEqual(5, maxvalue);
        }
        [TestMethod]
        public void givenThreeIntegers_WhenThirdPositionIsMax_ShouldReturnSameNumber()
        {
            int maxvalue = FindMaximumValue.MaximumNumber(3, 2, 5);
            Assert.AreEqual(5, maxvalue);
        }
    }
}
