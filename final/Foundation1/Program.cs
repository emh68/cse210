using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video Title 1", "Author 1", 300);
        Video video2 = new Video("Smile While You Scrub", "Scrub Daddy Inc.", 120);
        Video video3 = new Video("Waterproofing My Life with Flex Tape", "Phil Swift", 600);

        Comment comment1 = new Comment("User1", "Great video!");
        Comment comment2 = new Comment("Matt Silverton", "I never new about this product before.");
        Comment comment3 = new Comment("User3", "Wow, that looks like an interesting product!");
        Comment comment4 = new Comment("SarahJ", "This will definitely make my life easier!");
        Comment comment5 = new Comment("JaneSmith", "Does it come in different colors?");
        Comment comment6 = new Comment("EmilyR", "I need this in my kitchen!");
        Comment comment7 = new Comment("AlexP", "Thanks for the demo, super helpful.");
        Comment comment8 = new Comment("CraftyMom", "Perfect for my DIY projects.");
        Comment comment9 = new Comment("GamerGuy", "This will enhance my gaming setup.");
        Comment comment10 = new Comment("ChefMike", "Makes cleanup a cinch!");
        Comment comment11 = new Comment("FitnessFanatic", "This will be great for my workouts.");
        Comment comment12 = new Comment("EcoWarrior", "Is this product eco-friendly?");
        Comment comment13 = new Comment("BusyBee", "I need this for my busy schedule.");
        Comment comment14 = new Comment("Fashionista", "Does it come with different design options?");
        Comment comment15 = new Comment("TravelerTom", "Would be great for my travels.");
        Comment comment16 = new Comment("PetLover", "Can it be used for pet grooming?");
        Comment comment17 = new Comment("HandyAndy", "Looks like a useful tool for repairs.");
        Comment comment18 = new Comment("GardenGal", "Perfect for my gardening needs.");

        video1.AddComment(comment1);

        video2.AddComment(comment4);
        video2.AddComment(comment6);
        video2.AddComment(comment10);

        video3.AddComment(comment7);
        video3.AddComment(comment12);
        video3.AddComment(comment17);

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: '{video.GetTitle()}', Author: {video.GetAuthor()}, Length: {video.GetLength()} seconds, Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine($"Comments: ");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()} - {comment.GetCommenterText()}");
            }
            Console.WriteLine();
        }
    }
}