
namespace LibraryTDD
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.author_name = new System.Windows.Forms.TextBox();
            this.publication_year = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.rbInStock = new System.Windows.Forms.RadioButton();
            this.rbBorrowed = new System.Windows.Forms.RadioButton();
            this.rbNovel = new System.Windows.Forms.RadioButton();
            this.rbScienceFiction = new System.Windows.Forms.RadioButton();
            this.rbHistory = new System.Windows.Forms.RadioButton();
            this.rbBiography = new System.Windows.Forms.RadioButton();
            this.rbKids = new System.Windows.Forms.RadioButton();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbAvailability = new System.Windows.Forms.GroupBox();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAvailability.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Book\'s details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(193, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(194, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(194, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(194, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Publication Year:";
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(197, 199);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(197, 20);
            this.ISBN.TabIndex = 6;
            this.ISBN.Tag = "ISBN";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(198, 279);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 20);
            this.name.TabIndex = 7;
            this.name.Tag = "name";
            // 
            // author_name
            // 
            this.author_name.Location = new System.Drawing.Point(198, 362);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(197, 20);
            this.author_name.TabIndex = 8;
            this.author_name.Tag = "author_name";
            // 
            // publication_year
            // 
            this.publication_year.Location = new System.Drawing.Point(197, 444);
            this.publication_year.Name = "publication_year";
            this.publication_year.Size = new System.Drawing.Size(197, 20);
            this.publication_year.TabIndex = 9;
            this.publication_year.Tag = "publication_year";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDone.Enabled = false;
            this.btnDone.FlatAppearance.BorderSize = 3;
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(373, 529);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(122, 49);
            this.btnDone.TabIndex = 12;
            this.btnDone.Tag = "done";
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // rbInStock
            // 
            this.rbInStock.AutoSize = true;
            this.rbInStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbInStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInStock.Location = new System.Drawing.Point(8, 32);
            this.rbInStock.Name = "rbInStock";
            this.rbInStock.Size = new System.Drawing.Size(81, 22);
            this.rbInStock.TabIndex = 13;
            this.rbInStock.TabStop = true;
            this.rbInStock.Text = "In Stock";
            this.rbInStock.UseVisualStyleBackColor = true;
            // 
            // rbBorrowed
            // 
            this.rbBorrowed.AutoSize = true;
            this.rbBorrowed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBorrowed.Location = new System.Drawing.Point(8, 59);
            this.rbBorrowed.Name = "rbBorrowed";
            this.rbBorrowed.Size = new System.Drawing.Size(94, 22);
            this.rbBorrowed.TabIndex = 14;
            this.rbBorrowed.TabStop = true;
            this.rbBorrowed.Text = "Borrowed";
            this.rbBorrowed.UseVisualStyleBackColor = true;
            // 
            // rbNovel
            // 
            this.rbNovel.AutoSize = true;
            this.rbNovel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNovel.Location = new System.Drawing.Point(8, 26);
            this.rbNovel.Name = "rbNovel";
            this.rbNovel.Size = new System.Drawing.Size(65, 22);
            this.rbNovel.TabIndex = 16;
            this.rbNovel.TabStop = true;
            this.rbNovel.Text = "Novel";
            this.rbNovel.UseVisualStyleBackColor = true;
            // 
            // rbScienceFiction
            // 
            this.rbScienceFiction.AutoSize = true;
            this.rbScienceFiction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbScienceFiction.Location = new System.Drawing.Point(8, 56);
            this.rbScienceFiction.Name = "rbScienceFiction";
            this.rbScienceFiction.Size = new System.Drawing.Size(134, 22);
            this.rbScienceFiction.TabIndex = 17;
            this.rbScienceFiction.TabStop = true;
            this.rbScienceFiction.Text = "Science Fiction";
            this.rbScienceFiction.UseVisualStyleBackColor = true;
            // 
            // rbHistory
            // 
            this.rbHistory.AutoSize = true;
            this.rbHistory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHistory.Location = new System.Drawing.Point(8, 86);
            this.rbHistory.Name = "rbHistory";
            this.rbHistory.Size = new System.Drawing.Size(74, 22);
            this.rbHistory.TabIndex = 18;
            this.rbHistory.TabStop = true;
            this.rbHistory.Text = "History";
            this.rbHistory.UseVisualStyleBackColor = true;
            // 
            // rbBiography
            // 
            this.rbBiography.AutoSize = true;
            this.rbBiography.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBiography.Location = new System.Drawing.Point(8, 116);
            this.rbBiography.Name = "rbBiography";
            this.rbBiography.Size = new System.Drawing.Size(97, 22);
            this.rbBiography.TabIndex = 19;
            this.rbBiography.TabStop = true;
            this.rbBiography.Text = "Biography";
            this.rbBiography.UseVisualStyleBackColor = true;
            // 
            // rbKids
            // 
            this.rbKids.AutoSize = true;
            this.rbKids.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKids.Location = new System.Drawing.Point(8, 146);
            this.rbKids.Name = "rbKids";
            this.rbKids.Size = new System.Drawing.Size(58, 22);
            this.rbKids.TabIndex = 20;
            this.rbKids.TabStop = true;
            this.rbKids.Text = "Kids";
            this.rbKids.UseVisualStyleBackColor = true;
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.rbNovel);
            this.gbCategory.Controls.Add(this.rbKids);
            this.gbCategory.Controls.Add(this.rbScienceFiction);
            this.gbCategory.Controls.Add(this.rbBiography);
            this.gbCategory.Controls.Add(this.rbHistory);
            this.gbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCategory.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategory.ForeColor = System.Drawing.Color.White;
            this.gbCategory.Location = new System.Drawing.Point(469, 168);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(201, 190);
            this.gbCategory.TabIndex = 21;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Category";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryTDD.Properties.Resources.closewhite;
            this.pictureBox2.Location = new System.Drawing.Point(-11, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryTDD.Properties.Resources.bookwhite;
            this.pictureBox1.Location = new System.Drawing.Point(662, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // gbAvailability
            // 
            this.gbAvailability.Controls.Add(this.rbInStock);
            this.gbAvailability.Controls.Add(this.rbBorrowed);
            this.gbAvailability.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAvailability.ForeColor = System.Drawing.Color.White;
            this.gbAvailability.Location = new System.Drawing.Point(469, 364);
            this.gbAvailability.Name = "gbAvailability";
            this.gbAvailability.Size = new System.Drawing.Size(201, 100);
            this.gbAvailability.TabIndex = 22;
            this.gbAvailability.TabStop = false;
            this.gbAvailability.Text = "Availability";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(867, 621);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gbAvailability);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.publication_year);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.name);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AddBook";
            this.Text = "Add Book";
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAvailability.ResumeLayout(false);
            this.gbAvailability.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox author_name;
        private System.Windows.Forms.TextBox publication_year;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.RadioButton rbInStock;
        private System.Windows.Forms.RadioButton rbBorrowed;
        private System.Windows.Forms.RadioButton rbNovel;
        private System.Windows.Forms.RadioButton rbScienceFiction;
        private System.Windows.Forms.RadioButton rbHistory;
        private System.Windows.Forms.RadioButton rbBiography;
        private System.Windows.Forms.RadioButton rbKids;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbAvailability;
    }
}