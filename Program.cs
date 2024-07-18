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
            if (!author_name.All(char.IsLetter))
                throw new ArgumentException("Author name can be letters only.");
            if (publication_year < 1900 || publication_year > 2024)
                throw new ArgumentException("Publication year can between 1900-2024.");
            this.ISBN = ISBN;
            this.name = name;
            this.author_name = author_name;
            this.publication_year = publication_year;
            this.category = category;
            this.available = status;
        }
        public void setAvailable()
        {
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
    }
}
