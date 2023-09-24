using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class listexample
    {
          LinkedList<int> list=new LinkedList<int>();
        public void numbers()
        {
            list.AddFirst(1);
            list.AddLast(2);
            list.AddFirst(3);
            list.AddFirst(4);   


        }
        public void display() {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}
