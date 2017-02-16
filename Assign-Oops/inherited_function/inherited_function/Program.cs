using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherited_function
{
    class parent1
    {
        public int Count1 = 0;
        public void mult1(ref int a)
        {
            a =a* 2;
            Count1++;
            Console.WriteLine("Class parent1 is called " + Count1 + " times");
            
        }
    }
    class parent2:parent1
    {
        public int Count2 = 0;
        public void mult2(ref int a)
        {
            a =a* 3;
            Count2++;
            Console.WriteLine("Class parent2 is called "+ Count2+" times");
            

        }
    }
    class parent3:parent2
    {
        public int Count3 = 0;
        public void mult3(ref int a)
        {
            a=a* 5;
            Count3++;
            Console.WriteLine("Class parent3 is called "+ Count3+" times");
         
        }
       
    }
    class parent
    {
        public void update(int  newvalue)
        {
            int val = newvalue;
            if (val % 2 == 0 && val%3==0 && val%5==0)
            {
              
                parent3 p3 = new parent3();
                p3.mult1(ref val);
                p3.mult2(ref val);
                p3.mult3(ref val);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Input is not a prime factor of 2,3,5");
                Console.ReadLine();
            }
   
          }
             
    }
        
    class Program
{

    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter your value");
       int value = int.Parse(Console.ReadLine());
       
        parent obj = new parent();
        obj.update(value);

    }
}
}



       


        