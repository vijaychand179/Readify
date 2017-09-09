using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.ServicesImplementation
{
    public class Implementation
    {
        public static long CalculateFibonacci(long n)
        {
            long a = 0;
            long b = 1;
            if (n == 0)
            {
                return a;
            }
            else if (n == 1 || n == -1)
            {
                return b;
            }
            else
            {
                try
                {
                    if (n > 0)
                    {
                        return GetFibonacciNumber(n, a, (a + b), 2);
                    }
                    else
                    {
                        var mod = n % 2;
                        return mod == 0 ?
                                   (-GetFibonacciNumber((-n), a, (a + b), 2))
                                   : GetFibonacciNumber((-n), a, (a + b), 2);
                    }
                }
                catch (OverflowException ovf)
                {
                    throw;
                }
            }
        }

        private static long GetFibonacciNumber(long n, long add, long sum, long i)
        {
            if (i > n)
            {
                return 1;
            }
            return checked(add + GetFibonacciNumber(n, (sum + add), add, ++i));
        }

        public static string GetTypeOfTriangle(int a, int b, int c)
        {
            if ((a + b) <= c || (b + c) <= a || (c + a) <= b)
            {
                return "Error";
            }
            else if (a == b && b == c)
            {
                return "Equilateral";
            }
            else if (a == b || a == c || b == c)
            {
                return "Isoceles";
            }
            else
            {
                return "Scalene";
            }
        }

        public static string GetToken() { return "3b32687b-99e8-488d-a54d-87cd2fe5cb53"; }

        public static string GetReversedWords(string sentence)
        {
            var reveresedWordsInSentence = string.Join(" ", sentence.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            return reveresedWordsInSentence;
        }
    }
}