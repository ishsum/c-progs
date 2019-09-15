using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building();
            Building office = new Building();
            house.Add(2500,4,2);
            office.Add(4200,25,3);
            int res1 = house.Calculator();
            int res2= office.Calculator();
            Console.WriteLine("Area of House = "+house.area);
            Console.WriteLine("Occupants of House = " +house.occupants);
            Console.WriteLine("Floors in House = " +house.floors);
            Console.WriteLine("Area per person in the House = " +res1);

            Console.WriteLine("Area of House = " +office.area);
            Console.WriteLine("Occupants of House = " +office.occupants);
            Console.WriteLine("Floors in House = " +office.floors);
            Console.WriteLine("Area per person in the House = " +res2);
        }
    }
}
