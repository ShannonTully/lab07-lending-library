using System;
using System.Collections.Generic;
using LendingLibrary.Classes;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestBookTitle()
        {
            Book book = new Book();
            book.Title = "book";

            Assert.Equal("book", book.Title);
        }

        [Fact]
        public void TestBookAuthor()
        {
            Book book = new Book();
            Author author = new Author();
            book.Writer = author;

            Assert.Equal(author, book.Writer);
        }

        [Fact]
        public void TestBookGenres()
        {
            List<Book.Genres> list = new List<Book.Genres>();

            list.Add(Book.Genres.Fantasy);
            list.Add(Book.Genres.Fiction);
            list.Add(Book.Genres.Historical);
            list.Add(Book.Genres.HowTo);
            list.Add(Book.Genres.NonFiction);
            list.Add(Book.Genres.SciFi);
            list.Add(Book.Genres.TextBook);

            Assert.Equal(7, list.ToArray().Length);
        }

        [Fact]
        public void TestAuthorName()
        {
            Author author = new Author();
            author.Name = "author";

            Assert.Equal("author", author.Name);
        }

        [Fact]
        public void TestAuthorIsDead()
        {
            Author author = new Author();
            author.IsDead = true;

            Assert.True(author.IsDead);
        }

        [Fact]
        public void TestAuthorWrite()
        {
            Author author = new Author();
            author.HasWrittenABook = true;

            Assert.True(author.HasWrittenABook);
        }

        [Fact]
        public void TestLibraryHoldsBooks()
        {
            Library<Book> library = new Library<Book>();
            Book book = new Book();

            library.Add(book);

            Assert.Equal(1, library.Count());
        }

        [Fact]
        public void TestLibraryCanIterate()
        {
            Library<Book> library = new Library<Book>();
            List<Book> list = new List<Book>();
            Book book1 = new Book();
            Book book2 = new Book();

            library.Add(book1);
            library.Add(book2);

            foreach (Book book in library)
            {
                list.Add(book);
            }

            Assert.Equal(2, list.ToArray().Length);
        }

        [Fact]
        public void TestLibraryAdd()
        {
            Library<Book> library = new Library<Book>();
            Book book = new Book();

            library.Add(book);

            Assert.Equal(1, library.Count());
        }

        [Fact]
        public void TestLibraryRemove()
        {
            Library<Book> library = new Library<Book>();
            Book book1 = new Book();
            book1.Title = "book1";
            Book book2 = new Book();
            book2.Title = "book2";

            library.Add(book1);
            library.Add(book2);

            library.Remove(book1);

            Assert.Equal(1, library.Count());
        }

        [Fact]
        public void TestLibraryCount()
        {
            Library<Book> library = new Library<Book>();
            Book book1 = new Book();
            Book book2 = new Book();

            library.Add(book1);
            library.Add(book2);

            Assert.Equal(2, library.Count());
        }
    }
}
