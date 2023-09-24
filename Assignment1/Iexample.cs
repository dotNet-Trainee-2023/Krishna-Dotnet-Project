using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Iexample:iexam
    {
        public void display(int a, int b)
        {
            Console.WriteLine("Two numbers are:"+a+","+b);


        }

        public int sum(int a, int b)
        { 
            return a + b;
        
        }
    }
}
