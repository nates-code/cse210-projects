using System;
using System.Text.Json;
using System.IO;


class Program
{

    static void Main(string[] args) {


        Journal journal = new Journal();

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
            userChoice = Console.ReadLine();

            if(int.TryParse(userChoice, out int choice))
            {
                switch (choice)
                {
                    case 1:

                        journal.CreateEntry();
                    
                        break; 
                    case 2:
                        System.Console.WriteLine("2");

                        journal.DisplayEntries();

                        break; 
                    case 3:

                        LoadFile(journal);
                        journal.DisplayEntries();

                        break; 
                    case 4:

                        SaveFile(journal);
                        System.Console.WriteLine("File saved. ");

                        break; 
                    
                    default:
                        userChoice = "5";
                        break;
                }
            }
            else
            {
                System.Console.WriteLine("Invalid input, please select a number between 1 and 5.");
            }
            
        }
        // To exceed requirements Save or load your document to a database or use a different library or format such as JSON for storage.

        void LoadFile(Journal journal)
        {
            System.Console.WriteLine("What is the file name? ");
            var fileName = Console.ReadLine();

            string json = File.ReadAllText(fileName);
            
            System.Console.WriteLine(json);
            var data = JsonSerializer.Deserialize<List<Entry>>(json)!;
            journal._entries = data;
            
        }

        void SaveFile(Journal journal)
        {
            System.Console.WriteLine("What is the file name? ");
            var fileName = Console.ReadLine();

            var options = new JsonSerializerOptions { IncludeFields = true };

            var json = JsonSerializer.Serialize(journal._entries, options);
            File.WriteAllText(fileName, json);

            
        }

    }
}