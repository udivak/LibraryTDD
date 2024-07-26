using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTDD.Tests
{
    [TestClass()]
    public class BookTests
    {
        private LibraryTDD.LibraryMenu menuFormTest = new LibraryMenu();
        //Book Class Tests
        [TestMethod()] //#1
        public void BookConstructortorTest()
        {
            //Arrange
            Book book;
            //Act
            book = new Book("123456", "book_name", "author name", 2023, "category", true);
            //Assert
            Assert.IsNotNull(book);
            Assert.IsInstanceOfType(book, typeof(Book));
            try         //invalid ISBN
            {
                book = new Book("invalid_isbn", "book_name", "author name", 2023, "category", true);
            }
            catch (ArgumentException err)
            {
                Assert.AreEqual(err.Message, "ISBN must be a digit number.");
            }
            try         //invalid book name
            {
                book = new Book("123456", "", "author name", 2023, "category", true);
            }
            catch (ArgumentException err)
            {
                Assert.AreEqual(err.Message, "Book name cannot be empty or whitespace.");
            }
            try         //invalid author name - whitespace
            {
                book = new Book("123456", "book_name", "", 2023, "category", true);
            }
            catch (ArgumentException err)
            {
                Assert.AreEqual(err.Message, "Author name cannot be empty or whitespace.");
            }
            try         //invalid author name - contains numbers
            {
                book = new Book("123456", "book_name", "author123 name", 2023, "category", true);
            }
            catch (ArgumentException err)
            {
                Assert.AreEqual(err.Message, "Author name can contain letters only.");
            }
            try         //invalid publication year
            {
                book = new Book("123456", "book_name", "author name", 1200, "category", true);
            }
            catch (ArgumentException err)
            {
                Assert.AreEqual(err.Message, "Publication year must be between 1900 and 2024.");
            }
            try         //invalid category
            {
                book = new Book("123456", "book_name", "author name", 2024, "", true);
            }
            catch (ArgumentException err)
            {
                Assert.AreEqual(err.Message, "Category cannot be empty or whitespace.");
            }
        }
        [TestMethod()] //#2
        public void calclAverageYearTest()
        {
            //Arrange
            List<Book> generatedBooksTest = Book.GenerateBooks(10_000);
            double avg_func, avg_manual;
            int publication_year_sum = 0;
            //Act
            avg_func = Book.calclAverageYear(generatedBooksTest);
            foreach (Book book in generatedBooksTest)
            {
                publication_year_sum += book.getPublicationYear();
            }
            avg_manual = (double)publication_year_sum / 10_000;
            //Assert
            Assert.AreEqual(avg_func, avg_manual);
        }
        [TestMethod()] //#3
        public void GenerateBooksTest()
        {
            List<Book> generatedBooksTest = Book.GenerateBooks(10_000);
            Assert.IsNotNull(generatedBooksTest);
            Assert.AreEqual(generatedBooksTest.Count, 10_000);
        }
        [TestMethod()] //#4
        public void SortBooksByYearTest()
        {
            //Arrange
            List<Book> generatedBooksTest = Book.GenerateBooks(10_000);
            double sortingTime;
            List<Book> sortedBooks;
            //Act
            (sortedBooks, sortingTime) = Book.QuickSortByYear(generatedBooksTest);
            //Assert
            Assert.IsNotNull(sortedBooks);
            Assert.AreEqual(sortedBooks.Count, 10_000);
            for (int i = 0; i < 10_000 - 1; i++)
            {
                Assert.IsTrue(sortedBooks.ElementAt(i).getPublicationYear() >= sortedBooks.ElementAt(i + 1).getPublicationYear());
            }
        }

        //LibraryMenu Tests
        [TestMethod()] //#5
        public void AddBookManuallyTest()
        {
            menuFormTest.addBookManually(new object(), new EventArgs());
            Assert.IsTrue(menuFormTest.getAddBookForm().Visible);
            menuFormTest.closeAddBookForm();
        }
        [TestMethod()] //#6
        public void generateBooksTest()
        {
            int booksListSize_beforeGenerate = LibraryMenu.books.Count;
            menuFormTest.generateBooks(new object(), new EventArgs());
            Assert.AreEqual(LibraryMenu.books.Count, booksListSize_beforeGenerate + 10000);
        }
        [TestMethod()] //#7
        public void generateBookReportTest()
        {
            menuFormTest.generateBooks(new object(), new EventArgs());
            menuFormTest.generateBookReport(new object(), new EventArgs());
            Assert.IsTrue(menuFormTest.getBookReportForm().Visible);
            menuFormTest.closeBookReportForm();
        }
        [TestMethod()] //#8
        public void calclAvailableBooksTest()
        {
            //Arrange
            List<Book> generatedBooksTest = Book.GenerateBooks(10_000);
            int available = 0, borrowed = 0;
            int available_test = 0, borrowed_test = 0;
            //Act
            foreach (Book book in generatedBooksTest)
            {
                if (book.getAvailable())
                    available++;
                else
                    borrowed++;
            }
            (available_test, borrowed_test) = Book.calclAvailableBooks(generatedBooksTest);
            //Assert
            Assert.AreEqual(available, available_test);
            Assert.AreEqual(borrowed, borrowed_test);
        }
    }
}