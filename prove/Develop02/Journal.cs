using System;
using System.Collections.Generic;


public class Journal
{
    static Random random = new Random();

    public string _ownerName;
    public List<string> _entries = new List<string>();
    public List<string> _prompts = new List<string>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    
    public Journal()
    {
    }


    // public void DisplayEntries()

    public void CreateEntry()
    {
        
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        
        var entry = new Entry(prompt);
        
    }

}

