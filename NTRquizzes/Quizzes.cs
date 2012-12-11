using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTRquizzes
{
    /// <summary>
    /// HINT: Implement this methods to make all tests in QuizzesTest.cs pass
    /// </summary>
    public class Quizzes
    {
        public string ReverseString(string str)
        {
            throw new NotImplementedException();
        }
        public int Fib(int n)
        {
            throw new NotImplementedException();
        }

        public int[] MultiplicationTable(int n)
        {
            throw new NotImplementedException();
        }

        public int SumString(string str)
        {
            throw new NotImplementedException();
        }

        public int[] GetSatisfyingNumbers(int limit, Func<int,bool> filter)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddNumbers(int n)
        {
            // HINT: This method must be implemented with a call this.GetSatisfyingNumbers
            throw new NotImplementedException();
        }

        public int GetGreatestNumber(int[] arr)
        {
            throw new NotImplementedException();
        }

        public string FormatHex(byte r, byte g, byte b)
        {
            throw new NotImplementedException();
        }

        public string[] OrderByAvgScoresDescending(IEnumerable<Exam> exams)
        {
            throw new NotImplementedException();
        }

        public Exam GetExamFromString(string examStr)
        {
            throw new NotImplementedException();
        }

        public int ParseNumber(string strInput)
        {
            throw new NotImplementedException();
        }
    }

    public class Exam
    {
        public string Student { get; set; }
        public decimal Score { get; set; }

        public Exam(string student,decimal score)
        {
            this.Student = student;
            this.Score = score;
        }
    }

}
