public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void DisplayWord()
    {
        Console.Write(IsHidden ? new string('_', Text.Length) : Text);
        Console.Write(" ");
    }

    public void HideWord()
    {
        IsHidden = true;
    }
}
