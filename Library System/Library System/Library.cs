using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_System
{
    internal class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void BorrowBook(Book book)
        {
            var Hasbook = Books.FirstOrDefault(r => r.Title == book.Title);
            if (Hasbook != null)
            {
                Console.WriteLine($"This book [{Hasbook.Title}] is already there ");
            }
            else
            {
                Books.Add(book);
                Console.WriteLine();
            }
        }
        public void ReturnBook(string title)
        {
            var book = Books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (book == null)
            {
                Console.WriteLine($"Book [{title}] not found.");
            }
            else if (book.IsAvailable)
            {
                Console.WriteLine($"Book [{title}] is already available.");
            }
            else
            {
                book.IsAvailable = true;
                Console.WriteLine($"You returned [{title}]. Thank you!");
            }
        }
    }
}
