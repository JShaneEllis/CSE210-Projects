using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUserName();

        int userNumber = PromptUserNumber();
        
        int squareNumber = SquareNumber(userNumber);
        
        DisplayResult(username, squareNumber);


    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }    
    static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }    
    static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int Number = int.Parse(Console.ReadLine());
            return Number;
        }
    static int SquareNumber(int userNumber)     
        {  
            int square = userNumber * userNumber;
            return square;
        }       

    static void DisplayResult(string name, int Square)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {Square}");
        }
        
              
       
    }
}