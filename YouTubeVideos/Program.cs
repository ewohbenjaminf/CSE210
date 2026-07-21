using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video(
            "Learn C# in 20 Minutes",
            "Programming Academy",
            1200);

        video1.AddComment(new Comment("Benjamin", "Excellent explanation!"));
        video1.AddComment(new Comment("Sarah", "Very helpful tutorial."));
        video1.AddComment(new Comment("Michael", "I finally understand classes."));
        video1.AddComment(new Comment("Grace", "Please make more videos."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video(
            "Top 10 Travel Destinations",
            "Travel World",
            840);

        video2.AddComment(new Comment("John", "Amazing places!"));
        video2.AddComment(new Comment("Anna", "I want to visit Japan."));
        video2.AddComment(new Comment("David", "Beautiful scenery."));
        video2.AddComment(new Comment("Lucy", "Great editing."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video(
            "Healthy Breakfast Recipes",
            "Kitchen Master",
            960);

        video3.AddComment(new Comment("Emma", "Looks delicious!"));
        video3.AddComment(new Comment("Daniel", "Easy to follow."));
        video3.AddComment(new Comment("Sophia", "Can't wait to try this."));
        video3.AddComment(new Comment("James", "Healthy and simple."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video(
            "Football Highlights 2026",
            "Sports Central",
            600);

        video4.AddComment(new Comment("Chris", "What a fantastic goal!"));
        video4.AddComment(new Comment("Kevin", "Best match of the season."));
        video4.AddComment(new Comment("Linda", "Awesome highlights."));
        video4.AddComment(new Comment("Peter", "Thanks for uploading."));
        videos.Add(video4);

        // Display information
        foreach (Video video in videos)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine();

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}