using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> BookDatabase { get; set; }

        public decimal AveragePricePerAuthor(string inputName)
        {
            var sinleAuthor = BookDatabase.Where(x => x.AuthorsName == inputName).ToList();
            decimal totalPrice = sinleAuthor.Average(x => x.Price);
            return totalPrice;
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string AuthorsName { get; set; }
        public string PublishersName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string authorsName, string publishersName,
            DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            AuthorsName = authorsName;
            PublishersName = publishersName;
            ReleaseDate = releaseDate;
            ISBN = isbn;
            Price = price;
        }
    }
}
