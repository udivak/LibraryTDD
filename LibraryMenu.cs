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
        private BookReport bookReport;

        public LibraryMenu()
        {
            InitializeComponent();
            bookReport = new BookReport();
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
        private void GenerateBookReport()
        {
            List<Book> sortedbooks = null;
            var (sortedBooks, sortingTime) = Book.BubbleSortBooksByYear(books);
            //var (sortedBooks, sortingTime) = Book.QuickSortByYear(books);
            if (sortedBooks == null)
                throw new ArgumentNullException("Bubble Sort returned null");
            int totalBooks = sortedBooks.Count;
            double avg = Book.calclAverageYear(sortedBooks);  //Book
            int availableForLoan = sortedBooks.Count(b => b.ToString().Contains("Status = In Stock"));
            
            bookReport.textBox1.Clear(); // Clear previous content
            bookReport.textBox1.AppendText("Book Report - Sorted by Year of Publication (Descending)\r\n");
            bookReport.textBox1.AppendText("--------------------------------------------------------\r\n");
            int i = 1;
            foreach (var book in sortedBooks)
            {
                bookReport.textBox1.AppendText($"Book No.: {i++}\r\n");
                string[] bookInfo = book.ToString().Split('\n');
                bookReport.textBox1.AppendText($"Title: {bookInfo[1].Split('=')[1].Trim()}\r\n");
                bookReport.textBox1.AppendText($"Author: {bookInfo[2].Split('=')[1].Trim()}\r\n");
                bookReport.textBox1.AppendText($"Publication Year: {bookInfo[3].Split('=')[1].Trim()}\r\n");
                bookReport.textBox1.AppendText($"Available for Loan: {(bookInfo[5].Contains("In Stock") ? "Yes" : "No")}\r\n");
                bookReport.textBox1.AppendText("------------------------\r\n");
            }

            bookReport.textBox1.AppendText($"\r\nTotal time it took to sort: {sortingTime} milliseconds\r\n");
            bookReport.textBox1.AppendText($"Total number of books: {totalBooks}\r\n");
            bookReport.textBox1.AppendText($"Average year of publication: {avg:F2}\r\n");
            bookReport.textBox1.AppendText($"Number of books available for loan: {availableForLoan}\r\n");
            
            bookReport.Show(); // Show the BookReport window
        }

        private void generateBookReport(object sender, EventArgs e)      //make report
        {
            GenerateBookReport();
        }
    }
}