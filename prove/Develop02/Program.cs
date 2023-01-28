using System;

class Program
{

    // public string fileLocation;

    static void Main(string[] args) {
        
        var userChoice = "";

        while (userChoice != "5")
        {
            System.Console.WriteLine("Please select one of the following choices: ");
            System.Console.WriteLine("1. Write");
            System.Console.WriteLine("2. Display");
            System.Console.WriteLine("3. Load");
            System.Console.WriteLine("4. Save");
            System.Console.WriteLine("5. Quit");
            System.Console.Write("What would you like to do? ");
            //int userChoice = int.Prarse(Console.ReadLine())
            userChoice = Console.ReadLine();

            if(int.TryParse(userChoice, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        System.Console.WriteLine("1");

                        Journal journal = new Journal();
                        journal.CreateEntry();
                        journal.DisplayEntries();

                        break; 
                    case 2:
                        System.Console.WriteLine("2");
                        break; 
                    case 3:
                        System.Console.WriteLine("3");
                        break; 
                    case 4:
                        System.Console.WriteLine("4");
                        break; 
                    case 5:            
                        System.Console.WriteLine("5");
                        break; 
                    default:
                        System.Console.WriteLine("Defa");
                        userChoice = "5";
                        break;
                }
            }
            else
            {
                System.Console.WriteLine("Invalid input, please select a number between 1 and 5.");
            }
            
        }

        
    

        // public void LoadFile()
        // {

        // }

        // public void SaveFile(public void MenuSelect)
        // {
        // }

        // public void CreateNewJournal()  
        // {
            // void newjournal =  
        // }

    }
}