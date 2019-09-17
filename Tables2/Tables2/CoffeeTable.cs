using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ques5;
namespace Tables2
{
   public class CoffeeTable: Table
    {
       
        public CoffeeTable(int width, int height) : base (width, height)
        {


        }
        public override void ShowData()
        {
            Console.WriteLine("CoffeeTable");
            Console.WriteLine("WIDHT-->" + widht);
            Console.WriteLine("HEIGHT-->" + height);



        }
    }
}
