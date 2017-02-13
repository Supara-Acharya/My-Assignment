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
        public void mult(ref int a)
        {
            a =a* 2;
            Count1++;
            Console.WriteLine("Class parent1 is called once",Count1);
            Console.ReadLine();
        }
    }
    class parent2:parent1
    {
        public int Count2 = 0;
        public void mult(ref int a)
        {
            a =a* 3;
            Count2++;
            Console.WriteLine("Class parent2 is called one", Count2);
            Console.ReadLine();

        }
    }
    class parent3:parent2
    {
        public int Count3 = 0;
        public void mult(ref int a)
        {
            a=a* 5;
            Count3++;
            Console.WriteLine("Class parent3 is called once", Count3);
            Console.ReadLine();
        }
       
    }
    class parent
    {
        public void update(int  newvalue)
        {
            int val = newvalue;
            if (val % 2 == 0 && val%3==0 && val%5==0)
            {
                parent1 p1 = new parent1();
                p1.mult(ref val);
                parent1 p2 = new parent2();
                p2.mult(ref val);
                parent1 p3 = new parent3();
                p3.mult(ref val);

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



       


        