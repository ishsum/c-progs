using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER FIRST NUM");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER SECOND NUM");
            int secondnum = Convert.ToInt32(Console.ReadLine());
            Calculator calc = new Calculator();
            
            int sum;
            while(true)
            {
                Console.WriteLine("ENTER 1 for Add 2 for Sub and 0 to Stop");
                int ch = Convert.ToInt32(Console.ReadLine());
                if(ch==0)
                {
                    break;
                }
                switch (ch)
                {
                    case 1:
                        calc.Add(firstnum, secondnum, out sum);
                        Console.WriteLine(sum);
                        break;

                    case 2:
                        int ret = calc.Sub(ref firstnum, ref secondnum);
                        Console.WriteLine(ret);
                        break;

                    default:
                        Console.WriteLine("ENTER 1 or 2");
                        break;

                }
                
            }

        }
    }
}
