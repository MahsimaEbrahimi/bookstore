namespace bookstore
{
    partial class Form1
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
            this.txtBook_name = new System.Windows.Forms.TextBox();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.txtBook_ID = new System.Windows.Forms.TextBox();
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_count_books = new System.Windows.Forms.Label();
            this.lbl_number_books = new System.Windows.Forms.Label();
            this.btn_show_all_books = new System.Windows.Forms.Button();
            this.lbl_all_books = new System.Windows.Forms.Label();
            this.lbl_show_name_of_books = new System.Windows.Forms.Label();
            this.btn_Search_books = new System.Windows.Forms.Button();
            this.lbl_book_author = new System.Windows.Forms.Label();
            this.txt_book_author = new System.Windows.Forms.TextBox();
            this.btn_show_count_books = new System.Windows.Forms.Button();
            this.btn_delete_book = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBook_name
            // 
            this.txtBook_name.Location = new System.Drawing.Point(121, 47);
            this.txtBook_name.Name = "txtBook_name";
            this.txtBook_name.Size = new System.Drawing.Size(167, 22);
            this.txtBook_name.TabIndex = 0;
            // 
            // btn_add_book
            // 
            this.btn_add_book.Location = new System.Drawing.Point(110, 290);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(139, 42);
            this.btn_add_book.TabIndex = 1;
            this.btn_add_book.Text = "اضافه کردن کتاب";
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBook_ID
            // 
            this.txtBook_ID.Location = new System.Drawing.Point(121, 91);
            this.txtBook_ID.Name = "txtBook_ID";
            this.txtBook_ID.Size = new System.Drawing.Size(167, 22);
            this.txtBook_ID.TabIndex = 2;
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoSize = true;
            this.lbl_book_name.Location = new System.Drawing.Point(308, 51);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(49, 17);
            this.lbl_book_name.TabIndex = 3;
            this.lbl_book_name.Text = "نام کتاب ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "شناسه کتاب";
            // 
            // lbl_count_books
            // 
            this.lbl_count_books.AutoSize = true;
            this.lbl_count_books.Location = new System.Drawing.Point(308, 180);
            this.lbl_count_books.Name = "lbl_count_books";
            this.lbl_count_books.Size = new System.Drawing.Size(55, 17);
            this.lbl_count_books.TabIndex = 6;
            this.lbl_count_books.Text = "تعداد کتاب";
            // 
            // lbl_number_books
            // 
            this.lbl_number_books.AutoSize = true;
            this.lbl_number_books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_number_books.Location = new System.Drawing.Point(233, 180);
            this.lbl_number_books.Name = "lbl_number_books";
            this.lbl_number_books.Size = new System.Drawing.Size(0, 17);
            this.lbl_number_books.TabIndex = 7;
            // 
            // btn_show_all_books
            // 
            this.btn_show_all_books.Location = new System.Drawing.Point(110, 428);
            this.btn_show_all_books.Name = "btn_show_all_books";
            this.btn_show_all_books.Size = new System.Drawing.Size(139, 40);
            this.btn_show_all_books.TabIndex = 9;
            this.btn_show_all_books.Text = "نمایش همه کتاب ها";
            this.btn_show_all_books.UseVisualStyleBackColor = true;
            this.btn_show_all_books.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_all_books
            // 
            this.lbl_all_books.AutoSize = true;
            this.lbl_all_books.Location = new System.Drawing.Point(308, 232);
            this.lbl_all_books.Name = "lbl_all_books";
            this.lbl_all_books.Size = new System.Drawing.Size(94, 17);
            this.lbl_all_books.TabIndex = 10;
            this.lbl_all_books.Text = "اسامی همه کتاب ها";
            // 
            // lbl_show_name_of_books
            // 
            this.lbl_show_name_of_books.Location = new System.Drawing.Point(92, 232);
            this.lbl_show_name_of_books.Name = "lbl_show_name_of_books";
            this.lbl_show_name_of_books.Size = new System.Drawing.Size(185, 51);
            this.lbl_show_name_of_books.TabIndex = 11;
            // 
            // btn_Search_books
            // 
            this.btn_Search_books.Location = new System.Drawing.Point(110, 474);
            this.btn_Search_books.Name = "btn_Search_books";
            this.btn_Search_books.Size = new System.Drawing.Size(139, 40);
            this.btn_Search_books.TabIndex = 12;
            this.btn_Search_books.Text = "جستجو کتاب";
            this.btn_Search_books.UseVisualStyleBackColor = true;
            this.btn_Search_books.Click += new System.EventHandler(this.btn_Search_books_Click);
            // 
            // lbl_book_author
            // 
            this.lbl_book_author.AutoSize = true;
            this.lbl_book_author.Location = new System.Drawing.Point(308, 136);
            this.lbl_book_author.Name = "lbl_book_author";
            this.lbl_book_author.Size = new System.Drawing.Size(66, 17);
            this.lbl_book_author.TabIndex = 14;
            this.lbl_book_author.Text = "نویسنده کتاب";
            // 
            // txt_book_author
            // 
            this.txt_book_author.Location = new System.Drawing.Point(121, 131);
            this.txt_book_author.Name = "txt_book_author";
            this.txt_book_author.Size = new System.Drawing.Size(167, 22);
            this.txt_book_author.TabIndex = 13;
            // 
            // btn_show_count_books
            // 
            this.btn_show_count_books.Location = new System.Drawing.Point(110, 382);
            this.btn_show_count_books.Name = "btn_show_count_books";
            this.btn_show_count_books.Size = new System.Drawing.Size(139, 40);
            this.btn_show_count_books.TabIndex = 8;
            this.btn_show_count_books.Text = "نمایش تعداد کتاب";
            this.btn_show_count_books.UseVisualStyleBackColor = true;
            this.btn_show_count_books.Click += new System.EventHandler(this.btn_show_count_books_Click);
            // 
            // btn_delete_book
            // 
            this.btn_delete_book.Location = new System.Drawing.Point(110, 338);
            this.btn_delete_book.Name = "btn_delete_book";
            this.btn_delete_book.Size = new System.Drawing.Size(139, 38);
            this.btn_delete_book.TabIndex = 5;
            this.btn_delete_book.Text = "حذف کتاب ";
            this.btn_delete_book.UseVisualStyleBackColor = true;
            this.btn_delete_book.Click += new System.EventHandler(this.btn_delete_book_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 590);
            this.Controls.Add(this.lbl_book_author);
            this.Controls.Add(this.txt_book_author);
            this.Controls.Add(this.btn_Search_books);
            this.Controls.Add(this.lbl_show_name_of_books);
            this.Controls.Add(this.lbl_all_books);
            this.Controls.Add(this.btn_show_all_books);
            this.Controls.Add(this.btn_show_count_books);
            this.Controls.Add(this.lbl_number_books);
            this.Controls.Add(this.lbl_count_books);
            this.Controls.Add(this.btn_delete_book);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_book_name);
            this.Controls.Add(this.txtBook_ID);
            this.Controls.Add(this.btn_add_book);
            this.Controls.Add(this.txtBook_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBook_name;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.TextBox txtBook_ID;
        private System.Windows.Forms.Label lbl_book_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_count_books;
        private System.Windows.Forms.Label lbl_number_books;
        private System.Windows.Forms.Button btn_show_all_books;
        private System.Windows.Forms.Label lbl_all_books;
        private System.Windows.Forms.Label lbl_show_name_of_books;
        private System.Windows.Forms.Button btn_Search_books;
        private System.Windows.Forms.Label lbl_book_author;
        private System.Windows.Forms.TextBox txt_book_author;
        private System.Windows.Forms.Button btn_show_count_books;
        private System.Windows.Forms.Button btn_delete_book;
    }
}

