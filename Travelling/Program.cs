using System;
using Travelling.Entities;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice trip: "); //comentários
            Comment c2 = new Comment("Wow that's awesome: "); //comentários

            Post post = new Post
            (
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travelling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
            );

            //para adicionar comentários no meu post

            post.AddComment(c1);
            post.AddComment(c2);


            ///POST 2
            Comment c3 = new Comment("Good night: "); //comentários
            Comment c4 = new Comment("May the Force be with you: "); //comentários

            Post post2 = new Post
            (
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow!",
                5
            );

            //para adicionar comentários no meu post

            post2.AddComment(c3);
            post2.AddComment(c4);

            Console.WriteLine(post);
            Console.WriteLine(post2);

        }
    }
}
 
