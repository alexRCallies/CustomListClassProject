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

            actual = customList.CustomString(0);
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
            string expeceted = "21";
            string actual;
            //Act
            customList.CustomAdd(firstValue);
            customList.CustomAdd(secondValue);
            actual = customList.CustomString(1);
            //Assert
            Assert.AreEqual(expeceted, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void CustomStringMethodCheckingOutOfBoundsIndex()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 32;
            int SecondValue = 4;
            int thirdValue = 3;

            //Act
            customList.CustomAdd(firstValue);
            customList.CustomAdd(SecondValue);
            customList.CustomAdd(thirdValue);
            customList.CustomString(5);
        }
    }
}
