

namespace BookShop.Models
{
    public class BookCategory
    {
        public int BookID { get; set; }
        public Book Book { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
