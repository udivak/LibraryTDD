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