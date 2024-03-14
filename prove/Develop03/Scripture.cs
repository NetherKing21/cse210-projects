public class Scripture
{
    private Passage _passage;
    private Reference _reference;

    //Constructor
    public Scripture(string reference, string passage)
    {
        _reference = new Reference(reference);
        _passage = new Passage(passage);
    }

    //toString
    public string bmToString()
    {
        string returnValue = $"{_reference.bmToString()}\n{_passage.bmToString()}";
        return returnValue;
    }

    //hideWord
    public void bmHideWord()
    {
        _passage.bmHideWord();
    }

    //isDone
    public Boolean bmIsDone()
    {
        return _passage.bmIsDone();
    }
}