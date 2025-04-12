using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            Console.Write("\nBreathe out... ");
            ShowCountdown(6);
        }

        DisplayEndingMessage();
        LogActivity("Breathing Activity", duration);
    }
}
