using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterLibrary
{
    class BookCollection : System.Collections.DictionaryBase
    {
        public void Add(Book book)
        {
            this.Dictionary.Add(book.Title, book);
        }

        public void Remove(string title)
        {
            this.Dictionary.Remove(title);
        }

        public Book this[string title] 
        {
            get
            {
                if (this.Dictionary.Contains(title))
                {
                    return (Book)(this.Dictionary[title]);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
