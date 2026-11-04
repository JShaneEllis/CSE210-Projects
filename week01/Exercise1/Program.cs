using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        Console.Write("What is Your Last name? ");
        string Lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {Lastname}, {firstname} {Lastname}.");
         }
}
