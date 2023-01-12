using System;

class Program
{
    static void Main(string[] args)
    {
        {
            DisplayWelcome();

            string Username = PromptUserName();
            int userNumber = PromptUserNumber(); 

            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(Username, squaredNumber);

        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name; 
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite nember? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }


        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }


        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square} ");
        }

    }
}