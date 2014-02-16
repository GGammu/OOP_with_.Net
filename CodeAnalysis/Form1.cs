using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAnalysis
{
    public partial class Form1 : Form
    {
        private const int MaxFiles = 10;
        private SourceFile[] m_sourceFiles = new SourceFile[MaxFiles];
        private int m_files = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listOfFiles.DataSource = m_sourceFiles;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            try
            {
                openSourceFile.Filter = "Visual C# files (*.cs)|*.cs";
                System.Windows.Forms.DialogResult result;
                result = openSourceFile.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    SourceFile aFile = new SourceFile(openSourceFile.FileName);
                    m_sourceFiles[m_files++] = aFile;
                    if (m_files == m_sourceFiles.Length)
                    {
                        m_files = m_sourceFiles.Length - 1;
                    }
                }

                listOfFiles.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            int row = listOfFiles.CurrentCell.RowIndex;
            if (row < m_files)
            {
                SourceFile theFile = m_sourceFiles[row];
                string message = "";
                for (int index = 0; index < theFile.ClassCount; index++)
                {
                    message += theFile.GetClass(index) + "\n";
                }
                MessageBox.Show(message, "Classes in " + theFile.FileName);
            }
            else
            {
                MessageBox.Show("Please select a row with data.");
            }
        }
    }

}
