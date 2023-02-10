using System;

public class Scripture
{
    // Local Variables 
    
    private List<Word> _text = new List<Word>();

    private Reference _reference = new Reference();


    // Constructors
    public Scripture()
    {
    }

    public Scripture(string newReference, string fullText)
    {
        _reference = new Reference(newReference);

    }


    // Methods

    private void StringToWords(string instr)
    {
        List<string> splitWords = instr.Split(" ").ToList<string>();
        foreach (var item in splitWords)
        {
            Word word = new Word(item);
            _text.Add(item);
        }
    }

    public void GetReference()
    {

    }
    public void SetReference(string reference)
    {

    }
    public Word GetWord()
    {

    }
    public void SetWord(List<Word> text)
    {

    }
    public List<Word> GetWord()
    {

    }
    public void StringToWords(string fullTextInput)
    {

    }
    public void Display()
    {

    }
    public void HideRandomWord()
    {

    }    
}