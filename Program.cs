﻿using PostProj_StringBuilder.Entities;
using System.Globalization;

namespace PostProj_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CultureInfo provider = CultureInfo.InvariantCulture;
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow, that's wonderful!");

            Post post1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland!",
                "I'm going to visit this wonderful country!",
                12
                );
            post1.AddComment(c1);
            post1.AddComment(c2);

            //

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post post2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );
            post2.AddComment(c3);
            post2.AddComment(c4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);

        }
    }
}