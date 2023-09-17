using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_assignment
{
    public class parsing
    {
        public void parsingexample()
        {

            string numbers;
            Console.WriteLine("Enter Nummbers:");
            numbers = Console.ReadLine();
            int num = int.Parse(numbers);
            Console.WriteLine("parsed number:"+num);
        }
        public void tryparseexample() {
            Console.WriteLine("Enter any number:");
            string num=Console.ReadLine();
            if (int.TryParse(num, out int parsednum))
            {
                Console.WriteLine("Parsed Number is:"+parsednum);
            }
        }
    }
}
