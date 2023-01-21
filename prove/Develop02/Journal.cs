using System;
using System.Collections.Generic;

public class Journal
{
    public string _ownerName;
    public List<string> _entries = new List<string>();
    public List<string> _prompts = new List<string>();


    public Journal();


    public void SendingPrompts();
    public void DisplayEntries();
    public void CreateEntry();
}

