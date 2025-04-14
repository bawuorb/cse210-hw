using System;
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("John 3:16", "For God so loved the world that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life."),
            new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge Him, and He shall direct thy paths.")
        };

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        scripture.DisplayScripture();

        while (!scripture.IsComplete())
        {
            Console.WriteLine("\nPress Enter to hide a word, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideWord();
            scripture.DisplayScripture();
        }

        Console.WriteLine("Scripture memorization complete!");
    }
}
