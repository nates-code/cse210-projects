using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        Console.ReadLine();
        string fname = Console.ReadLine();

        Console.Write("What is you last name?");
        Console.ReadLine();
        string lname = Console.ReadLine();

        Console.Write($"Your name is {lname}, {fname} {lname}.");
    }
}