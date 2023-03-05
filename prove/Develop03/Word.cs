using System; 

public class Word
{
    // Local Variables 
    private string _word;
    private bool _hidden;

    // Constructors
    public Word()
    {
    }

    public Word(string word)
    {
        _word = word;
    }

    // Methods
    public void RandomHide()
    {

    }

    public string GetWord()
    {

    }
    public void SetWord(string word)
    {

    }
    public void SetHidden(bool hidden)
    {

    }
    public bool GetHidden()
    {
        
    }
    public string ToDisplayString()
    {
        char hideChar = '_';
        if (_hidden == true)
        {
            // Team helped with this line of code. 
            return new string(hideChar, _word.Length);
        }
        return _word;



    }
   
}
