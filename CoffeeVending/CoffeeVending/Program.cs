using System;

namespace ComplexVending
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinkMachine drinkMachine = new DrinkMachine();
            while (!drinkMachine.CheckTotal())
            {
                Console.WriteLine("Please Enter Money {5,10,25,100} : ");
                drinkMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));
            }
            drinkMachine.DisplayDrinkSelections();
            Console.ReadLine();
        }
    }
}
