using System;

class Program
{
    static void Main(string[] args)
    {
        // Create video objects
        Video video1 = new Video("Product Review: Headphones", "TechyTom", 320);
        Video video2 = new Video("Unboxing: Smartwatch 2025", "GadgetGal", 275);
        Video video3 = new Video("Tutorial: Setup Wireless Speakers", "AudioAce", 600);
        Video video4 = new Video("Comparison: iPhone vs Android", "PhoneFanatic", 450);

        // Add comments to each video
        video1.AddComment(new Comment("Jake", "Awesome review!"));
        video1.AddComment(new Comment("Maya", "Thanks for the clarity."));
        video1.AddComment(new Comment("Sam", "Loved how you covered the features."));
        
        video2.AddComment(new Comment("Lena", "I just bought one too!"));
        video2.AddComment(new Comment("Ethan", "Waiting for a discount 😅"));
        video2.AddComment(new Comment("Chris", "Good job explaining the UI."));

        video3.AddComment(new Comment("Zara", "Finally figured mine out thanks to this!"));
        video3.AddComment(new Comment("Tommy", "Love the background music too."));
        video3.AddComment(new Comment("Leo", "Can you do one on soundbars?"));

        video4.AddComment(new Comment("Grace", "Team iPhone here!"));
        video4.AddComment(new Comment("Ben", "Android wins on battery."));
        video4.AddComment(new Comment("Noah", "Best comparison I’ve seen."));

        // Add videos to a list
        List<Video> videoList = new List<Video> { video1, video2, video3, video4 };

        // Display info
        foreach (Video video in videoList)
        {
            video.DisplayVideoInfo();
        }
    }
}
