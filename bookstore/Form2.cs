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
    public partial class Form2 : Form
    {
        bookstore BOok_Store_instance2;
        public Form2(bookstore b)
        {
            InitializeComponent();
            BOok_Store_instance2 = b;
        }

        private void btn_Search_books_frm2_Click_1(object sender, EventArgs e)
        {
            lbl_search_result.Text = BOok_Store_instance2.search(txtBook_name_search.Text.ToString(), txtBook_ID_search.Text.ToString());
        }
    }
}
