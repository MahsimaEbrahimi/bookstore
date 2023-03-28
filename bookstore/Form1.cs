using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore
{
    public partial class Form1 : Form
    {
     bookstore BookStore = new bookstore();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add book to list
            book BOOK_INSTANCE = new book(txtBook_name.Text.ToString(),txtBook_ID.Text.ToString());
           if( BookStore.validity(BOOK_INSTANCE)==true)
            {
              BookStore.book_add(BOOK_INSTANCE);
            }
        }


        private void btn_show_count_books_Click(object sender, EventArgs e)
        {
            //show book counts
            lbl_number_books.Text=BookStore.Book_Count().ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //show name of all books
            lbl_show_name_of_books.Text = BookStore.Show_books();
        }

        private void btn_Search_books_Click(object sender, EventArgs e)
        {
            //search book
            Form2 frm2 = new Form2(BookStore);
            frm2.Show();
            
        }
    }
}
