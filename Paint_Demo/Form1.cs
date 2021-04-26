using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Demo
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        #region property
        private Color color = Color.Black; // default color
        private int size = 5; // size pen
        private int sizeFirstSide = 3;
        private int sizeSecondSide = 3;
        private int sizeThirdSide = 3;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region setting button
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnPlusFirstSideTriangle_Click(object sender, EventArgs e)
        {
            sizeFirstSide++;
        }
        private void btnPlusSecondSideTriangle_Click(object sender, EventArgs e)
        {
            sizeSecondSide++;
        }
        private void btnPlusThirdSideTriangle_Click(object sender, EventArgs e)
        {
            sizeThirdSide++;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            sizeFirstSide = 0;
            sizeSecondSide = 0;
            sizeThirdSide = 0;
        }
        private void btnBlue_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
        }
        private void btnYellow_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
        }
        private void btnRed_Click(object sender, EventArgs e)
        {
            color = Color.Red;
        }
        private void btnGreen_Click(object sender, EventArgs e)
        {
            color = Color.Green;
        }
        private void btnFuchsia_Click(object sender, EventArgs e)
        {
            color = Color.Fuchsia;
        }
        private void btnSilver_Click(object sender, EventArgs e)
        {
            color = Color.Silver;
        }
        private void btnAqua_Click(object sender, EventArgs e)
        {
            color = Color.Aqua;
        }
        private void btnWhiteRed_Click(object sender, EventArgs e)
        {
            color = Color.PaleVioletRed;
        }
        private void btnMediaAqua_Click(object sender, EventArgs e)
        {
            color = Color.MediumAquamarine;
        }
        private void btnDarkRed_Click(object sender, EventArgs e)
        {
            color = Color.DarkRed;
        }
        private void btnWhiteBlue_Click(object sender, EventArgs e)
        {
            color = Color.BlueViolet;
        }
        private void btnDarkWhite_Click(object sender, EventArgs e)
        {
            color = Color.WhiteSmoke;
        }
        #endregion

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
           if (e.Button == MouseButtons.Left)
           {
               Label lbl = new Label();
               lbl.BackColor = color;
               lbl.Size = new Size(size, size);
               lbl.Location = e.Location;
               lbl.BringToFront();
               this.panel1.Controls.Add(lbl);
           }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (size <= 100)
                size++;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (size > 0)
                size--;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DrawTriangle();

        }
        private void DrawTriangle()
        {
            Graphics j = this.CreateGraphics();
            j.DrawLine(new Pen(Color.Red, sizeFirstSide), 200, 200, 400, 400);
            Graphics u = this.CreateGraphics();
            u.DrawLine(new Pen(Color.Red, sizeSecondSide), 400, 400, 600, 60);
            Graphics y = this.CreateGraphics();
            y.DrawLine(new Pen(Color.Red, sizeThirdSide), 600, 60, 200, 200);
        }


    }
}
