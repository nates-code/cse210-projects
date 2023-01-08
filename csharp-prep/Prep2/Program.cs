using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade persentage for this class? ");
        string answer = Console.ReadLine();
        int grade = System.Int32.Parse(answer);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }        
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Cangradulation you have passed the class!");
        }
        else 
        {
            Console.WriteLine("You didn't pass the class. Better luck next time.");
        }
    }
}