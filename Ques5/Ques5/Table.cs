using System;
namespace Ques5
{
   public class Table
   {
        int widht;
        int height;
       public Table(int widht,int height)
        {
            this.widht = widht;
            this.height = height;
        }

        internal virtual void ShowData()
        {
            Console.WriteLine("WIDHT-->"+ widht);
            Console.WriteLine("HEIGHT-->"+height);
           

        }
    }
}
