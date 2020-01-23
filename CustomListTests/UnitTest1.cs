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
            int value = 3;
            //Act
            customList.CustomAdd(value);
            //Assert
            Assert.AreEqual(value, customList.customLists[0]);
        }
        [TestMethod]
        public void CustomListAddMethodCheckIndexAfter0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;
            int secondValue = 4;
            //Act
            customList.CustomAdd(value);
            customList.CustomAdd(secondValue);
            //Assert
            Assert.AreEqual(secondValue, customList.customLists[1]);
        }
        [TestMethod]
        public void CustomListAddMethodCheckIndex0AfterMultipleAdds()
        {
            //Arramge
            CustomList<int> customList = new CustomList<int>();
            int value = 2;
            int secondValue = 4;
            //Act
            customList.CustomAdd(value);
            customList.CustomAdd(secondValue);
            //Assert
            Assert.AreEqual(value, customList.customLists[0]);
        }
        [TestMethod]
        public void CustomListCheckCountAfterAdd()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;
            int expected = 1;
            //Act
            customList.CustomAdd(value);
           //Assert
            Assert.AreEqual(expected, customList.Count);
        }
        [TestMethod]
        public void CustomListCheckCountAfterMultipleAdd()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 3;
            int secondValue = 4;
            int expected = 2;
            //Act
            customList.CustomAdd(value);
            customList.CustomAdd(secondValue);
            //Assert
            Assert.AreEqual(expected, customList.Count);
        }
    }
}
