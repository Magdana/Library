using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryClass
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public string AddBook(Book book)
        {
            Books.Add(book);
            return ($"new book {book.Title} is added");
        }
        public string RemoveBook(string title)
        {
            Book bookToRemove = null;

            for (int i = 0; i < Books.Count; i++)
            {
                Book book = Books[i];
                if (book.Title == title)
                {
                    bookToRemove = book; 
                    Books.RemoveAt(i); 
                    break;
                }
            }

            if (bookToRemove != null)
            {
                return $"Book '{bookToRemove.Title}' is removed.";
            }
            else
            {
                return "Book not found.";
            }
        }
        public List<Book> GetBooks()
        {
            return Books;
        }
        public List<Book> DisplayLibraryContent()
        {
            Console.WriteLine("Library content:");
            foreach (Book book in Books)
            {
                Console.WriteLine(book.GetBookInfo());
            }
            return Books;
        }
        public List<Book> FindBooksByAuthor(string author)
        {
            List<Book> result = new List<Book>();
            if (author != null)
            {
                foreach (Book book in Books)
                {
                    if (book.Author == author)
                    {
                        result.Add(book);
                    }
                }
            }
            return result;
        }

        public List<Book> FindBooksByWord(string word)
        {
            List<Book> result = new List<Book>();
            if (word != null)
            {
                foreach (Book book in Books)
                {
                    if (book.Author.Contains(word) || (book.Title.Contains(word)))
                    {
                        result.Add(book);
                    }
                }
            }
            return result;
        }

        public List<Book> GetBooksByPublicationYear()
        {
            var query = from Book in Books orderby Book.PublicationYear ascending select Book; 
            return query.ToList();
        }
    }
}
