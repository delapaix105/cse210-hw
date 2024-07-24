using System;
using System.Collections.Generic;

public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }

    public override string ToString()
    {
        return $"{CommenterName}: {Text}";
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> Comments { get; set; } = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        foreach (var comment in Comments)
        {
            Console.WriteLine($"  - {comment}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create videos and add comments
        Video video1 = new Video("How to Code in C#", "Tech Guru", 360);
        video1.AddComment(new Comment("Alice", "Great video! Very informative."));
        video1.AddComment(new Comment("Bob", "Thanks for the tips."));
        video1.AddComment(new Comment("Charlie", "I learned a lot, thanks!"));
        
        Video video2 = new Video("Introduction to Data Structures", "Programming Pro", 420);
        video2.AddComment(new Comment("Dave", "Very clear explanation."));
        video2.AddComment(new Comment("Eve", "I appreciate the examples."));
        
        Video video3 = new Video("Advanced Algorithms", "Algorithm Expert", 540);
        video3.AddComment(new Comment("Frank", "Excellent content, well explained."));
        video3.AddComment(new Comment("Grace", "Looking forward to more videos!"));
        video3.AddComment(new Comment("Hank", "Great detail on complex algorithms."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display details for each video
        foreach (var video in videos)
        {
            video.DisplayDetails();
            Console.WriteLine();
        }
    }
}
