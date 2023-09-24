using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class conditionloop
    {
        public void loop() {
            for (int i = 1; i <= 20; i++) {
                if (i == 3)
                {
                    continue;
                }
                else if(i==15) {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Odd numbers");
            int j = 1;
            while (j < 20) {
                Console.Write(j+" ");
                j = j + 2;
            }
            Console.WriteLine("Even numbers");
            int k = 2;
            do
            {
                Console.Write(k + "  ");
                k = k + 2;
            } while (k < 20);
        }

    }
}
