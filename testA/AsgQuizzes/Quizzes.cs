using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AsgQuizzes
{
    /// <summary>
    /// HINT: Implement this methods to make all tests in QuizzesTest.cs pass
    /// </summary>
    public class Quizzes
    {
        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public int Fib(int n)
        {
            if (n == 1 || n == 2) return 1;
            int nthfibonacciNumber = Fib(n - 1) + Fib(n - 2);
            return nthfibonacciNumber;
        }

        public int[] MultiplicationTable(int n)
        {
            int[] notificationsdata = new int[] { };
            var result1 = string.Empty;
            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    string result = (i * j).ToString() + ',';
                    result1 += result;

                }

            }
            result1 = result1.Substring(0, result1.Length - 1);
            return notificationsdata = result1.Split(',').Select(int.Parse).ToArray();
        }

        public int SumString(string str)
        {
            
            var test1 = "";
            int test2 = 0;
            string[] split = str.Split(' ');
            foreach (string s in split)
            {
                if (s != "")
                {
                    test1 = Regex.Match(s, @"\d+").Value;
                    if (test1 != "")
                        test2 = test2 + Convert.ToInt32(test1);
                }
            }
            return test2;
        }

        public int[] GetSatisfyingNumbers(int limit, Func<int,bool> filter)
        {
            List<int> numbers = new List<int> { };
            
            for (int i = 1; i < limit; i++)
            {
                bool test = filter.Invoke(i);
                if(test)
                {
                    numbers.Add(i);

                }   
            }
            return numbers.ToArray();
        }

        public int[] GetOddNumbers(int n)
        {
            List<int> numbers = new List<int> { };
            for (int i = 0; i <= n; i++)
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                }
            return numbers.ToArray();
        }

        public int GetGreatestNumber(int[] arr)
        {
            int maxValue = arr.Max();
            return maxValue;
            
        }

        public string FormatHex(byte r, byte g, byte b)
        {
            
            string myHex = r.ToString("X") + g.ToString("X") + String.Format("0{0:X}", b);
            return myHex;
        }

        public string[] OrderByAvgScoresDescending(IEnumerable<Exam> exams)
        {

            var q = (from h in exams
                     group h by new { h.Student } into hh
                     select new
                     {
                         hh.Key.Student,
                         Score = hh.Sum(s => s.Score)
                     }).OrderByDescending(i => i.Score);

            string[] examResult = q.Select(pkg => pkg.Student).ToArray();
            return examResult;
        }

        public Exam GetExamFromString(string examStr)
        {
            var myDeserializedObjList = Newtonsoft.Json.JsonConvert.DeserializeObject<Exam>(examStr);
            return myDeserializedObjList;
        }

        public int ParseNumber(string strInput)
        {
            return Int32.Parse(strInput);
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
