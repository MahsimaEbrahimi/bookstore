using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore
{
    public class book
    {
        private string book_name;
        private string book_id;
        private string book_author;

        public string getBook_author()
        {
            return book_author;
        }
        public void set_Book_author(string author)
        {
            book_author = author;
        }
        public string getName()
        {
            return book_name;
        }
        public void setName(string name)
        {
            book_name = name;
        }
        public string getID()
        {
            return book_id;
        }
        public void setID(string id)
        {
            book_id = id;
        }
        public book (string book_name,string book_id,string book_author)
        {
            this.setName(book_name);
            this.setID(book_id);
            this.set_Book_author(book_author);
        }
    }
}
