using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;


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

