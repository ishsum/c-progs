using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ques5;
namespace Tables2
{
    class Program
    {
        static void Main(string[] args)
        {

            Table []tables = new Table[10];
            for(int i=0;i<5;i++)
            {
                Random random = new Random();
                int height = random.Next(50, 100);
                int width = random.Next(50, 100);
                Table Obj = new Table(height, width);
                tables[i] = Obj;
            }
            for(int j=5;j<10;j++)
            {
                Random random = new Random();
                int height = random.Next(60, 120);
                int width = random.Next(60, 120);
                CoffeeTable ct = new CoffeeTable(height, width);
                tables[j] = ct;
            }
            tables[1].AddLeg();

            for(int i=0;i<10;i++)
            {
                tables[i].ShowData();
            }
        }
    }
}
