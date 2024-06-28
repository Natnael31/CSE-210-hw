using System;
// using System.Runtime.CompilerServices;
// using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {   
        string returnText = "";
        if(_isHidden == false)
        {
            returnText = _text;
        }
        else if (_isHidden == true)
        {
            for(int i=0; i<_text.Length; i++)
            {
                returnText += "_";
            }
        }

        return returnText;
        
    }
}