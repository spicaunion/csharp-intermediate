using System;

namespace StackOverflowPost_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("I have a question", "bla bla...");
            post.UpVote();
            post.UpVote();
            Console.WriteLine(post.DateCreated);
            Console.WriteLine(post.Vote);
            post.DownVote();
            Console.WriteLine(post.Vote);
            post.Edit("bla bla bla...");
            Console.WriteLine(post.Title + " - " + post.Description);
            Console.ReadKey();
        }
    }
}
