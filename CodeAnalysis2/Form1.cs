using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAnalysis2
{
    public partial class Form1 : Form
    {
        private Classes m_classes = new Classes();

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayClasses()
        {
            AClass[] classes = new AClass[m_classes.Count];
            for (int i = 0; i < m_classes.Count; i++)
            {
                //Using the indexer
                classes[i] = m_classes[i];
            }
            this.listOfFiles.DataSource = classes;
            linesOfCode.Text = "Lines of code: " + m_classes.LinesOfCode.ToString();
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
                    m_classes.ReadFromFile(openSourceFile.FileName);
                }
                DisplayClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
