using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();
            input = input.ToUpper();
            if (input.Length < 26)
            {
                Console.WriteLine("Not a pangram");
            }
            else
            {
                for (int j = 65; j < 91; j++)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == j)
                        {
                            flag++;
                            break;
                        }
                    }
                }
            }
            if (flag == 26)
            {
                Console.WriteLine("it is a pangram");
            }
            else
            {
                Console.WriteLine("not a Pangram");
            }
        
            Console.ReadLine();
        }
       
} }
