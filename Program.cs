using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an input of less than 500 characters");
            string a=Console.ReadLine();
            int count;
            int n = a.Length;
            string str = @"!@#$%^&*()_+";
            foreach (var item in str)
            {
                if (a.Contains(item))
                {
                    Console.WriteLine("please enter valid input without no special characters");
                    break;
                }

            }
            if (n >= 500)
                Console.WriteLine("please enter valid input");
            else
            {
                Console.WriteLine(a);
                Console.WriteLine("number of characters present in input string is:{0}", n);
            }  


            
            Console.ReadLine();
            
        }
    }
}
