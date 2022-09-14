using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] original = Console.ReadLine().Split(", ");
            Article article = new Article(original[0], original[1], original[2]);
            int lines = int.Parse(Console.ReadLine());
            for (int i = lines; i > 0; i--)
            {
                string[] commandArgs = Console.ReadLine().Split(": ");
                switch (commandArgs[0])
                {
                    case "Edit":
                        article.Edit(commandArgs[1]);
                    break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(commandArgs[1]);
                        break;
                    case "Rename":
                        article.Rename(commandArgs[1]);
                        break;
                }
               
            }
            Console.WriteLine(article);
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public void Edit(string content)
        {
            this.Content = content;
        }
        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }
        public void Rename(string title)
        {
            this.Title = title;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }

    }
}
