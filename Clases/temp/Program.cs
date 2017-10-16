using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

class Training
{
    static void Main()
    {
        var library = new Library
        {
            Name = "Prosveta",
            Books = new List<Book>()
        };
        var sortedDict = new Dictionary<string, decimal>();
        int booksCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < booksCount; i++)
        {
            var inputTokens = Console.ReadLine().Split();

            var title = inputTokens[0];
            var author = inputTokens[1];
            var publisher = inputTokens[2];
            var releaseDate = DateTime.ParseExact(inputTokens[3], "dd.MM.yyyy", CultureInfo.InstalledUICulture);
            var isbn = inputTokens[4];
            var price = decimal.Parse(inputTokens[5]);

            var book = new Book(title, author, publisher, releaseDate, isbn, price);

            library.Books.Add(book);
        }
        foreach (var item in library.Books)
        {
            if (!sortedDict.ContainsKey(item.Author))
            {
                sortedDict.Add(item.Author, 0);
            }
            sortedDict[item.Author] += item.Price;
        }
        foreach (var item in sortedDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} -> {item.Value:f2}");
        }
    }

}
class Book
{
    public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        ReleaseDate = releaseDate;
        Isbn = isbn;
        Price = price;
    }


    public string Title { get; set; }

    public string Author { get; set; }

    public string Publisher { get; set; }

    public DateTime ReleaseDate { get; set; }

    public string Isbn { get; set; }

    public decimal Price { get; set; }
}

class Library
{
    public string Name { get; set; }

    public List<Book> Books { get; set; }
}