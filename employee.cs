using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_assignment
{
    public class employee
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string Phone { get; set; }
        public string gen { get; set; }
        public string age { get; set; }
        public string jt { get; set; }
        public string YoE { get; set; }
        public string Salary { get; set; }
        public string dept { get; set; }
        public employee() { }
        public employee(string firstName, string lastName, string email, string phone, string gender, string age, string job, string yoE, string salary, string department)
        {
            fname = firstName;
            lname = lastName;
            this.email = email;
            Phone = phone;
            gen = gender;
            this.age = age;
            jt = job;
            YoE = yoE;
            Salary = salary;
            dept = department;
        }
    }



}
