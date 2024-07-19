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
            dataGridViewBook.Rows.Clear();
            foreach (Book book in books)
            {
                dataGridViewBook.Rows.Add(
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