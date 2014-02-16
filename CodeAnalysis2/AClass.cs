using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysis2
{
    class AClass
    {
        private int m_linesOfCode = 0;
        private System.Collections.ArrayList m_classNames = new System.Collections.ArrayList();
            
        public AClass(string name, string filename)
        {
            m_name = name;
            m_fielname = filename;
        }

        string m_name;
        public string Name
        {
            get { return m_name; }
        }

        string m_fielname;
        public string FileName
        {
            get { return m_fielname; }
        }

    }
}
