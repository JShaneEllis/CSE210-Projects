using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 101);
        
        int guessInt = 0;
       
        while (guessInt != magicNumberInt)
        {        
        Console.Write("What is your guess? 1 - 100 ");
        string guess = Console.ReadLine();    
        guessInt = int.Parse(guess);    
            
            if (guessInt < magicNumberInt)
            {
                Console.WriteLine("Higer");
                        
            }   


            else if (guessInt > magicNumberInt)
            {
                Console.WriteLine("Lower");
                
            }
            else 
            {
                Console.WriteLine("You guessed the number!");
            } 
        }   
    }   

}