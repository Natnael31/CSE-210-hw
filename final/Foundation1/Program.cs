using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine();

        Video v1 = new Video();
        v1._title = "Mickey Mouse";
        v1._author = "Disney";
        v1._length =  1800;
        Video v2 = new Video("Tom and Jerry", "Warnner Bros", 3600);
        Video v3 = new Video("The Lion King", "Disney", 5400);
        Video v4 = new Video("Madagascar", "Universal Pictures", 7200);

        Comment c1 = new Comment("Natnael", "Legend of animations!");
        Comment c2 = new Comment("Gashaw", "Disney's best creation!");
        Comment c3 = new Comment("Biruk", "I love Mickey!");
        Comment c4 = new Comment("Meron", "They crack me up!");
        Comment c5 = new Comment("Abriham", "Jerry is so cunning!");
        Comment c6 = new Comment("Bety", "The funniest cartoon series of all time!");
        Comment c7 = new Comment("Eden", "It reminds me of my childhood!");
        Comment c8 = new Comment("Abel", "I hated scar!");
        Comment c9 = new Comment("Tony", "The best animation movie of all time!");
        Comment c10 = new Comment("Martha", "When is Madagascar 4 comming out?");
        Comment c11= new Comment("Selam", "Madagascar 2 was the best!");
        Comment c12= new Comment("Tedy", "The penguins are the highlight of the movie!");

        v1._comment.Add(c1);
        v1._comment.Add(c2);
        v1._comment.Add(c3);

        v2._comment.Add(c4);
        v2._comment.Add(c5);
        v2._comment.Add(c6);

        v3._comment.Add(c7);
        v3._comment.Add(c8);
        v3._comment.Add(c9);

        v4._comment.Add(c10);
        v4._comment.Add(c11);
        v4._comment.Add(c12);

        List<Video> _videoList = new List<Video>{v1, v2, v3, v4};

        foreach (Video video in _videoList)
        {
            Console.WriteLine($"Video name: {video._title}");
            Console.WriteLine($"Video author: {video._author}");
            Console.WriteLine($"Video length: {video._length} seconds");
            Console.WriteLine($"Number of Comments for {video._title}: {video.GetCommentCount()}");
            Console.WriteLine($"Comments for {video._title}");
            foreach(Comment comment in video._comment)
            {
                Console.WriteLine($"{comment._name} : {comment._text}");
            }
            Console.WriteLine();
        }

    }
}