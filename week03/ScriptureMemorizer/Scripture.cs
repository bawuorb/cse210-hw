public class Scripture
{
    private List<Word> words;
    private string reference;

    public Scripture(string reference, string scriptureText)
    {
        this.reference = reference;
        words = scriptureText.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(reference);
        foreach (var word in words)
        {
            word.DisplayWord();
        }
    }

    public void HideWord()
    {
        Random random = new Random();
        var visibleWords = words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count > 0)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.HideWord();
        }
    }

    public bool IsComplete()
    {
        return words.All(w => w.IsHidden);
    }
}
