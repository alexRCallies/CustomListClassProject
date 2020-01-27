using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ToStringMethodTests
    {
        [TestMethod]
        public void CustomToStringMethodChangingIndex0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            string expected = "1";
            string actual;
            //Act
            customList.CustomAdd(firstValue);

            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomToStringMethodChangingIndexAfter0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 2;
            int secondValue = 21;
            string expeceted = "221";
            string actual;
            //Act
            customList.CustomAdd(firstValue);
            customList.CustomAdd(secondValue);
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expeceted, actual);
        }
        [TestMethod]
        public void CustomStringMethodStartingStringEndingConjoinedStrings()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string firstValues = "12";
            string secondValue = "Washongton";
            string thirdValue = "42cUps";
           
            string expected = "12Washongton42cUps";
            string actual;
            //Act
            customList.CustomAdd(firstValues);
            customList.CustomAdd(secondValue);
            customList.CustomAdd(thirdValue);
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
