using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class RemoveMethodTest
    {
        [TestMethod]

        public void CustomListRemoveMethodRemovingIndex0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 4;
            int expected = 3;
            int actual;
            //Act
            customList.CustomAdd(value);
            customList.CustomAdd(expected);
            customList.CustomRemove(value);
            actual = customList.customLists[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomListRemoveMethodRemovingIndexAfter0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 4;
            int secondValue = 3;
            int actual;
            //Act
            customList.CustomAdd(expected);
            customList.CustomAdd(secondValue);
            customList.CustomRemove(secondValue);
            actual = customList.customLists[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomListRemoveMethodRemovingMiddleIndexCheckingIndexsAfter()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 3;
            int secondValue = 2;
            int expected = 5;
            int actual;
            //Act
            customList.CustomAdd(firstValue);
            customList.CustomAdd(secondValue);
            customList.CustomAdd(expected);
            customList.CustomRemove(secondValue);
            actual = customList.customLists[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomListRemoveMethodRemovingAValueWithTheListContainingMultipleOfThatValue()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;
            int secondValue = 4;
            int expected = value;
            int actual;
            //Act
            customList.CustomAdd(value);
            customList.CustomAdd(secondValue);
            customList.CustomAdd(value);
            customList.CustomRemove(value);
            actual = customList.customLists[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomListRemoveMethodCheckCountAfterRemovingIndexAfter0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 4;
            int secondValue = 3;
            int expected = 1;
            int actual;
            //Act
            customList.CustomAdd(firstValue);
            customList.CustomAdd(secondValue);
            customList.CustomRemove(secondValue);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomListRemoveMethodCheckCountAfterRemovingIndex0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 4;
            int secondValue = 3;
            int expected = 1;
            int actual;
            //Act
            customList.CustomAdd(firstValue);
            customList.CustomAdd(secondValue);
            customList.CustomRemove(firstValue);
            actual = customList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
















    }
}
