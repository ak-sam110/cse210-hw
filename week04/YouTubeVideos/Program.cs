using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         List<Video> videos = new List<Video>();

        // Video number 1
        Video video1 = new Video("How to Bake a Cake", "Chef John", 420);
        video1.AddComment(new Comment("Alice", "This recipe worked perfectly!"));
        video1.AddComment(new Comment("Bob", "Can I replace eggs with banana?"));
        video1.AddComment(new Comment("Charlie", "Thanks for the clear instructions."));
        videos.Add(video1);

        // Video number 2
        Video video2 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        video2.AddComment(new Comment("Dave", "Very informative."));
        video2.AddComment(new Comment("Eve", "Can you make a tutorial on LINQ?"));
        video2.AddComment(new Comment("Frank", "This helped me start my project."));
        videos.Add(video2);

        // Video number 3
        Video video3 = new Video("Morning Yoga Routine", "YogaWithEmma", 900);
        video3.AddComment(new Comment("Grace", "Feeling refreshed!"));
        video3.AddComment(new Comment("Hannah", "Loved this session."));
        video3.AddComment(new Comment("Ian", "Please do one for evenings too."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Top 10 Travel Destinations 2025", "TravelNow", 300);
        video4.AddComment(new Comment("Jack", "Can't wait to go to Bali!"));
        video4.AddComment(new Comment("Kelly", "Nice editing and music."));
        video4.AddComment(new Comment("Leo", "Thanks for the inspiration."));
        videos.Add(video4);

        // Display each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine(new string('-', 40));
        }

    }
}