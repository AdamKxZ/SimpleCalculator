using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Calculator Program");

            Calculator calculator = new Calculator();

            var isValid = true;
            string answer;

            while (isValid == true)
            {
                calculator.MainMenu();
                bool menuValid = true;
                while (menuValid == true)
                {

                    if (calculator.choice == "1")
                    {
                        calculator.AskForNumbers();
                        calculator.CalculateSum();
                        menuValid = false;
                        AskToContinue();
                    }
                    else if (calculator.choice == "2")
                    {
                        calculator.AskForNumbers();
                        calculator.CalculateAverage();
                        menuValid = false;
                        AskToContinue();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Response.");
                        Console.ReadLine();
                        Console.Clear();
                        calculator.MainMenu();
                    }
                }

            }

            void AskToContinue()
            {
                var askToContinue = true;

                while (askToContinue == true)
                {
                    Console.WriteLine("Would you like to continue? (Y)es or (N)o: ");
                    answer = Console.ReadLine();

                    if (answer == "yes" || answer == "y")
                    {
                        Console.Clear();
                        askToContinue = false;
                        isValid = true;
                    }
                    else if (answer == "no" || answer == "n")
                    {
                        isValid = false;
                        askToContinue = false;
                    }
                    else
                    {
                        Console.WriteLine("You must enter yes or no...");
                        askToContinue = true;
                    }
                }
            }

        }
    }
}
