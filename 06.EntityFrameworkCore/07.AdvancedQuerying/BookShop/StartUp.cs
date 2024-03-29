﻿using System;
using System.Linq;
using BookShop.Models.Enums;

namespace BookShop
{
    using BookShop.Models;
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();

             var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);

            Console.WriteLine(GetBooksByCategory(db, command));
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var enumValue = Enum.Parse<AgeRestriction>(command, true);
            var booksInfo = context.Books
                .Where(b => b.AgeRestriction == enumValue)
                .Select(b => b.Title)
                .OrderBy(b => b);

            return string.Join(Environment.NewLine, booksInfo);
        }
        public static string GetGoldenBooks(BookShopContext context)
        {
            var booksInfo = context.Books
                .Where(b => b.Copies < 5_000 && b.EditionType == EditionType.Gold)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title);

            return string.Join(Environment.NewLine, booksInfo);
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var booksInfo = context.Books
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .Select(b => new
                {
                    StringInfo = $"{b.Title} - ${b.Price:F2}"
                });

            return string.Join(Environment.NewLine, booksInfo.Select(b => b.StringInfo));
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var booksInfo = context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title);

            return string.Join(Environment.NewLine, booksInfo);
        }
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.ToLower().Split(' ').ToList();
            var booksInfo = context.Books
                .Select(b => new
                {
                    b.Title,
                    BookCategories = b.BookCategories.Select(bc => new
                    {
                        Category = bc.Category.ToString().ToLower()
                    }).ToList()
                })
                .Where(b => categories.Contains(b.BookCategories.ToString()))
                .ToList();
            return string.Join(Environment.NewLine, booksInfo.Select(bi => bi.Title));
        }
    }

}


