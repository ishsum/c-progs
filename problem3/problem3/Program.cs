using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string pass;
            int f = 0;
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("ENTER LOGIN NAME");
               name= Console.ReadLine();

                Console.WriteLine("ENTER PASSWORD");
                pass =Console.ReadLine();
                if(name== "BootCamp" && pass== "hpel")
                {
                    f = 1;
                    Console.WriteLine("Welcome to C# Applications");
                    break;
                }
            }
            if(f==0)
            {
                Console.WriteLine("Invalid login");
            }




        }
    }
}
