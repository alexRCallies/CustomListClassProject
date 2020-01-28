﻿using System;
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
            CustomList<int> acutal = new CustomList<int>();
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
    }
}
