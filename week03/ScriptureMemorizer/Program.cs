using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string menu = "";
        bool done = false;
        Reference r1 = new Reference("John", 3, 16);
        Scripture sc1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        Console.Clear();
        Console.Write(r1.GetDisplayText());
        Console.Write(sc1.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Press enter to continue or type 'quit' to finish:");
        menu = Console.ReadLine();
               

        while (menu != "quit" )
        {
             
            
            
            
            for ( int i = 0; i < 3; i ++)
            {
                Random randomGenerator = new Random();
                int wordNumber = randomGenerator.Next(0, sc1._words.Count);
                sc1.HideRandomWords(wordNumber);    
            }
            
            Console.Clear();
            Console.Write(r1.GetDisplayText());
            Console.Write(sc1.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Press enter to continue or type 'quit' to finish:");
            menu = Console.ReadLine();
            done = sc1.IsCompletelyHidden();
            if (done)
            {
                break;
            }
           

        




        }
       
       



    }
}