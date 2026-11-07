using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int numberInt = -1;
        float numbersTotal= 0;
        while (numberInt != 0)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            numberInt = int.Parse(number);
            if (numberInt != 0)
            numbers.Add(numberInt);
            
            numbersTotal = numbersTotal + numberInt;

        }
        
        Console.WriteLine($"The sum is: {numbersTotal}");
        float numbersAvg = numbersTotal / numbers.Count;
        Console.WriteLine($"The average is: {numbersAvg:F10}");
        Console.WriteLine($"The largest number is {numbers.Max()}");
        
    
    }
}