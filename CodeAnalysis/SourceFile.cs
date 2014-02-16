using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysis
{
    class SourceFile
    {
        private string m_fullPath;
        private int m_linesOfcode;
        private string[] m_classNames;
        private int m_classCount;

        public SourceFile(string fullPath)
        {
            m_linesOfcode = 0;
            m_classNames = new string[10];
            m_classCount = 0;
            m_fullPath = fullPath;

            try
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(m_fullPath);
                int nameStart;
                string oneline;

                while ((oneline = reader.ReadLine()) != null)
                {
                    oneline = oneline.Trim();
                    //Don't count blank or comment lines.
                    if ((oneline != "") && (!oneline.StartsWith("//")))
                    {
                        m_linesOfcode++;
                    }

                    if (oneline.StartsWith("public class"))
                    {
                        nameStart = oneline.IndexOf("class") + 6;
                        char[] separators = {' ', '\t', '{'};
                        string[] names = oneline.Substring(nameStart).Trim().Split(separators);
                        string className = names[0].Trim();
                        m_classNames[m_classCount++] = className;
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Problems parsing source file: " + ex.Message);
            }
        }

        /// <summary>
        /// Returns the full path of the source file.
        /// </summary>
        public string FullPath
        {
            get { return m_fullPath; }
        }

        /// <summary>
        /// Returns the filename, without the path of the source file.
        /// </summary>
        public string FileName
        {
            get
            {
                int lastSlash = m_fullPath.LastIndexOf("\\");
                return m_fullPath.Substring(lastSlash + 1);
            }
        }

        /// <summary>
        /// The total number of classes defined in the source file.
        /// </summary>
        public int ClassCount
        {
            get
            {
                return m_classCount;
            }
        }

        /// <summary>
        /// Lines of code in the source file, excludeing blank and comment lines.
        /// </summary>
        public int LinesOfCode
        {
            get
            {
                return m_linesOfcode;
            }
        }

        /// <summary>
        /// Returns one of the names of the classes defined in the source file, based on an index.
        /// </summary>
        /// <param name="index">A zero-based index</param>
        /// <returns></returns>
        public string GetClass(int index)
        {
            if (index < m_classCount)
            {
                return m_classNames[index];
            }
            else
            {
                throw new System.IndexOutOfRangeException("There are only" + m_classCount + " classes defined.");
            }
        }
    }
}
