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
            foreach (string a_n in author_name.Split())
            {
                if (!a_n.All(char.IsLetter))
                    throw new ArgumentException("Author name can be letters only.");
            }
            if (publication_year < 1900 || publication_year > 2024)
                throw new ArgumentException("Publication year must be between 1900-2024.");
            this.ISBN = ISBN;
            this.name = name;
            this.author_name = author_name;
            this.publication_year = publication_year;
            this.category = category;
            this.available = status;
        }
        public static List<Book> GenerateBooks(int count)
        {
            List<Book> generated_books = new List<Book>();
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
                generated_books.Add(newBook);
            }
            return generated_books;
        }
        public static (List<Book>, double) BubbleSortBooksByYear(List<Book> inputBooks)
        {
            List<Book> sortedBooks = new List<Book>(inputBooks);
            int n = sortedBooks.Count;
            DateTime startTime = DateTime.Now;
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
            DateTime endTime = DateTime.Now;
            double sortingTime = (endTime - startTime).TotalMilliseconds;
            MessageBox.Show($"Sorting time: {sortingTime} milliseconds");
            /*
            // Check if the function returns a value
            if (sortedBooks == null)
            {
                bookReport.textBox1.AppendText("Error: Sort function did not return a value.\r\n");
                //return (inputBooks, sortingTime);
            }

            // Check if the sorted array has lost records
            if (sortedBooks.Count != inputBooks.Count)
            {
                bookReport.textBox1.AppendText("Error: Sorted array has lost records.\r\n");
                // return (inputBooks, sortingTime);
            }

            // Check if the array is indeed sorted
            for (int i = 0; i < sortedBooks.Count - 1; i++)
            {
                if (sortedBooks[i].getPublicationYear() < sortedBooks[i + 1].getPublicationYear())
                {
                    bookReport.textBox1.AppendText("Error: Array is not correctly sorted.\r\n");
                    //  return (inputBooks, sortingTime);
                }
            }

            bookReport.textBox1.AppendText("Sort function passed all checks.\r\n\r\n");*/      //unit testing!!!!!!
            return (sortedBooks, sortingTime);
        }
        public static (List<Book>, double) QuickSortByYear(List<Book> unsortedBooks)
        {
            List<Book> sortedBooks = new List<Book>(unsortedBooks);
            DateTime startTime = DateTime.Now;

            QuickSort(sortedBooks, 0, sortedBooks.Count - 1);

            DateTime endTime = DateTime.Now;
            double sortingTime = (endTime - startTime).TotalMilliseconds;
            MessageBox.Show($"Sorting time: {sortingTime} milliseconds");
            return (sortedBooks, sortingTime);
        }
        private static void QuickSort(List<Book> books, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(books, low, high);
                QuickSort(books, low, partitionIndex - 1);
                QuickSort(books, partitionIndex + 1, high);
            }
        }
        private static int Partition(List<Book> books, int low, int high)
        {
            Book pivot = books[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (books[j].getPublicationYear() > pivot.getPublicationYear())
                {
                    i++;
                    Swap(books, i, j);
                }
            }
            Swap(books, i + 1, high);
            return i + 1;
        }
        private static void Swap(List<Book> books, int i, int j)
        {
            Book temp = books[i];
            books[i] = books[j];
            books[j] = temp;
        }
        public static double calclAverageYear(List<Book> inputBooks)
        {
            return inputBooks.Any() ? inputBooks.Average(b => b.getPublicationYear()) : 0;
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
