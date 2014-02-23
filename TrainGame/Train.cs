using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainGame
{
    [System.ComponentModel.DefaultEvent("DistanceChanged")]
    public partial class Train : UserControl
    {
        public Train()
        {
            InitializeComponent();
        }

        private int speed = 0;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value >= 0)
                {
                    speed = value;
                }
            }
        }

        private int distance = 0;
        public int Distance
        {
            get { return distance; }
        }

        public void ReStart()
        {
            distance = 0;
        }

        public delegate void DistanceChangedEventHandler(object sender, DistanceChangedEventArgs e);

        public event DistanceChangedEventHandler DistanceChanged;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (speed > 0)
            {
                distance += (int)((double)speed * ((double)timer1.Interval / 1000F));
                if (DistanceChanged != null)
                {
                    DistanceChanged(this, new DistanceChangedEventArgs(distance));
                }
            }
        }
    }

    public class DistanceChangedEventArgs : System.EventArgs
    {
        private int distance;
        public int Distance
        {
            get { return distance; }
        }

        public DistanceChangedEventArgs(int distance)
        {
            this.distance = distance;
        }
    }
}
