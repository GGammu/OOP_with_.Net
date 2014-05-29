using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThrowSystemException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            try
            {
                MessageBox.Show(numbers[9].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong:" + ex.Message);
            }
        }
    }
}
