using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddingListsToEachOtherTests
    {
        [TestMethod]
        public void AddingTwoListsTogetherToGetOneMEGALISTint()
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
            expectedList.CustomAdd(2);
            expectedList.CustomAdd(4);
            expectedList.CustomAdd(6);
            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(5);
            list.CustomAdd(2);
            list.CustomAdd(4);
            list.CustomAdd(6);
            customList = custom + list;
            expected = expectedList.ToString();
            actual = customList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddingTwoListsTogetherToGetOneMEGALISTstring()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> custom = new CustomList<string>();
            CustomList<string> list = new CustomList<string>();
            CustomList<string> expectedList = new CustomList<string>();
            string expected;
            string actual;
            expectedList.CustomAdd("alex");
            expectedList.CustomAdd("is");
            expectedList.CustomAdd("getting");
            expectedList.CustomAdd("really");
            expectedList.CustomAdd("tired");
            expectedList.CustomAdd("sigh");
            //Act
            custom.CustomAdd("alex");
            custom.CustomAdd("is");
            custom.CustomAdd("getting");
            list.CustomAdd("really");
            list.CustomAdd("tired");
            list.CustomAdd("sigh");
            customList = custom + list;
            expected = expectedList.ToString();
            actual = customList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddingTwoListsTogetherToGetOneMEGALISTintOneListBiggerThanTheOther()
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
            expectedList.CustomAdd(2);
            expectedList.CustomAdd(4);
            expectedList.CustomAdd(6);
            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            list.CustomAdd(5);
            list.CustomAdd(2);
            list.CustomAdd(4);
            list.CustomAdd(6);
            customList = custom + list;
            expected = expectedList.ToString();
            actual = customList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddingTwoListsTogetherToGetOneMEGALISTintDuplicateNumbers()
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
            expectedList.CustomAdd(4);
            expectedList.CustomAdd(4);
            expectedList.CustomAdd(6);
            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(5);
            list.CustomAdd(4);
            list.CustomAdd(4);
            list.CustomAdd(6);
            customList = custom + list;
            expected = expectedList.ToString();
            actual = customList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
