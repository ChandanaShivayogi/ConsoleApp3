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

        public static bool checkpal(string word)
        {
            int n=word.Length;
            word = word.ToLower();
            for(int i = 0; i < n; i++, n--)
       
            {
                if (word[i] != word[n - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static int countpal(string str)
        {
            str = str + " ";
            string word = "";
            int count=0;
            for(int i = 0; i < str.Length; i++)
            {
                char ch = str[i]; 
                if (ch != ' ')
                    {
                        word += ch;
                    }
                else
                {
                    if (checkpal(word))

                    {
                        count++;
                    }
                    word = "";
                }
            }

            return count;
        
    }
          
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an input of less than 500 characters");
            string a=Console.ReadLine();
            int n = a.Length;
            
            string str = @"!@#$%^&*()_+";
            foreach (var item in str)
            {
                if (a.Contains(item))
                {
                    Console.WriteLine("please enter valid input without special characters");
                    break;
                }

            }
            if (n >= 500)
            {
                
                Console.WriteLine("please enter valid input less than 500 characters");
            }
            else
            {

                int c = 1;
                for(int i = 0; i < n; i++)
                {
                    if(a[i]==' ' || a[i]=='\n' || a[i] =='\t')
                    {
                        c++;
                    }
                }
                

                string fn = @"C:\Temp\CSharpAuthors.txt";
                using (StreamWriter writer = new StreamWriter(fn))
                {
                    writer.WriteLine(a);
                    writer.WriteLine("number of words present in input string is:{0}", c);
                    writer.WriteLine("number of palendromic words present in input string is:{0}", countpal(a) );

                }


            }
            Console.ReadLine();
           


        }
        


    }
}
