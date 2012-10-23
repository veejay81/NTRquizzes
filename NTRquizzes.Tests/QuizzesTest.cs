using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NTRquizzes.Tests
{
    /// <summary>
    /// HINT: This class MUST NOT be modified. You don't have to write anything here.
    /// </summary>
    [TestClass]
    public class QuizzesTest
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            var qs = new Quizzes();
            Assert.AreEqual("hola",qs.ReverseString("aloh"));
        }

        /// <summary>
        /// HINT:
        /// The Fibonacci Sequence is the series of numbers:
        /// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
        /// The next number is found by adding up the two numbers before it.
        /// The 2 is found by adding the two numbers before it (1+1)
        /// Similarly, the 3 is found by adding the two numbers before it (1+2),And the 5 is (2+3),and so on!
        /// Example: the next number in the sequence above would be 21+34 = 55
        /// So, the method Fib() in class Quizzes should return: Fib(0)=0, Fib(1)=1, Fib(2)=1, Fib(3)=2, ...
        /// </summary>
        [TestMethod]
        public void FibonacciTest()
        {
            var qs = new Quizzes();
            Assert.AreEqual(8, qs.Fib(6));
        }

        [TestMethod]
        public void MultiplicationTableTest()
        {
            var qs = new Quizzes();
            var table8 = new[]
                             {
                                 1, 2, 3, 4, 5, 6, 7, 8,
                                 2, 4, 6, 8, 10, 12, 14, 16,
                                 3, 6, 9, 12, 15, 18, 21, 24,
                                 4, 8, 12, 16, 20, 24, 28, 32,
                                 5, 10, 15, 20, 25, 30, 35, 40,
                                 6, 12, 18, 24, 30, 36, 42, 48,
                                 7, 14, 21, 28, 35, 42, 49, 56,
                                 8, 16, 24, 32, 40, 48, 56, 64
                             };
            CollectionAssert.AreEqual(table8, qs.MultiplicationTable(8));
        }

        [TestMethod]
        public void Sum100FromStringTest()
        {
            var qs = new Quizzes();
            Assert.AreEqual(100, qs.SumString("5, 23; 42  \r\n\t 30"));
        }

        [TestMethod]
        public void Sum73FromStringTest()
        {
            var qs = new Quizzes();
            Assert.AreEqual(73, qs.SumString("5, 23; 42  \r\n\t 3 0"));
        }

        [TestMethod]
        public void GetSatisfyingNumbersTest()
        {
            var qs = new Quizzes();
            CollectionAssert
                .AreEqual(new[] {3, 6, 9, 12, 15, 18}, qs.GetSatisfyingNumbers(20, n => n%3 == 0));
        }

        [TestMethod]
        public void GetOddNumbersTest()
        {
            var qs = new Quizzes();
            CollectionAssert.AreEqual(new[] { 1, 3, 5, 7, 9 }, qs.GetOddNumbers(10));
        }

        [TestMethod]
        public void GetBiggerNumberTest()
        {
            var qs = new Quizzes();
            Assert.AreEqual(10, qs.GetGreatestNumber(new[] {1, 3, 8, 10, 5, 7}));
        }

        [TestMethod]
        public void FormatHexTest()
        {
            var qs = new Quizzes();
            Assert.AreEqual("FFCC00", qs.FormatHex(255, 204, 0), true);
        }

        [TestMethod]
        public void OrderByAvgScoresDescendingTest()
        {
            var exams =
                new[]
                    {
                        new Exam("anna", 8.0m), new Exam("anna", 6.0m), new Exam("anna", 8.0m),
                        new Exam("marcel", 7.0m), new Exam("marcel", 5.0m), new Exam("marcel", 8.0m),
                        new Exam("lluis", 9.0m), new Exam("lluis", 7.0m), new Exam("lluis", 8.0m),
                        new Exam("ari", 6.0m), new Exam("ari", 4.0m), new Exam("ari", 8.0m),
                    };
            var qs = new Quizzes();
            CollectionAssert.AreEqual(new[] {"lluis", "anna", "marcel", "ari"}
                                      , qs.OrderByAvgScoresDescending(exams));
        }

        [TestMethod]
        public void GetExamFromStringTest()
        {
            var examStr = @"{""Student"" : ""lluis"", ""Score"" : ""9.0""}";
            var qs = new Quizzes();
            var ret = qs.GetExamFromString(examStr);
            Assert.AreEqual("lluis", ret.Student);
            Assert.AreEqual(9.0m, ret.Score);
        }

        [TestMethod]
        public void Parse1to3NumberTest()
        {
            var strInput =
                @"
    _  _ 
  | _| _|
  ||_  _|
";
            var qs = new Quizzes();
            Assert.AreEqual(123, qs.ParseNumber(strInput));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseNumberErrorTest()
        {
            // HINT: Look at the last digit. It may look like a 3 but it is not well formed!
            var strInput =
                @"
    _  _ 
  | _| _ 
  ||_  _|
";
            var qs = new Quizzes();
            Assert.AreEqual(123, qs.ParseNumber(strInput));
        }
    }
}
