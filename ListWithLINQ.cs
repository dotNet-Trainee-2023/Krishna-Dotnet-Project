using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace first_assignment
{
    internal class ListWithLINQ
    {
        public string name { get; set; }
        public string Address { get; set; }
        public int age { get; set; }
        public void listexample() {


            List<ListWithLINQ> people = new List<ListWithLINQ> {
                new ListWithLINQ {name="Krishna",age=12, Address="Ilam" },
                new ListWithLINQ {name="Ram",age=20, Address="Ilam" },
                new ListWithLINQ {name="Hari",age=30, Address="Jhapa" },
                new ListWithLINQ {name="Ramesh",age=15, Address="ktm" },
                new ListWithLINQ {name="Geeta",age=17, Address="pokhara" },
                new ListWithLINQ {name="Hari",age=43, Address="BTM" },
                new ListWithLINQ {name="Anish",age=20, Address="Panchthar" }


                };

            var noofpeople = people.Count();
            var sortedbyname = people.OrderBy(ListWithLINQ => ListWithLINQ.name);

            var adults = people.Where(ListWithLINQ => ListWithLINQ.age >= 18);

            var addressonly = people.Select(ListWithLINQ => ListWithLINQ.Address);

            var orderagedesc = people.OrderByDescending(ListWithLINQ => ListWithLINQ.age);

            var onlyfromilam = people.Select(ListWithLINQ => ListWithLINQ.Address = "Ilam");

            Console.WriteLine("Sorted names");
            foreach (var person in sortedbyname)
            {
                Console.WriteLine($"{person.name},{person.age}");
            }
            Console.WriteLine("Adults");
            foreach (var person in adults)
            {
                Console.WriteLine($"{person.name},{person.age},{person.Address}");
            }
            Console.WriteLine("Address only");
            foreach (var pers in addressonly)
            {
                Console.WriteLine(pers);
            }
            Console.WriteLine("Age in descending order");
            foreach(var agee in orderagedesc)
            {
                Console.WriteLine($"{agee.name},{agee.age}");
            }
            Console.WriteLine("Only from ilam:");
            foreach (var person in onlyfromilam)
            {
                Console.WriteLine(person);
            }


            Console.WriteLine("No of people:"+noofpeople);






        }
       


    }
}
