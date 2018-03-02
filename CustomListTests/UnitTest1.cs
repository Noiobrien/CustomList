using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            //CustomList foo
            CustomList<int> DataTypeTest = new CustomList<int>();
            DataTypeTest.Add(10);
            Assert.AreEqual(10, DataTypeTest[0]);
        }
        [TestMethod]
        public void ListTestMethod()
        {
            CustomList<string> ListTest = new CustomList<string>();
            ListTest.Add("ListA");
            ListTest.Add("ListB");
            
            string expectedResult = "ListA";
         
            Assert.AreEqual(expectedResult, ListTest[0]);
        }
        
        
        
        //add an object, actual list add
        [TestMethod]
        public void TestMethodRemove()
        {
            CustomList<string> ListTestRemove = new CustomList<string>();
            List.Add("ListA");
            List.Remove("ListB");

            string expectedResult = "List";

            Assert.AreEqual(expectedResult, ListTestRemove);

        }
        //Assert.Isfalse(false);
        [TestMethod]
        public void TestMethodCount()
        {
            CustomList<string> CountTest = new CustomList<string>();


            CountTest.add("Counttwo");
            CountTest.add("Countthree");

            int expectedResult = 2;

            //int actual result
            Assert.AreEqual(expectedResult, CountTest.Count);
        }
        [TestMethod]
        public void ArrayDataTypeTest()
        {
            CustomList<string> AnyDataTypeTest = new CustomList<string>();
            AnyDataTypeTest.add("ValueOne");

            int expectedResult = 0;

            Assert.AreEqual(expectedResult, AnyDataTypeTest);
            //string or int data type
        }
        //RemovestringTest
        //boolean false
        [TestMethod]
        public void DoubleArrayTest()
        {
            CustomList<double> DoubleArrayTest = new CustomList<double>();
            //DoubleArrayTest.count(2);  

            double expectedResult = (30);

            List.add(15);
            List.add(30);
            Assert.AreEqual(expectedResult, DoubleArrayTest.Count);
        }
        //assign new array

        //list.remove
        [Test Method]
        public void AddAStringTest()
        {
            CustomListTest<string> AddStringTest = new CustomListTest<string>();
            List.add("cow");
            List.add("duck");
            List.add("horse");

            string expectedResult = "cow,duck,horse";

            Assert.AreEqual(expectedResult, AddStringTest[a]);

            CustomListTest<string> AddStringTestTwo= new CustomListTest<string>();

            List.add("llama");
            List.add("pig");
            List.add("sheep");

            string expectedResult = "cow,duck,horse,llama,pig,sheep";

            Assert.AreEqual(expectedResult, AddStringTest[a]);
        }
        [TestMethod]
        public void AddRandomIntMethod()
        {
            CustomListTest<int> AddRandomIntMethod = new CustomListTest<int>();

            int expectedResult = 0;

            Assert.AreEqual(expectedResult, AddRandomIntMethod[0]);
        }

        //overload list.add "listone"
        //list.add "listtwo"
  

        //string[]test = new strinng
        //
        //yield return
    }

    
}
       
































































































    
    //Arrange
    //Act
    //Assert
