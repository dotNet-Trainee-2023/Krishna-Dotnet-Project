using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class SwitchExample
    {
        public int a = 30;
        public int b = 22;
        public int choice = 4;

        public void findresult() {
            Console.WriteLine();
            Console.WriteLine("1.sum");
            Console.WriteLine("2.Multiply");
            Console.WriteLine("3.Division");
            Console.WriteLine("4.Subtraction");
            switch (choice) {
                case 1:
                    int sum = a + b;
                    Console.WriteLine("sum="+sum);
                    break;
                case 2:
                    int product = a * b;
                    Console.WriteLine("Product:");

                    break;
                case 3:
                    float div = a / b;
                    Console.WriteLine("Division:"+div);
                    break;
                case 4:
                    int sub=a-b;
                    Console.WriteLine("Multiplication:"+sub);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }


    }
}
