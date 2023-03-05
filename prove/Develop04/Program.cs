using System;
using System.Collections .Generic;

namespace Develop04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity.", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing",
                    new List<string> {""});
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."},
                    new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"});
                ListingActivity listingActivity = new ListingActivity("Listing Activity.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                    new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"});
    

                string userChoice = "";
                
                while (userChoice != "4"){
                    
                    Console.WriteLine();
                    Console.WriteLine("Menu Option:");
                    Console.WriteLine("1. Start breathing activity");
                    Console.WriteLine("2. Start reflecting activity");
                    Console.WriteLine("3. Start listing activity");
                    Console.WriteLine("4. Quit");
                    Console.Write("Choose from the menu: ");
                    userChoice = Console.ReadLine();
                    Console.WriteLine();
                    

                    if(int.TryParse(userChoice, out int choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                breathingActivity.Run();
                                break; 
                            case 2:
                                reflectingActivity.Run();
                                break; 
                            case 3:
                                listingActivity.Run();
                                break;
                            default:
                                userChoice = "4";
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please select a number between 1 and 4.");
                    }
            
                }
        }
    }

}

