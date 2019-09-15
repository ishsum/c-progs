using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature");
            int temprature = Convert.ToInt32(Console.ReadLine());
            TempratureCheck check = new TempratureCheck();
            check.check(temprature);
        }
    }
}
