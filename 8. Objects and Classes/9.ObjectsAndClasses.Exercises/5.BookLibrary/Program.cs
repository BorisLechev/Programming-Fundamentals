namespace _5.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            var books = new List<Book>();

            for (int i = 0; i < numberOfBooks; i++)
            {
                string input = Console.ReadLine();
                books.Add(AddBookToList(input));
            }

            Library library = new Library { Books = books };
            var authors = new Dictionary<string, decimal>();

            foreach (var book in library.Books)
            {
                if (authors.ContainsKey(book.Author))
                {
                    authors[book.Author] += book.Price;
                }

                else
                {
                    authors[book.Author] = book.Price;
                }
            }

            foreach (var item in authors.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }

        public static Book AddBookToList(string input)
        {
            var inputArgs = input.Split(' ').ToList();
            var author = inputArgs[1];
            var price = decimal.Parse(inputArgs[5]);
            return new Book { Author = author, Price = price };
        }
    }

    public class Book
    {
        public string Author { get; set; }
        public decimal Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
