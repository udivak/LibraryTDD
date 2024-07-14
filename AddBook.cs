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
    public partial class AddBook : Form
    {
        private Book NewBook = null;
        public AddBook()
        {
            InitializeComponent();

            // Add event handlers for text changed events
            ISBN.TextChanged += Field_Changed;
            name.TextChanged += Field_Changed;
            author_name.TextChanged += Field_Changed;
            publication_year.TextChanged += Field_Changed;

            // Add event handlers for radio buttons
            rbNovel.CheckedChanged += Field_Changed;
            rbScienceFiction.CheckedChanged += Field_Changed;
            rbHistory.CheckedChanged += Field_Changed;
            rbBiography.CheckedChanged += Field_Changed;
            rbKids.CheckedChanged += Field_Changed;
            rbBorrowed.CheckedChanged += Field_Changed;
            rbInStock.CheckedChanged += Field_Changed;

            // Initially disable the Done button
            btnDone.Enabled = false;
        }
        private void Field_Changed(object sender, EventArgs e)
        {
            UpdateDoneButtonState();
        }
        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(ISBN.Text) &&
                   !string.IsNullOrWhiteSpace(name.Text) &&
                   !string.IsNullOrWhiteSpace(author_name.Text) &&
                   !string.IsNullOrWhiteSpace(publication_year.Text) &&
                   (rbNovel.Checked || rbScienceFiction.Checked || rbHistory.Checked || rbBiography.Checked || rbKids.Checked) &&
                   (rbBorrowed.Checked || rbInStock.Checked);
        }
        private void UpdateDoneButtonState()
        {
            btnDone.Enabled = AreAllFieldsFilled();
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string category = "";
                foreach (RadioButton rb in gbCategory.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked)
                    {
                        category = rb.Text;
                    }
                }
                bool status = true;
                foreach (RadioButton rb in gbAvailability.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked && rb.Text == "Borrowed")
                    {
                        status = false;
                    }
                }
                try
                {
                    NewBook = new Book(ISBN.Text, name.Text, author_name.Text, Int32.Parse(publication_year.Text), category, status);
                    LibraryMenu.books.Add(NewBook);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Publication Year (input only numbers).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                this.Close();
            }
        }
        private bool ValidateInput()
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Please fill in all required fields and select all options.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}


