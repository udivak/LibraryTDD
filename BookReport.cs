using LibraryTDD;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryTDD
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        public void DisplayBooks(List<Book> books)
        {
            int avg_publication_year = (int) Book.calclAverageYear(books);
            int number_of_books = books.Count;
            var (available, borrowed) = Book.calclAvailableBooks(books);
            label2.Text = $"Average Publication Year : {avg_publication_year},  Number of Books : {number_of_books}," +
                          $"  Available Books : {available}";
            int i = 1;
            dataGridViewBook.Rows.Clear();
            foreach (Book book in books)
            {
                dataGridViewBook.Rows.Add(
                    i++,
                    book.getISBN(),
                    book.getTitle(),
                    book.getAuthor(),
                    book.getPublicationYear(),
                    book.getCategory(),
                    book.getAvailable() ? "In Stock" : "Borrowed"
                );
            }
        }
    }
}