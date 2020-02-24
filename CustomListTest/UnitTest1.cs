using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PraseodymiumTDD;
namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_OneValue_CountIncrement()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int expected = 1;
            int actual;

            //Act
            myList.Add(value1);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_NegitiveNumbers_ListAllowed()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int newValue = -5;
            int expected = 1;
            int actual;

            //Act

            myList.Add(newValue);
            actual = myList.count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_MultipleIntegers_ListArrayGrows()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value2 = 10;
            int value3 = 15;
            int value4 = 20;
            int value5 = 25;
            int expected = 4;
            int actual;

            //Act
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            actual = myList.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_TwoNewNumbers_OrderIntact()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;
            int value1 = 5;
            int value2 = 10;
            //Act
            myList.Add(value1);
            myList.Add(value2);

            //Assert
            Assert.AreEqual(expected, myList[1]);
        }
        [TestMethod]
        public void Add_DifferentDataType_NotAllowed()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
           

            //Act

            //Assert
        }
    }
}
