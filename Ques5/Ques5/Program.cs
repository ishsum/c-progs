using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Table []Tables = new Table[10];
            for(int i=0;i<10;i++)
            {
                Random random = new Random();
                int height = random.Next(50, 100);
                int weight = random.Next(50, 100);
                Table Obj = new Table(height,weight);
                Tables[i] = Obj;
            }

            for(int i=0;i<10;i++)
            {

                Tables[i].ShowData();

            }
        }
    }
}
