
class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<Word> _hiddenWords = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        // how??
    }

    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);

        Array words = text.Split(" ");
        AddWordsToWords(words);

    }
    public Scripture(string book, int chapter, int startVerse, string text)
    {
        _reference = new Reference(book, chapter, startVerse);

        Array words = text.Split(" ");
        AddWordsToWords(words);

    }

    private void AddWordsToWords(Array words)
    {
        foreach (string word in words)
        {
            Word newWord = new Word(word);

            _words.Add(newWord);
        }
    }

    public void HideThreeWords()
    {


        for (int i = 0; i < 3; i++)
        {
            if (HiddenWordsEqualsWords())
            {
                return;
            }
            bool suceeded = false;

            while (suceeded == false)
            {
                Random rand = new Random();

                int randomWordIndex = rand.Next(0, _words.Count());
                Word checkedWord = _words[randomWordIndex];

                checkedWord.SetId(randomWordIndex);

                if (_hiddenWords.Contains(checkedWord))
                {

                }
                else
                {
                    _hiddenWords.Add(checkedWord);
                    _words[randomWordIndex].HideWord();
                    suceeded = true;
                }
            }

        }
    }

    public bool HiddenWordsEqualsWords()
    {
        if (_words.Count() <= _hiddenWords.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public void DisplayEverything()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetFullReference());

        foreach (Word word in _words)
        {
            word.DisplayWord();
        }
    }

}