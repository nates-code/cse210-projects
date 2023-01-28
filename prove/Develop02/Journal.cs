using System;
using System.Collections.Generic;


public class Journal
{
    static Random random = new Random();

    public string _ownerName;
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing you learned today?",
        "What was the most beautiful thing you saw today?",
        "What were you able to do outside today?",
        "What is the best food you eat today?",
        "What did you spend the most time doing today?"
    };

    
    public Journal()
    {
    }


    public void DisplayEntries()
    {
        Entry response = new Entry();
        
        // _entries.Add(response);

        foreach (var item in _entries)
        {
            System.Console.WriteLine(item._date);
        }
    }

    public void CreateEntry()
    {
        
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        
        Entry entry = new Entry(prompt);
        _entries.Add(entry);
        
    }

}

