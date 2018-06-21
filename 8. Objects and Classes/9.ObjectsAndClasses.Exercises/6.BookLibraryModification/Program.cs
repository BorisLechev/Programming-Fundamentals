namespace _6.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BookLibraryModification
    {
        public static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            var books = new List<Book>();

            for (int i = 0; i < numberOfBooks; i++)
            {
                var input = Console.ReadLine();
                books.Add(AddBookToList(input));
            }

            Library library = new Library { Books = books };
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var booksReleasedAfterDate = new Dictionary<string, DateTime>();

            foreach (var book in library.Books)
            {
                if (book.ReleaseDate.CompareTo(date) > 0)
                {
                    booksReleasedAfterDate.Add(book.Title, book.ReleaseDate);
                }
            }

            foreach (var item in booksReleasedAfterDate.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:dd.MM.yyyy}");
            }
        }

        public static Book AddBookToList(string input)
        {
            var inputArgs = input.Split(' ');
            var title = inputArgs[0];
            DateTime releaseDate = DateTime.ParseExact(inputArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var price = decimal.Parse(inputArgs[5]);
            return new Book { Title = title, ReleaseDate = releaseDate };
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
