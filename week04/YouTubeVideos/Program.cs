using System;

class Program
{
    static void Main(string[] args)
    {
        
        Video v1 = new Video();
        v1._author = "Justin Kay";
        v1._title = "How to read a report.";
        v1._lenght = 120;
        Comment c1 = new Comment();
        c1.AddComment("John Smith", "This was well done.");
        c1.AddComment("Brandon Jones", "I like how you explain things.");
        c1.AddComment("David King","I hope you make more videos.");
        
        string display = v1.GetDisplayText();
        string displayComment = c1.GetDisplayText();
        Console.Clear();
        Console.WriteLine($"{display}"); 
        Console.WriteLine($"{displayComment}");

        
        
        
    }
}