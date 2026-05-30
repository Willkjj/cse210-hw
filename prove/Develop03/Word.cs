class Word
{
    private string _word;

    private bool _hidden;
    private int _id;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
    public void HideWord()
    {
        _hidden = true;   
    }

    public string GetWord()
    {
        string tempWord = "";

        if (_hidden)
        {
                foreach ( char c in _word)
            {
                tempWord += '_';
            }
        } else
        {
            tempWord = _word;
        }
        return tempWord;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

    public void DisplayWord()
    {
        Console.Write($"{GetWord()} ");
    }

    public void SetId(int id)
    {
        _id = id;
    }

    public int GetId()
    {
        return _id;
    }
}