using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterLibrary
{
    class Book
    {
        private string m_text;
        private string m_title;

        public string Title
        {
            get { return m_title; }
        }

        public string Text
        {
            get { return m_text; }
        }

        public Book(string title, string text)
        {
            m_text = text;
            m_title = title;
        }
    }
}
