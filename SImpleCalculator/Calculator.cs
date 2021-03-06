﻿using System;

namespace SimpleCalculator
{
    class Calculator
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double num3 { get; set; }
        public double result { get; set; }
        public double average { get; set; }
        public string answer { get; set; }
        public string isValid { get; set; }

        public void AskForNumbers()
        {
            Console.Write("Please enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the third number: ");
            num3 = Convert.ToDouble(Console.ReadLine());
        }

        public void CalculateAverage()
        {
            average = (num1 + num2 + num3) / 3;
            Console.WriteLine($"The average is {average}");
        }

    }
}
