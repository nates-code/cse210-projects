using System;
// using Newtonsoft.Json;

public class Entry
{
    // [JsonProperty("date")]
    public string _date;
    // [JsonProperty("prompt")]
    public string _prompt;
    // [JsonProperty("response")]
    public string _response;


    public Entry(string prompt)    
    {
        _prompt = prompt;
        GetResponse();
        SetDate();
        
    }

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
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

