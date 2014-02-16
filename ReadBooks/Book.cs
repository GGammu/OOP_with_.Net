using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMoreBooks
{
    ///<summary>
    ///Summary description for Book.
    ///</summary>
    class Book
    {
        public Book()
        {
            //
            //TODO: Add constructor logic here
            //
        }

        public string Text = "";
        public int PageLength = 10;
        private string m_title;

        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }

        public string GetPage(int pageNumber)
        {
            int start = (pageNumber - 1) * PageLength;
            if ((start < Text.Length) && (start >= 0))
            {
                if ((start + PageLength) < Text.Length)
                {
                    return Text.Substring(start, PageLength);
                }
                else
                {
                    return Text.Substring(start, Text.Length - start);
                }
            }
            else
            {
                return "";
            }
        }
    }
}
