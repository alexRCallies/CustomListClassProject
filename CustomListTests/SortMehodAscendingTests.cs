using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class SortMethodAscendingTests
    {
        [TestMethod]
        public void SortingMethodTestAscending()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;
            expectedList.CustomAdd(1);
            expectedList.CustomAdd(2);
            expectedList.CustomAdd(3);
            expectedList.CustomAdd(4);
            //Act
            customList.CustomAdd(3);
            customList.CustomAdd(1);
            customList.CustomAdd(4);
            customList.CustomAdd(2);
            expected = expectedList.CustomSortAscending();
            actual = customList.CustomSortAscending();
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SortingMethodAscengingTestNumbersFurtherApart()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;
            expectedList.CustomAdd(1);
            expectedList.CustomAdd(10);
            expectedList.CustomAdd(55);
            expectedList.CustomAdd(400);
            //Act
            customList.CustomAdd(55);
            customList.CustomAdd(1);
            customList.CustomAdd(400);
            customList.CustomAdd(10);

            expected = expectedList.CustomSortAscending();
            actual = customList.CustomSortAscending();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
