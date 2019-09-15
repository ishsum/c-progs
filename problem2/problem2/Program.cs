using System;
using System.Text;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String 1");
            String s1 = Console.ReadLine();
            Console.WriteLine("Enter String 2");
            String s2 = Console.ReadLine();

            Function fs = new Function();
            
            
            int res = fs.checkChar(s1);
            int res2 = fs.checkChar(s2);

            Console.WriteLine(res+res2);

            s1 = s1.Replace("a", "@");
            s1 = s1.Replace("A", "@");
            s2= s2.Replace("a", "@");
            s2 = s2.Replace("A", "@");

            Console.WriteLine("Replace- "+s1 + " " + s2);
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();
            Console.WriteLine("Uppercase- "+s1 + " " + s2);
            string.Concat(s1, s2);
            Console.WriteLine("Concat- "+s1);

            StringBuilder str= new StringBuilder("Abc");
            str.Append(s1);
            Console.WriteLine("Append s1- "+str);

            str.Remove(1,3);
            Console.WriteLine("remove 1 3- "+str);

            str.Replace("o", "g");
            Console.WriteLine("Replace o with g- "+str);
            str.Insert(3,"f");
            Console.WriteLine("Insert f at 3- " + str);






        }
    }
}
