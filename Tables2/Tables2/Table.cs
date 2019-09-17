using System;
namespace Ques5
{
   public class Table
   {
        protected int widht;
       protected int height;
        Leg setobj;
        public Table(int widht,int height)
        {
            this.widht = widht;
            this.height = height;

        }
        public void AddLeg()
        {
            setobj =new Leg();

        }
        public virtual void ShowData()
        {
            if(setobj!=null)
            {
                setobj.ShowData();

            }
            Console.WriteLine("WIDHT-->"+ widht);
            Console.WriteLine("HEIGHT-->"+height);
           

        }
    }
}
