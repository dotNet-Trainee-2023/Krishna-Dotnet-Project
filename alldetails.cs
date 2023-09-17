using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace first_assignment
{
    public class alldetails:details,Isalary
    {
        public string name = "krishna";
        public string address = "Ilam";
        public int age = 23;
        public int salary = 30000;
        public double com = 2.3;
        public double tot;
        public void display() {
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Address:"+address);
            Console.WriteLine("Age:" + age);
        }
        public void displaysalary()
        {
            Console.WriteLine("Salary:" + salary);
            Console.WriteLine("Commission:"+com); 

        }
        public void displaytotal() {
            tot = salary + (salary * com) / 100;
            Console.WriteLine("Total salary:"+tot);
        }
    }
}
