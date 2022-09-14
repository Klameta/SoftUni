using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string heading = Console.ReadLine();
            string content = Console.ReadLine();
            List<string> comments = new List<string>();
            string comment = Console.ReadLine();
            while (comment != "end of comments")
            {
                comments.Add(comment);
                comment = Console.ReadLine();
            }
            StringBuilder result = new StringBuilder();
            result.AppendLine($@"<h1>
    {heading}
</h1>"); 
            result.AppendLine($@"<article>
    {content}
</article>");
            foreach (var com in comments)
            {
                result.AppendLine($@"<div>
    {com}
</div>");
            } 
            Console.WriteLine(result);
        }
    }
}
