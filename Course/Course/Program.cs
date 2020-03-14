using System;
using Course.Entidades;

namespace Course {
    class Program {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip ");
            Comment c2 = new Comment("Wow , that awesome! ");
            Comment c3 = new Comment("Good night! ");
            Comment c4 = new Comment("May the force be with you ");

            Post p1 = new Post(
                DateTime.Parse("21/10/2018 13:05:11 "),
                "Traveling  new zealand",
                "I going",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Post p2 = new Post(
                DateTime.Parse("29/05/2019 20:05:11 "),
                "Good night",
                "Se you",
                5
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);

        }
    }
}
