using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMoreBooks
{
    class Library
    {
        private SortedList m_shelf = new SortedList();

        public Library()
        {
            //TODO: Add constructor logic here
        }

        public  void CheckIn(Book newBook)
        {
            m_shelf.Add(newBook.Title, newBook);
        }

        public Book CheckOut(string title)
        {
            Book theBook;
            theBook = (Book)m_shelf[title];
            m_shelf.Remove(title);
            return theBook;
        }
    }
}
