using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTDD
{
    public partial class LibraryMenu : Form
    {
        public static List<Book> books = new List<Book>();
        private Report bookReport;
        private AddBook new_book_form;
        public LibraryMenu()
        {
            InitializeComponent();
            bookReport = new Report();
            new_book_form = new AddBook();
        }
        public void addBookManually(object sender, EventArgs e)
        {
            if (!new_book_form.Visible)
            {
                new_book_form = new AddBook();
            }
            new_book_form.Show();
        }
        public void generateBooks(object sender, EventArgs e)
        {
            List<Book> generatedBooks = Book.GenerateBooks(10_000);
            books.AddRange(generatedBooks);
            MessageBox.Show("10,000 books have been generated and added to the list.",
                            "Generation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void generateBookReport(object sender, EventArgs e)
        {
            if (books.Count == 0)
            {
                MessageBox.Show("No books to display. Please generate or add books first.",
                                "No Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Sort the books using QuickSort
            (List<Book> sortedBooks, double sortingTime) = Book.QuickSortByYear(books);
            // Calculate average year
            double averageYear = Book.calclAverageYear(sortedBooks);
            if (!bookReport.Visible)
            {
                bookReport = new Report();
            }
            // Display books in the BookReport form
            bookReport.DisplayBooks(sortedBooks);
            // Display sorting time and average year
            MessageBox.Show($"Sorting completed in {sortingTime} milliseconds.",
                            "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Show the BookReport form
            bookReport.Show();
        }
        public AddBook getAddBookForm()
        {
            return this.new_book_form;
        }
        public void closeAddBookForm()
        {
            this.new_book_form.Close();
        }
        public Report getBookReportForm()
        {
            return this.bookReport;
        }
        public void closeBookReportForm()
        {
            this.bookReport.Close();
        }
    }
}