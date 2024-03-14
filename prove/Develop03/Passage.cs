public class Passage
{
    private List<Word> _words;
    private List<Boolean> _flags;

    //Constructor
    public Passage(string passage)
    {
        string[] passageList = passage.Trim().Split(' ');
        _words = new List<Word>();
        _flags = new List<Boolean>();
        foreach(string passagePart in passageList)
        {
            Word word = new Word(passagePart);
            _words.Add(word);
            _flags.Add(false);
        }
    }

    //toString
    public string bmToString()
    {
        List<string> displayList = new List<string>();
        foreach (Word word in _words)
        {
            displayList.Add(word.bmToString());
        }
        string returnValue = string.Join(" ", displayList);
        return returnValue;
    }

    //hideWord
    public void bmHideWord()
    {
        Random random = new Random();
        int counter = _flags.Count();
        for (int i = 0; i < _flags.Count(); i++)
        {
            if (_flags[i] == true)
            {
                counter--;
            }
        }
        int randomInt = random.Next(counter);
        for (int i = 0; i <= randomInt; i++)
        {
            if (_flags[i] == true)
            {
                randomInt++;
            }
        }
        _flags[randomInt] = true;
        _words[randomInt].bmHideWord();
    }

    //isDone
    public Boolean bmIsDone()
    {
        Boolean isDone = true;
        foreach (Boolean flag in _flags)
        {
            if (flag == false)
            {
                isDone = false;
            }
        }
        return isDone;
    }
}