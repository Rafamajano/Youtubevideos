using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            Video video1 = new Video("C# Tutorial", "John Doe", 600);
            video1.AddComment(new Comment("Alice", "Great tutorial!"));
            video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
            video1.AddComment(new Comment("Charlie", "Loved it!"));
            videos.Add(video1);

            Video video2 = new Video("Learning Abstraction", "Jane Smith", 450);
            video2.AddComment(new Comment("David", "Clear explanation."));
            video2.AddComment(new Comment("Eva", "Good examples."));
            video2.AddComment(new Comment("Frank", "Thanks for sharing."));
            videos.Add(video2);

            Video video3 = new Video("Object-Oriented Programming Basics", "Sam Wilson", 800);
            video3.AddComment(new Comment("George", "Well done."));
            video3.AddComment(new Comment("Hannah", "Nice pacing."));
            video3.AddComment(new Comment("Ian", "Can you cover more topics?"));
            videos.Add(video3);

            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.GetTitle()}");
                Console.WriteLine($"Author: {video.GetAuthor()}");
                Console.WriteLine($"Length (seconds): {video.GetLength()}");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
                }
                Console.WriteLine();
            }
        }
    }
}
