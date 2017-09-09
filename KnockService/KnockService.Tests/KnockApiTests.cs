using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.ServicesImplementation;

namespace TestServices
{
    [TestClass]
    public class KnockApiTests
    {
        //Fibonacci Tests

        [TestMethod]
        public void Test_For_Fibonacci_0()
        {
           var result = Implementation.CalculateFibonacci(0);
            Assert.AreEqual(result,0);
        }
        [TestMethod]
        public void Test_For_Fibonacci_1()
        {
            var result = Implementation.CalculateFibonacci(1);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void Test_For_Fibonacci_PositiveNumber()
        {
            var result = Implementation.CalculateFibonacci(47);
            Assert.AreEqual(result, 2971215073);
        }
        [TestMethod]
        public void Test_For_Fibonacci_NegativeNumber()
        {
            var result = Implementation.CalculateFibonacci(-34);
            Assert.AreEqual(result, -5702887);
        }
        [TestMethod]
        [ExpectedException(typeof(OverflowException),
    "no content")]
        public void Test_For_Fibonacci_OverFlowException()
        {
            var result = Implementation.CalculateFibonacci(93);
        }


        //TriangleType Tests

        [TestMethod]
        public void Test_For_Equilateral_Triangle()
        {
            var result = Implementation.GetTypeOfTriangle(3,3,3);
            Assert.AreEqual(result, "Equilateral");
        }
        [TestMethod]
        public void Test_For_Isoceles_Triangle1()
        {
            var result = Implementation.GetTypeOfTriangle(4,7,7);
            Assert.AreEqual(result, "Isoceles");
        }
        [TestMethod]
        public void Test_For_Isoceles_Triangle2()
        {
            var result = Implementation.GetTypeOfTriangle(7, 4, 7);
            Assert.AreEqual(result, "Isoceles");
        }
        [TestMethod]
        public void Test_For_Isoceles_Triangle3()
        {
            var result = Implementation.GetTypeOfTriangle(7, 7, 4);
            Assert.AreEqual(result, "Isoceles");
        }
        [TestMethod]
        public void Test_For_Scalene_Triangle()
        {
            var result = Implementation.GetTypeOfTriangle(4,7,8);
            Assert.AreEqual(result, "Scalene");
        }
        [TestMethod]
        public void Test_For_Error_Trianlgle()
        {
            var result = Implementation.GetTypeOfTriangle(1,2,3);
            Assert.AreEqual(result, "Error");
        }


        //Token Test

        [TestMethod]
        public void Test_For_Token()
        {
            var result = Implementation.GetToken();
            Assert.AreEqual(result, "3b32687b-99e8-488d-a54d-87cd2fe5cb53");
        }


        //Reverse words in sentence Test

        [TestMethod]
        public void Test_For_Reverese_Words_In_Sentence()
        {
            var result = Implementation.GetReversedWords("This is unit test for reverse words in sentence");
            Assert.AreEqual(result, "sihT si tinu tset rof esrever sdrow ni ecnetnes");
        }

    }


}
