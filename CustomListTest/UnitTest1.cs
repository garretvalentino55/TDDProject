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
            int expected = 5;
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
        public void Add_MulitpleNumbers_CheckCapacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value2 = 10;
            int value3 = 15;
            int value4 = 20;
            int value5 = 25;
            int expected = 8;
            int actual;


            //Act

            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            actual = myList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_OneNumber_NolongerThere()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value6 = 9;
            int value7 = 2;
            int expected = 1;
            int actual;

            //Act
            myList.Add(value6);
            myList.Add(value7);
            myList.Remove(value6);
            actual = myList.count;


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_OneNumber_MakeSureIndecencyCorrect()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value10 = 17;
            int value11 = 29;
            int value12 = 72;
            int expected = 72;



            //Act
            myList.Add(value10);
            myList.Add(value11);
            myList.Add(value12);
            myList.Remove(value11);

            //Assert
            Assert.AreEqual(expected, myList[1]);
        }
        [TestMethod]
        public void Remove_AllValues_NothingLeftInList()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();
            int value13 = 52;
            int value14 = 32;
            int value15 = 3;
            int expected = 0;
            int actual;


            //Act
            myList.Add(value13);
            myList.Add(value14);
            myList.Add(value15);
            myList.Remove(value13);
            myList.Remove(value14);
            myList.Remove(value15);
            actual = myList.count;


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void 
    }
}
