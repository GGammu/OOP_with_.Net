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

        public Book(string title, string text)
        {
            if ((title != "") && (text != "") && (title != null) && (text != null))
            {
                m_title = title;
                m_text = text;
            }
            else
            {
                throw new Exception("Title or text is an empty string.");
            }
        }

        //public string Text = "";
        public int PageLength = 10;

        private string m_title;
        private string m_text = "";

        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }

        public string Text
        {
            get { return m_text; }
            set { m_text = value; }
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

        public override string ToString()
        {
            return m_title;
        }
    }
}
