using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Track1_CaughtOnFire(object sender, CaughtOnFireEventArgs e)
        {
            fire.Location = new System.Drawing.Point(Track1.Left + e.Location, Track1.Top - fire.Height);
        }
    }
}
