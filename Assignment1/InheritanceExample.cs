using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class InheritanceExample
    {
        public int a = 10;
        public int b = 15;
        public void display() {
            Console.WriteLine("Two numbers are:"+a+","+b);
        }
    }

    public class sum:InheritanceExample {
        public int c = 15;
        public void sumcalculate() {
            int s = a + b;
            Console.WriteLine("Sum:"+s);
        }


        public class  multiply:sum {
            public void dis()
            {
                Console.WriteLine("Three numbers are:"+a+","+b+"and"+c);
            }
            public void mulcalculate()
            {
                int m = a * b * c;
                Console.WriteLine("Multiply of three numbers:"+m);
            }
        }
    }
}
