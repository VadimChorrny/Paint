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
        #region 
        private Color color = Color.Black; // default color
        private int size = 5;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Colors Set Buttons
        /// </summary>

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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label lbl = new Label();
                lbl.BackColor = color;
                lbl.Size = new Size(size,size);
                lbl.Location = e.Location;
                lbl.BringToFront();
                this.panel1.Controls.Add(lbl);
            }
        }

        private void btnSizePlus_Click(object sender, EventArgs e)
        {
            if (size <= 100)
                size++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (size > 0)
                size--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
        }
    }
}
