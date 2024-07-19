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

        public LibraryMenu()
        {
            InitializeComponent();
            bookReport = new Report();
        }
        private void addBookManually(object sender, EventArgs e)
        {
            var new_book_form = new AddBook();
            new_book_form.Show();
        }
        private void generateBooks(object sender, EventArgs e)
        {
            List<Book> generatedBooks = Book.GenerateBooks(10000);
            books.AddRange(generatedBooks);
            MessageBox.Show("10,000 books have been generated and added to the list.",
                            "Generation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void generateBookReport(object sender, EventArgs e)
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

            // Display books in the BookReport form
            bookReport.DisplayBooks(sortedBooks);

            // Display sorting time and average year
            MessageBox.Show($"Sorting completed in {sortingTime} milliseconds.\nAverage publication year: {averageYear:F2}",
                            "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Show the BookReport form
            bookReport.Show();
        }

    }
}