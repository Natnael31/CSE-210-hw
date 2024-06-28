using System;

public class Scripture
{
    Reference _reference = new Reference();
    List<Word> _words = new List<Word>();


    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word w = new Word(word);
            _words.Add(w);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        if (_words[numberToHide].IsHidden() == false)
        {
            _words[numberToHide].Hide();    
        }
        
    }
    public string GetDisplayText()
    {
        string fullText = "";
        for (int i =0; i<_words.Count; i++)
        {   
            if(i>3)
            {
                fullText += $"{_words[i].GetDisplayText()} ";            
            }
            
        }
        return $"{_reference.GetDisplayText()} {fullText} ";

    }

    public bool IsCompletelyHidden()
    {   
        bool completelyHidden = true; 
        foreach (Word singleWord in _words)
        {
            if (singleWord.IsHidden() == false)
            {
                completelyHidden = false;
            }
        }
        return completelyHidden;
    }


}