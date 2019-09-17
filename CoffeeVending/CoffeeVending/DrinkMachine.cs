using System;

namespace ComplexVending
{
    class DrinkMachine
    {
        const int costOfDrink = 150;
        public int RunningTotal { get; set; }

        public DrinkMachine()
        {
            RunningTotal = 0;
        }
        public void DepositCoin(int money)
        {
            switch (money)
            {
                case (5):
                    RunningTotal += 5;
                    break;
                case (10):
                    RunningTotal += 10;
                    break;
                case (25):
                    RunningTotal += 25;
                    break;
                case (100):
                    RunningTotal += 100;
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
        public void DisplayDrinkSelections()
        {
            Console.WriteLine("*******************--------------------*******************");
            Console.WriteLine("*                    Enter  C - Coke        *");
            Console.WriteLine("*                    Enter P - Pepsi       *");
            Console.WriteLine("*                    Enter D - Diet Coke   *");
            Console.WriteLine("*******************-------------------*******************");
            Console.WriteLine("\nPlease make your selection");
            MakeDrinkSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
        }
        private void MakeDrinkSelection(char selection)
        {
            bool flag = false;
            while (!flag)
            {
                switch (selection)
                {
                    case 'C':
                        Console.WriteLine("Thankyou for choosing a Coke");
                        ReturnChange();
                        flag = true;
                        break;
                    case 'P':
                        Console.WriteLine("Thankyou for choosing a Pepsi");
                        flag = true;
                        ReturnChange();
                        break;
                    case 'D':
                        Console.WriteLine("Thankyou for choosing a Diet Coke");
                        flag = true;
                        ReturnChange();
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please Re-enter your selection : ");
                        selection = Convert.ToChar(Console.ReadLine().ToUpper());
                        break;
                }

            }
        }
        public bool CheckTotal() { return RunningTotal >= costOfDrink; }
        private void ReturnChange()
        {
            if (RunningTotal > costOfDrink)
                Console.WriteLine("Your change is {0:C}", (RunningTotal - costOfDrink) * 0.01);
        }
    }
}
