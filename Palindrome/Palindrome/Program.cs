using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string strinput, strReversed = "";
            Console.WriteLine("Enter a string or press Q to Quit");
            strinput = Console.ReadLine();


            while (strinput != "Q" ) {

                for (int i = strinput.Length - 1; i >= 0; i--) // Reverse input word
                {
                    strReversed += strinput[i].ToString();
                }
                if (strReversed == strinput) // Checking whether string is palindrome or not
                {
                    Console.WriteLine("String is Palindrome \n Entered String Was {0} and reversed string is {1}", strinput, strReversed);
                }
                else
                {
                    Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reversed string is {1}", strinput, strReversed);
                }

                strReversed = "";
                strinput = "";

                Console.WriteLine("Enter a string or press Q to Quit");
                strinput = Console.ReadLine();

            }
            
            if(strinput=="Q") Console.ReadKey();
        }
    }
    
}
