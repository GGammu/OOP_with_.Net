using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterLibrary
{
    class Library
    {
        private BookCollection m_shelf = new BookCollection();

        public Library()
        {
        }

        public void CheckIn(Book newBook)
        {
            m_shelf.Add(newBook);
        }

        public Book CheckOut(string title)
        {
            Book theBook = m_shelf[title];
            m_shelf.Remove(title);
            return theBook;
        }

        //public static void Main()
        //{
        //    Library aLibrary = new Library();
        //    aLibrary.CheckIn(new Book("First Book", "Here is the text of the first book."));
        //    aLibrary.CheckIn(new Book("Second Book", "Here is the text of the Second book."));
        //    Book firstBook = aLibrary.CheckOut("First Book");
        //    Console.WriteLine("The text of '{0}' is '{1}'.", firstBook.Title, firstBook.Text);
        //    aLibrary.CheckIn(firstBook);
        //}
    }
}
