using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // First Video
        Video video1 = new Video("Every Country On Earth Fights For $250,000!", "MrBeast", 23900);

        Comment video1Comment1 = new Comment("Joshi", "Love to see people around the world are respectful and enjoying each others company.");
        Comment video1Comment2 = new Comment("Julia", "What this man is doing with his platform is simply unbelievable.");
        Comment video1Comment3 = new Comment("Kurbisa", "Glad my Slovene neighbours won silver, and conrats to all, especially Mr. Beast and Lybia.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Second Video
        Video video2 = new Video("The True Story of Asmongold | Wrath of the Lich King", "Asmongold TV", 6920);

        Comment video2Comment1 = new Comment("Casinos", "Never played WoW but Im captivated with this guys ability to tell a great story.");
        Comment video2Comment2 = new Comment("Jynx", "Every so often I come back to this video to get a grasp of the true WoW experience I never had.");
        Comment video2Comment3 = new Comment("John", "Is it weird that I started tearing up when his mom passed on rolling for the mount so he could get it? Wholesome as heck.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Third Video
        Video video3 = new Video("MOGUL CHESSBOXING CHAMPIONSHIP", "Ludwig", 7865);

        Comment video3Comment1 = new Comment("Lindy", "The chess commentator Levy made the games so entertaining to watch, shout-out to him.");
        Comment video3Comment2 = new Comment("Timmy", "That was absolutely incredible. I hope you all enjoyed it as much as I did. Thank you Ludwig.");
        Comment video3Comment3 = new Comment("Felix", "Ludwig giving classic Mr Mcmahon vibes the whole event.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}