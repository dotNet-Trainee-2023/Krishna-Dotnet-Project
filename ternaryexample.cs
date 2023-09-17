using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_assignment
{
    public class ternaryexample
    {
        public int age;
        public void findage()
        {
            Console.WriteLine("Enter your age");
            age=int.Parse(Console.ReadLine());
            string message = (age >= 18) ? "You are Adult and able to vote" : "You are not able to vote";
            Console.WriteLine(message);
        }

        public void Checknull()
        {
            int? num1 = null;
            Console.WriteLine("First number is:"+num1);
            int num2 = 20;
            Console.WriteLine("Second number is:"+num2);
            int n = num1 ?? 10;
            Console.WriteLine("NUllabel number after colascing operator:"+n);
            int result = n + num2;
            Console.WriteLine("Two numbers are:"+n+"and"+num2);
            Console.WriteLine("Nulable value result(SUM)::"+result);
        }
    }
}
