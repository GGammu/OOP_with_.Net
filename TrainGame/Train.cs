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

        private int m_speed = 0;
        public int Speed
        {
            get { return m_speed; }
            set 
            {
                if (value >=0 )
                {
                    m_speed = value;
                }
            }
        }

        private int m_distance = 0;
        public int Distance
        {
            get { return m_distance; }
        }

        public void ReStart()
        {
            m_distance = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m_speed > 0)
            {
                m_distance += (int)((double)m_speed * ((double)timer1.Interval / 1000F));
                if (DistanceChanged != null)
                {
                    DistanceChanged(sender, new DistanceChangedEventArgs(m_distance));
                }
            }
        }

        public delegate void DistanceChangedEventHandler(object sender, DistanceChangedEventArgs e);

        public DistanceChangedEventHandler DistanceChanged;
    }

    public class DistanceChangedEventArgs : System.EventArgs
    {
        private int m_distance;
        public int Distance
        {
            get { return m_distance; }
        }

        public DistanceChangedEventArgs(int distance)
        {
            m_distance = distance;
        }
    }
}
