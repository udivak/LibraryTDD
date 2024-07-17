using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTDD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LibraryMenu());
            
        }
    }
    public class Book
    {
        private string ISBN;
        private string name;
        private string author_name;
        private int publication_year;
        private string category;
        private bool available;         //true - in stock, false - borrowed
        public Book(string ISBN, string name, string author_name, int publication_year, string category, bool status)
        {
            this.ISBN = ISBN;
            this.name = name;
            this.author_name = author_name;
            this.publication_year = publication_year;
            this.category = category;
            this.available = status;
        }
        public static List<Book> GenerateBooks(int count)
        {
            List<Book> books = new List<Book>();
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
            return books;
            if (!this.available) 
                this.available = true;
        }
        public void setBorrowed()
        {
            if (this.available)
                this.available = false;
        }
        public string getTitle()
        {
            return this.name;
        }
        public string getAuthor()
        {
            return this.author_name;
        }
        public int getPublicationYear()
        {
            return this.publication_year;
        }
        public override string ToString()
        public bool getAvailable()
        {
            return this.available;
        }
        public string ToString()
        {
            string status = "";
            if (this.available)
                status = "In Stock";
            else
                status = "Borrowed";
            return $"ISBN = {ISBN}\n" +
                   $"Book Name = {name}\n" +
                   $"Author Name = {author_name}\n" +
                   $"Publication Year = {publication_year}\n" +
                   $"Category = {category}\n" +
                   $"Status = {status}";
        }
        public string getISBN()
        {
            return this.ISBN;
        }
        public string getName()
        {
            return this.name;
        }
        public string getAuthorName()
        {
            return this.author_name;
        }
        public int getPublicationYear()
        {
            return this.publication_year;
        }
        public string getCategory()
        {
            return this.category;
        }
        public bool getAvailability()
        {
            return this.available;
        }
    }
}
