using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysis2
{
    class Classes
    {
        private int m_linesOfCode = 0;
        private System.Collections.ArrayList m_classNames = new System.Collections.ArrayList();

        public void ReadFromFile(string fullPath)
        {
            try
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(fullPath);
                int nameStart;
                string oneline;

                while ((oneline = reader.ReadLine()) != null)
                {
                    oneline = oneline.Trim();
                    //Don't count blank or comment lines.
                    if ((oneline != "") && (!oneline.StartsWith("//")))
                    {
                        m_linesOfCode++;
                    }

                    if (oneline.StartsWith("public class"))
                    {
                        nameStart = oneline.IndexOf("class") + 6;
                        char[] separators = { ' ', '\t', '{' };
                        string[] names = oneline.Substring(nameStart).Trim().Split(separators);
                        string className = names[0].Trim();
                        m_classNames.Add(new AClass(className, fullPath));
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new System.Exception("Problems parsing source file: " + ex.Message);
            }
        }

        public AClass this[int indexer]
        {
            get
            {
                if ((indexer >= 0) && (indexer < m_classNames.Count))
                {
                    return (AClass)m_classNames[indexer];
                }
                else
                {
                    throw new System.Exception("Index must be between 0 and " + m_classNames.Count.ToString() + ".");
                }
            }
        }

        public int LinesOfCode
        {
            get { return m_linesOfCode; }
        }

        public int Count
        {
            get { return m_classNames.Count; }
        }
    }
}
