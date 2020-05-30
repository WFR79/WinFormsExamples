using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    //the modified button class looks like this

    class TbExt : System.Windows.Forms.TextBox
    {
        //we can use this to modify the color of the border 
        public Color BorderColor = Color.LightGray;
        //we can use this to modify the border size
        public int BorderSize = 5;
        public TbExt()
        {
            //FlatStyle = FlatStyle.Flat;
            //BackColor = Color.White;
            //FlatAppearance.BorderColor = BorderColor;
            //FlatAppearance.BorderSize = BorderSize;
            //Font = new System.Drawing.Font("VAGRounded-Light",
            //30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            //ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))),
            //        ((int)(((byte)(33)))), ((int)(((byte)(107)))));

            //this.MouseDown += new MouseEventHandler(ButtonLastest_MouseDown);
            //this.MouseUp += new MouseEventHandler(ButtonLastest_MouseUp);
        }

        protected override void OnEnter(System.EventArgs e)
        {
            TextBox tb = this;
            tb.AutoSize = false;    
            tb.BorderStyle = BorderStyle.Fixed3D;
            tb.Font = new Font("Arial", 8.5f);

            Point locationTb = tb.Location;
            int width = tb.Width + 5;
            var heigh = tb.Height + 5;
            int difWidth = tb.Width - width;
            int difheigh = tb.Height - heigh;

            tb.Size = new System.Drawing.Size(width, heigh);
            locationTb.X = locationTb.X + difWidth / 2;
            locationTb.Y = locationTb.Y + difheigh / 2;

            //defaultlocationTb = locationTb;
            tb.Location = locationTb;
        }

        protected override void OnLeave(EventArgs pevent)
        {
            // to draw the control using base OnPaint

        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            // to draw the control using base OnPaint

        }


    }
}
