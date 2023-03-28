using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace bookstore
{

    public class bookstore
    {
    public ArrayList Book_list= new ArrayList();
        public void book_add(book book_instance)
        {
            Book_list.Add(book_instance);
        }
        public string Show_books()
        {
            string b1 = "";
            if (Book_list.Count<1)
             {
                    MessageBox.Show("there is no books, number of books are 0");
             }
            foreach (book b in Book_list)
            {
                b1 = b1 + b.getName()+"\r\n";

            }

            return b1;
        }
        public int Book_Count()
        {
            return Book_list.Count;
        }
        public bool validity(book book_instance_validity)
        {

            foreach (book b in Book_list)
            {
                if (book_instance_validity.getName()==b.getName())
                {
                    if(book_instance_validity.getID()==b.getID())
                    {
                        MessageBox.Show("cant add book, its repetitive");
                        return false;
                    }
                }
            }
            return true;
        }

        public string search(string name_search, string id_search)
        {
           foreach (book b in Book_list)
            {
                if(b.getName()==name_search)
                {
                    return "book found" + b.getName() + b.getID() + b.getBook_author();
                }
            }
            return null;
        }
    }
}
