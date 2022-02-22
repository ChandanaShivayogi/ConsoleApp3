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

        public static int countpal(string str)
        {
            int c = 0;
            string[] wordslist = str.Split(' ');
            for (int i = 0; i < wordslist.Length; i++)
            {
                //Console.WriteLine(wordslist[i]);
                char[] charArray = wordslist[i].ToCharArray();
                Array.Reverse(charArray);
                //Console.WriteLine(new string (charArray));
                if(new string(charArray) == wordslist[i])
                {
                    c++;
                }

            }
            return c;
        } 

        public static string ValidateInputString(string a)
        {
            Regex regex = new Regex("[!@#$%^&*]");
            bool hasSpecialchars = regex.IsMatch(a);
            if (hasSpecialchars == true)
            {
                return ("please enter valid input without aany special characters");
            }
            else return a;
            
        }
          
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an input of less than 500 characters");
            string a=Console.ReadLine();
            Console.WriteLine(ValidateInputString(a));
           
            if (a.Length >= 500)
            {
                
                Console.WriteLine("please enter valid input less than 500 characters");
            }
            else
            {

                int c = 1;
                for(int i = 0; i < a.Length; i++)
                {
                    if(a[i]==' ' || a[i]=='\n' || a[i] =='\t')
                    {
                        //Console.WriteLine(a[i-1]);
                        c++;
                        //Console.WriteLine(c);
                    }
                }
                string fn = @"C:\Tempo\UserInput.txt";
                try
                {
                    using (StreamWriter writer = new StreamWriter(fn))
                    {
                        writer.WriteLine(a);
                        writer.WriteLine("number of words present in input string is:{0}", c);
                        writer.WriteLine("number of palendromic words present in input string is:{0}", countpal(a));

                    }
                }
                catch
                {
                    Console.WriteLine("File not found");
                }
                


            }
            Console.ReadLine();
           


        }
        


    }
}
