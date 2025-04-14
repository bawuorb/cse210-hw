public class ScriptureReference
{
    private string refText;

    public ScriptureReference(string reference)
    {
        refText = reference;
    }

    public string ParseReference()
    {
        return refText;
    }

    public List<int> GetVerseRange()
    {
        var range = refText.Split('-');
        List<int> verses = new List<int>();
        if (range.Length == 1)
        {
            verses.Add(int.Parse(range[0].Split(':')[1]));
        }
        else if (range.Length == 2)
        {
            var start = int.Parse(range[0].Split(':')[1]);
            var end = int.Parse(range[1].Split(':')[1]);
            for (int i = start; i <= end; i++)
            {
                verses.Add(i);
            }
        }
        return verses;
    }
}
