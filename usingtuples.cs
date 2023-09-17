using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_assignment
{
    public class usingtuples
    {

        public (string, int,int,double,double) getpersoninfo() {
            string name = "Krishna";
            int age = 23;
            int salary = 15000;
            double com = 2.5;
            double tot = salary + (salary * com) / 100;
            return (name, age,salary,com,tot);
        }
    }
}
