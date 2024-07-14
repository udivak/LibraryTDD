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

        public LibraryMenu()
        {
            InitializeComponent();
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
                            "Generation Complete",MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void button3_Click(object sender, EventArgs e)      //make report
        {
            for (int i=0; i<books.Count; i++)
            {
                MessageBox.Show($"{books.ToArray()[i].ToString()}");
            }
            
        }
    }
}
