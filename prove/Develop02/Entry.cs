using System;
// using Newtonsoft.Json;

public class Entry
{
    // [JsonPropertyName("Date")]
    public string _date;
    // [JsonPropertyName("Prompt")]
    public string _prompt;
    // [JsonPropertyName("Response")]
    public string _response;


    // public Entry(string prompt)    
    // {
    //     _prompt = prompt;
    //     GetResponse();
    //     SetDate();
        
    // }

    public Entry(string _date, string _prompt, string _response)
    {
       SetData( _date,  _prompt,  _response);
    }

    public void SetData(string d, string p, string r)
    {
        _date = d;
        _prompt = p;
        _response = r;
    }
    // public Entry()
    // {
    // }

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

