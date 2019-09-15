using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class TempratureCheck
    {

        public void CheckTemprature(int temp)
        {
            if (temp <= 32)
            {
                Console.WriteLine("The climate is good today");
            }
            else if (temp == 32)
            {
                Console.WriteLine("The temperature is 32");
            }
            else
            {
                Console.WriteLine("It is hot today");
            }
        }
    }
}
