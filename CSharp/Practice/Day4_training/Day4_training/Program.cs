using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day4_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "abc";
            //Console.WriteLine(str);
        }
        public static void StringOps() {
            string s = "Hello";
            Console.WriteLine("s for the first time is:{0}",s.GetHashCode());
            //strings are immutable
            string s1 = "CSharp";
            Console.WriteLine("S1 is at :{0} ",s1.GetHashCode());
            Console.WriteLine(s1);


            Console.WriteLine("---------String Builder--------");

            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine("sb's hasg code is {0}", sb.GetHashCode());
            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity);

            //checking by instatiating a string object

            char[] car = new char[] { 'H', 'E', 'L', 'L', 'O' };

        }
    }
} 
