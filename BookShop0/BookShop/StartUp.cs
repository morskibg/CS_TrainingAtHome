using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
                //DbInitializer.ResetDatabase(db);
                string command = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine().ToLower());
                List<string> result = GetBooksByAgeRestriction(context, command);
                Console.WriteLine(string.Join(Environment.NewLine,result));
            }
        }

        private static List<string> GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            //List<string> books = new List<string>();
            var result = context
                .Books
                .Where(x => x.AgeRestriction.ToString() == command)
                .Select(x => x.Title)
                .OrderBy(x => x)
                .ToList();
            return result;
        }
    }
}
