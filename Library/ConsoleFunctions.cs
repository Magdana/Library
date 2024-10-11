using Library;

public class ConsoleFunctions
{
    private LibraryClass library = new LibraryClass();

    public void StartLibrary()
    {
        while (true)
        {
            Console.WriteLine("\nChoose operation:");
            Console.WriteLine("0 Exit program");
            Console.WriteLine("1 Add new book");
            Console.WriteLine("2 Delete book");
            Console.WriteLine("3 See all books");
            Console.WriteLine("4 Find book by Author");
            Console.WriteLine("5 Search book by title");
            Console.WriteLine("6 Sort books by Publication Year");

            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    Console.WriteLine("Exiting program...");
                    return;
                case "1":
                    AddBook();
                    break;
                case "2":
                    DeleteBook();
                    break;
                case "3":
                    SeeAllBooks();
                    break;
                case "4":
                    FindBookByAuthor();
                    break;
                case "5":
                    SearchBookByTitle();
                    break;
                case "6":
                    SortBooksByPublicationYear();
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    private void AddBook()
    {
        Console.WriteLine("Enter book title:");
        string title = Console.ReadLine();
        Console.WriteLine("Enter book author:");
        string author = Console.ReadLine();
        Console.WriteLine("Enter publication year:");
        int year = int.Parse(Console.ReadLine());

        Book newBook = new Book { Title = title, Author = author, PublicationYear = year };
        Console.WriteLine(library.AddBook(newBook));
    }

    private void DeleteBook()
    {
        Console.WriteLine("Enter the title of the book to delete:");
        string title = Console.ReadLine();
        Console.WriteLine(library.RemoveBook(title));
    }

    public void SeeAllBooks()
    {
        List<Book> books = library.DisplayLibraryContent();
        if (books.Count == 0)
        {
            Console.WriteLine("No books available in the library.");
        }
    }

    public void FindBookByAuthor()
    {
        Console.WriteLine("Enter the author name to search:");
        string author = Console.ReadLine();
        List<Book> foundBooks = library.FindBooksByAuthor(author);

        if (foundBooks.Count == 0)
        {
            Console.WriteLine("No books found for that author.");
        }
        else
        {
            Console.WriteLine("Books by " + author + ":");
            foreach (Book book in foundBooks)
            {
                Console.WriteLine(book.GetBookInfo());
            }
        }
    }

    private void SearchBookByTitle()
    {
        Console.WriteLine("Enter title or author to search:");
        string word = Console.ReadLine();
        List<Book> foundBooks = library.FindBooksByWord(word);

        if (foundBooks.Count == 0)
        {
            Console.WriteLine("No books found matching that search.");
        }
        else
        {
            Console.WriteLine("Books found:");
            foreach (Book book in foundBooks)
            {
                Console.WriteLine(book.GetBookInfo());
            }
        }
    }

    private void SortBooksByPublicationYear()
    {
        List<Book> sortedBooks = library.GetBooksByPublicationYear();

        if (sortedBooks.Count == 0)
        {
            Console.WriteLine("No books available to sort.");
        }
        else
        {
            Console.WriteLine("Books sorted by Publication Year:");
            foreach (Book book in sortedBooks)
            {
                Console.WriteLine(book.GetBookInfo());
            }
        }
    }
}
