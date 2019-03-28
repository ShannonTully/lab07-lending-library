using System;
using LendingLibrary.Classes;

namespace LendingLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library<Book> library = new Library<Book>();

            Book book1 = new Book();
            Author author1 = new Author();
            author1.Name = "Author1";
            book1.Title = "Book 1";
            book1.Writer = author1;
            library.Add(book1);

            Book book2 = new Book();
            Author author2 = new Author();
            author2.Name = "Author2";
            book2.Title = "Book 2";
            book2.Writer = author2;
            library.Add(book2);

            Book book3 = new Book();
            Author author3 = new Author();
            author3.Name = "Author3";
            book3.Title = "Book 3";
            book3.Writer = author3;
            library.Add(book3);

            Book book4 = new Book();
            Author author4 = new Author();
            author4.Name = "Author4";
            book4.Title = "Book 4";
            book4.Writer = author4;
            library.Add(book4);

            Book book5 = new Book();
            Author author5 = new Author();
            author5.Name = "Author5";
            book5.Title = "Book 5";
            book5.Writer = author5;
            library.Add(book5);

            Book book6 = new Book();
            Author author6 = new Author();
            author6.Name = "Author6";
            book6.Title = "Book 6";
            book6.Writer = author6;
            library.Add(book6);

            Book book7 = new Book();
            Author author7 = new Author();
            author7.Name = "Author7";
            book7.Title = "Book 7";
            book7.Writer = author7;
            library.Add(book7);

            Book book8 = new Book();
            Author author8 = new Author();
            author8.Name = "Author8";
            book8.Title = "Book 8";
            book8.Writer = author8;
            library.Add(book8);

            Book book9 = new Book();
            Author author9 = new Author();
            author9.Name = "Author9";
            book9.Title = "Book 9";
            book9.Writer = author9;
            library.Add(book9);

            Book book10 = new Book();
            Author author10 = new Author();
            author10.Name = "Author10";
            book10.Title = "Book 10";
            book10.Writer = author10;
            library.Add(book10);

            Borrow(library);
            Console.ReadKey();
        }

        public static void Borrow(Library<Book> library)
        {
            foreach (Book book in library)
            {
                Console.WriteLine($"{book.Title} by {book.Writer.Name}");
            }

        }
    }
}
