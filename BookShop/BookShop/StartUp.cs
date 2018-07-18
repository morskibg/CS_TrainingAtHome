using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using BookShop.Data;
using BookShop.Initializer;
using Microsoft.EntityFrameworkCore;

namespace BookShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var context = new BookShopContext())
            {
                //DbInitializer.ResetDatabase(context);
                //string command = Console.ReadLine();
                //int arg = int.Parse(Console.ReadLine());
                //string result = GetBooksByAgeRestriction(context, command);
                //string result = GetGoldenBooks(context);
                //string result = GetBooksByPrice(context);
                //string result = GetBooksNotRealeasedIn(context, arg);
                //string result = GetBooksByCategory(context, command);
                //string result = GetBooksReleasedBefore(context, command);
                //string result = GetAuthorNamesEndingIn(context, command);
                //string result = GetBookTitlesContaining(context, command);
                //string result = GetBooksByAuthor(context, command);
                //int result = CountBooks(context, arg);
                string result = CountCopiesByAuthor(context);
                Console.WriteLine(string.Join("",result));
                //Console.WriteLine(result);

                //Console.WriteLine(result.Length);
            }
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var booksCount = context
                .Books
                .Select(x => new {x.Author.FirstName, x.Author.LastName, x.Copies})
                .Select(x => $"{x.FirstName} {x.LastName} - {x.Copies}")
                .ToArray();
            return sb.ToString();
        }

        public static int CountBooks(BookShopContext context, int i)
        {
            var books = context
                .Books
                .Where(x => x.Title.Length > i)
                .ToArray();
            return books.Length;
        }

        public static string GetBooksByAuthor(BookShopContext context, string command)
        {
            var books = context
                .Books
                .Where(x => x.Author.LastName.ToLower().StartsWith(command.ToLower()))
                .OrderBy(x => x.BookId)
                .Select(x => $"{x.Title} ({x.Author.FirstName} {x.Author.LastName})")
                .ToArray();
            return string.Join(Environment.NewLine, books);
        }

        public static string GetBookTitlesContaining(BookShopContext context, string command)
        {
            var books = context
                .Books
                .Where(x => x.Title.ToLower().Contains(command.ToLower()))
                .Select(x => x.Title)
                .OrderBy(x => x)
                .ToArray();
            return string.Join(Environment.NewLine, books);
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string command)
        {
            var autors = context
                .Authors
                .Where(x => x.FirstName.EndsWith(command))
                .Select(x => $"{x.FirstName} {x.LastName}")
                .OrderBy(x => x)
                .ToArray();
            return string.Join(Environment.NewLine,autors );
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            
            
            const string format = "dd-MM-yyyy";
            DateTime releaseDate = DateTime.ParseExact(date,format,null);

            var books = context
                .Books
                .Where(x => x.ReleaseDate.Value.Date < releaseDate)
                .OrderByDescending(x => x.ReleaseDate)
                .Select(x => new {x.Title, x.EditionType, x.Price})
                .ToList();
                //.ForEach(x => sb.Append($"{x.Title} - {x.EditionType.ToString()} - ${x.Price:F2}{Environment.NewLine}"));
            return String.Join(Environment.NewLine, books.Select(b => $"{b.Title} - {b.EditionType} - ${b.Price:f2}"));
           
        }

        public static string GetBooksByCategory(BookShopContext context, string command)
        {
            var categories = command.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(x => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(x.ToLower()))
                .Select(x => x.Trim())
                .ToArray();
            
            StringBuilder sb = new StringBuilder();
            var books = context
                .Books
                .Where(x => x.BookCategories.All(y => categories.Contains(y.Category.Name)))
                .Select(x =>x.Title)
                .OrderBy(x => x)
                .ToArray();
            sb.AppendJoin(Environment.NewLine, books);
            return sb.ToString();
             
        }

        public static string GetBooksNotRealeasedIn(BookShopContext context, int year)
        {
            StringBuilder sb = new StringBuilder();
            var books = context
                .Books
                .Where(x => x.ReleaseDate.Value.Year != year)
                .OrderBy(x => x.BookId)
                .Select(x => x.Title)
                .ToArray();
            sb.AppendJoin(Environment.NewLine, books);
            return sb.ToString();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var booksDict = context
                .Books
                .Where(x => x.Price > 40)
                .OrderByDescending(x => x.Price)
                .Select(x => new {x.Title, x.Price})
                .ToDictionary(k => k.Title, k => k.Price);
            foreach (var book in booksDict)
            {
                sb.Append($"{book.Key} - ${book.Value.ToString("F2")}{Environment.NewLine}");
            }

            return sb.ToString();

        }
    

        public static string GetGoldenBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var result = context
                .Books
                .Where(x => x.EditionType.ToString() == "Gold" && x.Copies < 5000)
                .OrderBy(x => x.BookId)
                .Select(x => x.Title)
                .ToArray();
            sb.AppendJoin(Environment.NewLine, result);
            return sb.ToString();
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            string normalizedCommand = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(command.ToLower());
            StringBuilder sb = new StringBuilder();
            var result = context
                .Books
                .Where(x => x.AgeRestriction.ToString() == normalizedCommand)
                .Select(x => x.Title)
                .OrderBy(x => x)
                .ToArray();
            sb.AppendJoin(Environment.NewLine, result);
            return sb.ToString();
        }
    }
}
