public class Word
{
    private string _word;
    private Boolean _isHidden;

    //Constructor
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    //toString
    public string bmToString()
    {
        string returnValue = "_";
        if (_isHidden == true)
        {
            for (int i = 1; i < _word.Length; i++)
                returnValue += "_";
        }
        else
        {
            returnValue = _word;
        }
        return returnValue;
    }

    //hideWord
    public void bmHideWord()
    {
        _isHidden = true;
    }

    //showWord
    public void bmShowWord()
    {
        _isHidden = false;
    }
}