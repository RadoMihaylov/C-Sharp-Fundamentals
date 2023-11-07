using System.Security.Cryptography;
using System;

/* 
 
Fight club, love story, Martin Scorsese
2
Edit: underground fight club that evolves into much more
ChangeAuthor: Chuck Palahniuk

 */



namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine().Split(", ").ToArray();
            string title = articleData[0];
            string content = articleData[1];
            string author = articleData[2];
            
            int n = int.Parse(Console.ReadLine());
            Article article = new Article(title, content, author);
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(": ").ToArray();
                string command = input[0];
                string value = input[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(value);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(value);
                        break;
                    case "Rename":
                        article.Rename(value);
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit (string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor (string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}"; 
        }
    }
}
