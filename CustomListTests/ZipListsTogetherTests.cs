using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ZipListsTogetherTests
    {
        [TestMethod]
        public void ZipListsTogehterTest()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> custom = new CustomList<int>();
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;
            expectedList.CustomAdd(1);
            expectedList.CustomAdd(2);
            expectedList.CustomAdd(3);
            expectedList.CustomAdd(4);
            expectedList.CustomAdd(5);
            expectedList.CustomAdd(6);
            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(5);
            list.CustomAdd(2);
            list.CustomAdd(4);
            list.CustomAdd(6);
            customList.CustomZip(custom, list);
            expected = expectedList.ToString();
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipListsTogehterTestIfTheSecondListIsBiggerThanFirstList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> custom = new CustomList<int>();
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;
            expectedList.CustomAdd(1);
            expectedList.CustomAdd(2);
            expectedList.CustomAdd(3);
            expectedList.CustomAdd(4);
            expectedList.CustomAdd(5);
            expectedList.CustomAdd(6);
            expectedList.CustomAdd(8);
            expectedList.CustomAdd(10);
            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(5);
            list.CustomAdd(2);
            list.CustomAdd(4);
            list.CustomAdd(6);
            list.CustomAdd(8);
            list.CustomAdd(10);
            customList.CustomZip(custom, list);
            expected = expectedList.ToString();
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipListsTogehterTestIfFirstListIsBiggerThanSecondList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> custom = new CustomList<int>();
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;
            expectedList.CustomAdd(1);
            expectedList.CustomAdd(2);
            expectedList.CustomAdd(3);
            expectedList.CustomAdd(4);
            expectedList.CustomAdd(5);
            expectedList.CustomAdd(6);
            expectedList.CustomAdd(7);
            expectedList.CustomAdd(9);
            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(5);
            custom.CustomAdd(7);
            custom.CustomAdd(9);
            list.CustomAdd(2);
            list.CustomAdd(4);
            list.CustomAdd(6);
            customList.CustomZip(custom, list);
            expected = expectedList.ToString();
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
