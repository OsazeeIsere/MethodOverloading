using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with method overloading ********");
            //calling the int version of the method
            Console.WriteLine($"The sum of x and y is:{Add(3,5)}");
            //calling the double version of the method
            Console.WriteLine($"The sum of x and y is:{Add(3.5, 5.6)}");
            //calling the long version of the method
            Console.WriteLine($"The sum of x and y is:{Add(30_000_000, 5_000_000)}");

            //calling the string version of the method
            Console.WriteLine($"Concatinate two strings:{Add("Isere", " Osazee")}");

           
        }
        // overloaded Add() method
        static int Add(int x, int y)
        {
            return (x + y);
        }
        static double Add(double x, double y)
        {
            return (x + y);
        }
        static long Add(long x, long y)
        {
            return (x + y);
        }
        static string Add(string s1, string s2) { return (s1 + s2); }
    }
}
