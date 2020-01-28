using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
namespace CustomListTests
{
    [TestClass]
    public class SubtractingListsFromOneAnotherTests
    {
        [TestMethod]
        public void SubtractingAListFromEachOtherToFormOneBABYLIST()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> custom = new CustomList<int>();
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;
            expectedList.CustomAdd(3);
            expectedList.CustomAdd(5);
            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(5);
            list.CustomAdd(2);
            list.CustomAdd(1);
            list.CustomAdd(6);
            customList = custom - list;
            expected = expectedList.ToString();
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractingAListFromEachOtherToFormOneBABYLISTIfEverythingGetsRemoved()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> custom = new CustomList<int>();
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;
           
            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(5);
            list.CustomAdd(1);
            list.CustomAdd(3);
            list.CustomAdd(5);
            customList = custom - list;
            expected = expectedList.ToString();
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractingAListFromEachOtherToFormOneBABYLISTIfEverythingGetsRemovedButInDifferentOrder()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> custom = new CustomList<int>();
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;

            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(5);
            list.CustomAdd(5);
            list.CustomAdd(1);
            list.CustomAdd(3);
            customList = custom - list;
            expected = expectedList.ToString();
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractingAListFromEachOtherToFormOneBABYLISTNothingGetsRemoved()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> custom = new CustomList<int>();
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;
            expectedList.CustomAdd(1);
            expectedList.CustomAdd(3);
            expectedList.CustomAdd(5);
            
            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(5);
            list.CustomAdd(2);
            list.CustomAdd(4);
            list.CustomAdd(6);
            customList = custom - list;
            expected = expectedList.ToString();
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractingAListFromEachOtherToFormOneBABYLISTIfTheFirstListHasDuplicatesOnly1GetsRemoved()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> custom = new CustomList<int>();
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;
            expectedList.CustomAdd(1);
            expectedList.CustomAdd(3);

            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(3);
            list.CustomAdd(2);
            list.CustomAdd(3);
            list.CustomAdd(6);
            customList = custom - list;
            expected = expectedList.ToString();
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractingAListFromEachOtherToFormOneBABYLISTBMinusA()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> custom = new CustomList<int>();
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;
            expectedList.CustomAdd(2);
            expectedList.CustomAdd(6);
            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(5);
            list.CustomAdd(2);
            list.CustomAdd(5);
            list.CustomAdd(6);
            customList = list - custom;
            expected = expectedList.ToString();
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractingAListFromEachOtherToFormOneBABYLISTListsOfDifferentSizes()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> custom = new CustomList<int>();
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;
            expectedList.CustomAdd(3);
            expectedList.CustomAdd(9);
            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(5);
            custom.CustomAdd(7);
            custom.CustomAdd(9);
            list.CustomAdd(1);
            list.CustomAdd(5);
            list.CustomAdd(7);
            customList = custom - list;
            expected = expectedList.ToString();
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
