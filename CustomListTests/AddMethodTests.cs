using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
namespace CustomListTests
{
    [TestClass]
    public class CustomListTests
    {
        [TestMethod]
        public void CustomListAddMethodCheckIndex0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 3;
            int actual;
            //Act
            customList.CustomAdd(expected);
            actual = customList[0];
            //Assert
            Assert.AreEqual(expected, customList[0]);
        }
        [TestMethod]
        public void CustomListAddMethodCheckIndexAfter0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;
            int expected = 4;
            int actual;
            //Act
            customList.CustomAdd(value);
            customList.CustomAdd(expected);
            actual = customList[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomListAddMethodCheckIndex0AfterMultipleAdds()
        {
            //Arramge
            CustomList<int> customList = new CustomList<int>();
            int expected = 2;
            int secondValue = 4;
            int actual;
            //Act
            customList.CustomAdd(expected);
            customList.CustomAdd(secondValue);
            actual = customList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomListCheckCountAfterAdd()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;
            int expected = 1;
            int actual;
            //Act
            customList.CustomAdd(value);
            actual = customList.Count;
           //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomListCheckCountAfterMultipleAdd()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;
            int secondValue = 4;
            int expected = 2;
            int actual;
            //Act
            customList.CustomAdd(value);
            customList.CustomAdd(secondValue);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomListMakeSureCapacityIncreasedAfterMaxCapacity()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;
            int secondValue = 5;
            int thirdValue = 6;
            int fourthValue = 1;
            int fifthValue = 10;
            int sixthValue = 43;
            int seventhValue = 100;
            int expected = 8;
            int actual;
            //Act
            customList.CustomAdd(value);
            customList.CustomAdd(secondValue);
            customList.CustomAdd(thirdValue);
            customList.CustomAdd(fourthValue);
            customList.CustomAdd(fifthValue);
            customList.CustomAdd(sixthValue);
            customList.CustomAdd(seventhValue);
            actual = customList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomListAddMethodCheckIndexAfterCapacityIncrease()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;
            int secondValue = 6;
            int thirdValue = 4;
            int fourthValue = 5;
            int fifthValue = 7;
            int expected = 1;
            int actual;
            //Act
            customList.CustomAdd(value);
            customList.CustomAdd(secondValue);
            customList.CustomAdd(thirdValue);
            customList.CustomAdd(fourthValue);
            customList.CustomAdd(fifthValue);
            customList.CustomAdd(expected);
            actual = customList[5];
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
