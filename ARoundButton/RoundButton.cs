using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARoundButton
{
    public partial class RoundButton: Button
    {
        public RoundButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.Size = new Size(50, 50);
            System.Drawing.Drawing2D.GraphicsPath aCircle = new System.Drawing.Drawing2D.GraphicsPath();
            aCircle.AddEllipse(new System.Drawing.RectangleF(0, 0, 50, 50));
            this.Region = new Region(aCircle);
            base.OnPaint(pevent); 
        }
    }
}
