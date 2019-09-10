using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoDominos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Draw tools
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush RedBrush = new SolidBrush(Color.Red);
            Font drawFont = new Font("Futura BdCn BT", 20, FontStyle.Bold);
            Font drawFont2 = new Font("Arial", 8, FontStyle.Bold); 
            Pen drawPen2 = new Pen(Color.Blue, 10);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush BlueBrush = new SolidBrush(Color.Blue);

            //Text Code 1
            g.TranslateTransform(495, 290);
            g.RotateTransform(310);
            g.DrawString("Domino's Pizza", drawFont, RedBrush, new Rectangle());
            g.ResetTransform();

            //Text Code 2
            g.TranslateTransform(605, 180);
            g.RotateTransform(310);
            g.DrawString("TM", drawFont2, RedBrush, new Rectangle());
            g.ResetTransform();

            //Red Square with dot
            g.TranslateTransform(200, 50);
            g.RotateTransform(310);
            g.FillRectangle(RedBrush, 100, 250, 120, 120);
            g.FillEllipse(whiteBrush, 140, 290, 40, 40);
            g.ResetTransform();

            //Blue Square with 2 dots
            g.TranslateTransform(0, 0);
            g.RotateTransform(310);
            g.FillRectangle(BlueBrush, 65, 435, 120, 120);
            g.ResetTransform();
            g.FillEllipse(whiteBrush, 407, 200, 40, 40);
            g.FillEllipse(whiteBrush, 465, 200, 40, 40);
            g.ResetTransform();

            //Comment for Git
        }
    }
}
