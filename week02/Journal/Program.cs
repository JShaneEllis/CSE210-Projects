using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        string menu = "";
        Console.Clear();
        Console.WriteLine("Welcome to the Journal Program!");
        
        while (menu != "5")
        {
            
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menu = Console.ReadLine();

            if (menu == "1")
            {
                Entry newEntry = new Entry();
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string entryText = Console.ReadLine();
                newEntry._date = DateTime.Now.ToString("yyyy/MM/dd");
                newEntry._promtText = prompt;
                newEntry._entryText = entryText;             
                theJournal.AddEntry(newEntry);
                

            }
            else if (menu == "2")
            {
                theJournal.DisplayAll();
            }
            
            else if (menu == "3")
            {
                Console.WriteLine(); 
                Console.Write("What is the file name? ");
                string fileName =  Console.ReadLine();
                
                
                theJournal.LoadFromFile(fileName);
            
            }

            
            else if (menu == "4")
            {
                Console.WriteLine();
                Console.Write("What is the file name? ");
                string fileName =  Console.ReadLine();
               
                
                theJournal.SaveToFile(fileName);
                
                
                
            }
            
            else if (menu == "5")
            {
                Console.WriteLine("You selected Quit. ");
            }
            
            else
            {
                Console.WriteLine("Invalid choice. Please try again. ");
            }

        }

       
    }
}