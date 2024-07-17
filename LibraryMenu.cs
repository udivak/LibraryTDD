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
        private void button1_Click(object sender, EventArgs e)
        {
            var new_book_form = new AddBook();
            new_book_form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GenerateBooks(10000);
            MessageBox.Show("10,000 books have been generated and added to the list.",
                            "Generation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void GenerateBooks(int count)
        {
            Random random = new Random();
            HashSet<string> usedISBNs = new HashSet<string>();
            string[] categories = { "Novel", "Science Fiction", "History", "Biography", "Kids" };
            string[] firstNames = { "John", "Jane", "Michael", "Emily", "David", "Sarah", "Robert", "Lisa", "William", "Emma" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez" };

            for (int i = 0; i < count; i++)
            {
                // Generate unique ISBN
                string isbn;
                do
                {
                    isbn = (10000 + random.Next(90000)).ToString();
                } while (!usedISBNs.Add(isbn));

                // Generate random name
                string name = $"Book {i + 1}";

                // Generate random author name
                string authorName = $"{firstNames[random.Next(firstNames.Length)]} {lastNames[random.Next(lastNames.Length)]}";

                // Generate random publication year (let's say between 1900 and 2023)
                int publicationYear = random.Next(1900, 2024);

                // Random category
                string category = categories[random.Next(categories.Length)];

                // Random availability
                bool available = random.Next(2) == 0;

                // Create and add the book
                Book newBook = new Book(isbn, name, authorName, publicationYear, category, available);
                books.Add(newBook);
            }
        }
        public (List<Book>, long) BubbleSortBooksByYear(List<Book> inputBooks)
        {
            List<Book> sortedBooks = new List<Book>(inputBooks);
            int n = sortedBooks.Count;

            long startTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedBooks[j].getPublicationYear() < sortedBooks[j + 1].getPublicationYear())
                    {
                        // Swap
                        var temp = sortedBooks[j];
                        sortedBooks[j] = sortedBooks[j + 1];
                        sortedBooks[j + 1] = temp;
                    }
                }
            }

            long endTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long sortingTime = endTime - startTime;

            bookReport.textBox1.AppendText($"Sorting time: {sortingTime} milliseconds\r\n\r\n");

            // Check if the function returns a value
            if (sortedBooks == null)
            {
                bookReport.textBox1.AppendText("Error: Sort function did not return a value.\r\n");
                return (inputBooks, sortingTime);
            }

            // Check if the sorted array has lost records
            if (sortedBooks.Count != inputBooks.Count)
            {
                bookReport.textBox1.AppendText("Error: Sorted array has lost records.\r\n");
                return (inputBooks, sortingTime);
            }

            // Check if the array is indeed sorted
            for (int i = 0; i < sortedBooks.Count - 1; i++)
            {
                if (sortedBooks[i].getPublicationYear() < sortedBooks[i + 1].getPublicationYear())
                {
                    bookReport.textBox1.AppendText("Error: Array is not correctly sorted.\r\n");
                    return (inputBooks, sortingTime);
                }
            }

            bookReport.textBox1.AppendText("Sort function passed all checks.\r\n\r\n");
            return (sortedBooks, sortingTime);
        }

        public double AverageYearCalc(List<Book> inputBooks)
        {
            return inputBooks.Any() ? inputBooks.Average(b => b.getPublicationYear()) : 0;
        }

        private void GenerateBookReport()
        {
            var (sortedBooks, sortingTime) = BubbleSortBooksByYear(books);

            int totalBooks = sortedBooks.Count;
            double avg = AverageYearCalc(sortedBooks);
            int availableForLoan = sortedBooks.Count(b => b.ToString().Contains("Status = In Stock"));

            bookReport.textBox1.Clear(); // Clear previous content
            bookReport.textBox1.AppendText("Book Report - Sorted by Year of Publication (Descending)\r\n");
            bookReport.textBox1.AppendText("--------------------------------------------------------\r\n");

            foreach (var book in sortedBooks)
            {
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

        private void button3_Click(object sender, EventArgs e)      //make report
        {
            GenerateBookReport();
        }
    }
}