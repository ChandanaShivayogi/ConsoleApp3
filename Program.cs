using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter an input of less than 500 characters");
            string a=Console.ReadLine();
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
            {
                
                Console.WriteLine("please enter valid input");
            }
            else
            {
                //
                //string val = p.palendrome(a);
                string fn = @"C:\Temp\CSharpAuthors.txt";
                using (StreamWriter writer = new StreamWriter(fn))
                {
                    writer.WriteLine(a);
                    writer.WriteLine("number of characters present in input string is:{0}", n);
                }


            }
            Console.ReadLine();
           


        }
        /*public string palendrome(string st)
        {
            if (st != null)
                return ("hello");
            else
                return ("please enter input");
        }*/


    }
}
