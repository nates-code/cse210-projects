using System;
// using DateTime;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;


    public Entry(string prompt)    
    {
        _prompt = prompt;
        GetResponse();
        SetDate();
        
    }

    public Entry()
    {
    }

    public void GetResponse()
    {
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();

    }

    public void SetDate()
    {
        _date = DateTime.Today.ToString();
    }
}

