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
    public partial class BookReport : Form
    {
        public TextBox textBox1;

        public BookReport()
        {
            InitializeComponent();
            textBox1 = new TextBox();
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Dock = DockStyle.Fill;
            this.Controls.Add(textBox1);
        }

        private void BookReport_Load(object sender, EventArgs e)
        {

        }
    }
}
