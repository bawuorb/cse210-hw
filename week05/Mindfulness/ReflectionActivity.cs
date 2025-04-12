using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        List<string> promptPool = new List<string>(_prompts);
        List<string> questionPool = new List<string>(_questions);
        ShuffleList(promptPool);
        ShuffleList(questionPool);

        Console.WriteLine("\nPrompt:");
        Console.WriteLine($"--- {promptPool[0]} ---\n");
        Console.WriteLine("Think about it...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int questionIndex = 0;

        while (DateTime.Now < endTime)
        {
            if (questionIndex >= questionPool.Count)
            {
                ShuffleList(questionPool);
                questionIndex = 0;
            }

            Console.WriteLine("\n" + questionPool[questionIndex]);
            ShowSpinner(5);
            questionIndex++;
        }

        DisplayEndingMessage();
        LogActivity("Reflection Activity", GetDuration());
    }

    private void ShuffleList(List<string> list)
    {
        Random rng = new Random();
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
