using System;
using System.Linq;
using System.Text;
using BookShop.Models.Enums;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace BookShop
{
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);

            // var command = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMostRecentBooks(db));
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
            var categoriesInput = input.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            var booksInfo = context.BooksCategories
                .Where(bc => categoriesInput.Contains(bc.Category.Name.ToLower()))
                .Select(bc => bc.Book.Title)
                .OrderBy(t => t)
                .ToList();

            return string.Join(Environment.NewLine, booksInfo.Select(bc => bc));
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            DateTime dateBefore = DateTime.ParseExact(date, "dd-MM-yyyy", null);

            var booksInfo = context.Books
                .Where(b => b.ReleaseDate < dateBefore)
                .Select(b => new
                {

                    b.Title,
                    Edition = b.EditionType.ToString(),
                    b.Price,
                    Date = b.ReleaseDate
                })
                .OrderByDescending(b => b.Date)
                .ToList();

            var sb = new StringBuilder();
            foreach (var book in booksInfo)
            {
                sb.AppendLine($"{book.Title} - {book.Edition} - ${book.Price:F2}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authorsInfo = context.Authors
                .Where(a => a.FirstName.EndsWith(input))
                .OrderBy(a => a.FirstName)
                .ThenBy(a => a.LastName)
                .Select(a => $"{a.FirstName} {a.LastName}")
                .ToArray();

            return string.Join(Environment.NewLine, authorsInfo);
        }
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var filterInput = input.ToLower();
            var booksInfo = context.Books
                .Where(b => b.Title.ToLower().Contains(filterInput))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, booksInfo);
        }
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var filterInput = input.ToLower();
            var authorsInfo = context.Authors
                .Where(a => a.LastName.ToLower().StartsWith(filterInput))
                .Select(a => new
                {
                    a.FirstName,
                    a.LastName,
                    Books = a.Books.OrderBy(b => b.BookId)
                    .Select(b => b.Title)
                    .ToList()
                })
                .ToList();

            var sb = new StringBuilder();
            foreach (var author in authorsInfo)
            {
                foreach (var book in author.Books)
                {
                    sb.AppendLine($"{book} ({author.FirstName} {author.LastName})");
                }
            }

            return sb.ToString().TrimEnd();
        }
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var count = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            return count;
        }
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authorsInfo = context.Authors
                .Select(a => new
                {
                    a.FirstName,
                    a.LastName,
                    Copies = a.Books.Select(b => b.Copies).Sum()
                })
                .OrderByDescending(a => a.Copies)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var author in authorsInfo)
            {
                sb.AppendLine($"{author.FirstName} {author.LastName} - {author.Copies}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categoryInfo = context.Categories
                .Select(c => new
                {
                    Price = c.CategoryBooks.Select(cb => new
                    {
                        PerBook = cb.Book.Copies * cb.Book.Price
                    }).Sum(cb => cb.PerBook),
                    c.Name
                })
                .OrderByDescending(c => c.Price)
                .ThenBy(c => c.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var category in categoryInfo)
            {
                sb.AppendLine($"{category.Name} ${category.Price:F2}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categoriesInfo = context.Categories
                .Select(c => new
                {
                    c.Name,
                    Books = c.CategoryBooks.Select(cb => new
                    {
                        ReleaseDate = cb.Book.ReleaseDate.Value.Year,
                        cb.Book.Title
                    })
                    .OrderByDescending(c => c.ReleaseDate)
                    .Take(3)
                    .ToList()
                })
                .OrderBy(c => c.Name)
                .ToList();
            StringBuilder sb = new StringBuilder();

            foreach (var category in categoriesInfo)
            {
                sb.AppendLine($"--{category.Name}");
                foreach (var book in category.Books)
                {
                    sb.AppendLine($"{book.Title} ({book.ReleaseDate})");
                }
            }

            return sb.ToString().TrimEnd();

        }

    }

}


