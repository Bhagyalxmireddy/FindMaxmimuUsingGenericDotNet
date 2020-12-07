using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            int[] intArray = { 5, 3, 2 };
            FindMaximumValue.Genericmaximum<int> maxvalue = new FindMaximumValue.Genericmaximum<int>(intArray);
            int result = maxvalue.maximumMethod();
            Assert.AreEqual(5, result);
        }
       [TestMethod]
        public void givenThreeIntegers_WhenSecondPositionIsMax_ShouldReturnSameNumber()
        {
            int[] intArray = { 3, 5, 4 };
            FindMaximumValue.Genericmaximum<int> maxvalue = new FindMaximumValue.Genericmaximum<int>(intArray);
            int result = maxvalue.maximumMethod();
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void givenThreeIntegers_WhenThirdPositionIsMax_ShouldReturnSameNumber()
        {
            int[] intArray = { 3, 4, 5 };
            FindMaximumValue.Genericmaximum<int> maxvalue = new FindMaximumValue.Genericmaximum<int>(intArray);
            int result = maxvalue.maximumMethod();
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void givenThreeFloats_WhenFirstPositionIsMax_ShouldReturnSameNumber()
        {
            float[] floatArray = { 5.3f, 3.9f, 2.4f };
            FindMaximumValue.Genericmaximum<float> maxvalue = new FindMaximumValue.Genericmaximum<float>(floatArray);
            float result = maxvalue.maximumMethod();
            Assert.AreEqual(5.3f, result);
        }
       [TestMethod]
        public void givenThreeFloats_WhenSecondPositionIsMax_ShouldReturnSameNumber()
        {
            float[] floatArray = { 3.9f, 5.5f, 2.4f };
            FindMaximumValue.Genericmaximum<float> maxvalue = new FindMaximumValue.Genericmaximum<float>(floatArray);
            float result = maxvalue.maximumMethod();
            Assert.AreEqual(5.5, result);
        }
        [TestMethod]
        public void givenThreeFloats_WhenThirdPositionIsMax_ShouldReturnSameNumber()
        {
            float[] floatArray = { 3.9f, 2.4f, 5.3f };
            FindMaximumValue.Genericmaximum<float> maxvalue = new FindMaximumValue.Genericmaximum<float>(floatArray);
            float result = maxvalue.maximumMethod();
            Assert.AreEqual(5.3f, result);
        }
        [TestMethod]
        public void givenThreeStrings_WhenFirstPositionIsMax_ShouldReturnSameNumber()
        {
            string[] stringArray = { "Peach", "Apple", "Banana" };
            FindMaximumValue.Genericmaximum<string> maxvalue = new FindMaximumValue.Genericmaximum<string>(stringArray);
            string result = maxvalue.maximumMethod();
            Assert.AreEqual("Peach", result);
        }
        [TestMethod]
        public void givenThreeStrings_WhenSecondPositionIsMax_ShouldReturnSameNumber()
        {
            string[] stringArray = {  "Apple", "Peach", "Banana" };
            FindMaximumValue.Genericmaximum<string> maxvalue = new FindMaximumValue.Genericmaximum<string>(stringArray);
            string result = maxvalue.maximumMethod();
            Assert.AreEqual("Peach", result);
        }
        [TestMethod]
        public void givenThreeStrings_WhenThirdPositionIsMax_ShouldReturnSameNumber()
        {
            string[] stringArray = { "Apple", "Banana", "Peach"};
            FindMaximumValue.Genericmaximum<string> maxvalue = new FindMaximumValue.Genericmaximum<string>(stringArray);
            string result = maxvalue.maximumMethod();
            Assert.AreEqual("Peach", result);
        }
        [TestMethod]
        public void givenMoreThanIntegers_ShouldReturn_MaximumNumber()
        {
            int[] intArray = { 5, 3, 2,6,9 };
            FindMaximumValue.Genericmaximum<int> maxvalue = new FindMaximumValue.Genericmaximum<int>(intArray);
            int result = maxvalue.maximumMethod();
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void givenMoreThanFloat_ShouldReturn_MaximumValue()
        {
            float[] floatArray = { 3.9f, 2.4f, 5.3f,6.9f,2.5f };
            FindMaximumValue.Genericmaximum<float> maxvalue = new FindMaximumValue.Genericmaximum<float>(floatArray);
            float result = maxvalue.maximumMethod();
            Assert.AreEqual(6.9f, result);
        }
        [TestMethod]
        public void givenMoreThanString_ShouldReturn_MaximumValue()
        {
            string[] stringArray = { "Apple", "Peach", "Banana","Orange" };
            FindMaximumValue.Genericmaximum<string> maxvalue = new FindMaximumValue.Genericmaximum<string>(stringArray);
            string result = maxvalue.maximumMethod();
            Assert.AreEqual("Peach", result);
        }
    }
}
