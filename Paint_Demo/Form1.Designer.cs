
namespace Paint_Demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnDarkWhite = new System.Windows.Forms.Button();
            this.btnWhiteBlue = new System.Windows.Forms.Button();
            this.btnDarkRed = new System.Windows.Forms.Button();
            this.btnMediaAqua = new System.Windows.Forms.Button();
            this.btnWhiteRed = new System.Windows.Forms.Button();
            this.btnAqua = new System.Windows.Forms.Button();
            this.btnSilver = new System.Windows.Forms.Button();
            this.btnFuchsia = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPlusFirstSideTriangle = new System.Windows.Forms.Button();
            this.btnPlusSecondSideTriangle = new System.Windows.Forms.Button();
            this.btnPlusThirdSideTriangle = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(148, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(12, 12);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(34, 34);
            this.btnBlue.TabIndex = 0;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnDarkWhite
            // 
            this.btnDarkWhite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDarkWhite.Location = new System.Drawing.Point(92, 132);
            this.btnDarkWhite.Name = "btnDarkWhite";
            this.btnDarkWhite.Size = new System.Drawing.Size(34, 34);
            this.btnDarkWhite.TabIndex = 1;
            this.btnDarkWhite.UseVisualStyleBackColor = false;
            this.btnDarkWhite.Click += new System.EventHandler(this.btnDarkWhite_Click);
            // 
            // btnWhiteBlue
            // 
            this.btnWhiteBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWhiteBlue.Location = new System.Drawing.Point(52, 132);
            this.btnWhiteBlue.Name = "btnWhiteBlue";
            this.btnWhiteBlue.Size = new System.Drawing.Size(34, 34);
            this.btnWhiteBlue.TabIndex = 2;
            this.btnWhiteBlue.UseVisualStyleBackColor = false;
            this.btnWhiteBlue.Click += new System.EventHandler(this.btnWhiteBlue_Click);
            // 
            // btnDarkRed
            // 
            this.btnDarkRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDarkRed.Location = new System.Drawing.Point(12, 132);
            this.btnDarkRed.Name = "btnDarkRed";
            this.btnDarkRed.Size = new System.Drawing.Size(34, 34);
            this.btnDarkRed.TabIndex = 3;
            this.btnDarkRed.UseVisualStyleBackColor = false;
            this.btnDarkRed.Click += new System.EventHandler(this.btnDarkRed_Click);
            // 
            // btnMediaAqua
            // 
            this.btnMediaAqua.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMediaAqua.Location = new System.Drawing.Point(92, 92);
            this.btnMediaAqua.Name = "btnMediaAqua";
            this.btnMediaAqua.Size = new System.Drawing.Size(34, 34);
            this.btnMediaAqua.TabIndex = 4;
            this.btnMediaAqua.UseVisualStyleBackColor = false;
            this.btnMediaAqua.Click += new System.EventHandler(this.btnMediaAqua_Click);
            // 
            // btnWhiteRed
            // 
            this.btnWhiteRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWhiteRed.Location = new System.Drawing.Point(52, 92);
            this.btnWhiteRed.Name = "btnWhiteRed";
            this.btnWhiteRed.Size = new System.Drawing.Size(34, 34);
            this.btnWhiteRed.TabIndex = 5;
            this.btnWhiteRed.UseVisualStyleBackColor = false;
            this.btnWhiteRed.Click += new System.EventHandler(this.btnWhiteRed_Click);
            // 
            // btnAqua
            // 
            this.btnAqua.BackColor = System.Drawing.Color.Aqua;
            this.btnAqua.Location = new System.Drawing.Point(12, 92);
            this.btnAqua.Name = "btnAqua";
            this.btnAqua.Size = new System.Drawing.Size(34, 34);
            this.btnAqua.TabIndex = 6;
            this.btnAqua.UseVisualStyleBackColor = false;
            this.btnAqua.Click += new System.EventHandler(this.btnAqua_Click);
            // 
            // btnSilver
            // 
            this.btnSilver.BackColor = System.Drawing.Color.Silver;
            this.btnSilver.Location = new System.Drawing.Point(92, 52);
            this.btnSilver.Name = "btnSilver";
            this.btnSilver.Size = new System.Drawing.Size(34, 34);
            this.btnSilver.TabIndex = 7;
            this.btnSilver.UseVisualStyleBackColor = false;
            this.btnSilver.Click += new System.EventHandler(this.btnSilver_Click);
            // 
            // btnFuchsia
            // 
            this.btnFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.btnFuchsia.Location = new System.Drawing.Point(52, 52);
            this.btnFuchsia.Name = "btnFuchsia";
            this.btnFuchsia.Size = new System.Drawing.Size(34, 34);
            this.btnFuchsia.TabIndex = 8;
            this.btnFuchsia.UseVisualStyleBackColor = false;
            this.btnFuchsia.Click += new System.EventHandler(this.btnFuchsia_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(92, 12);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(34, 34);
            this.btnRed.TabIndex = 9;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(12, 52);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(34, 34);
            this.btnGreen.TabIndex = 10;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(52, 12);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(34, 34);
            this.btnYellow.TabIndex = 11;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.SystemColors.Control;
            this.pbAdd.Image = global::Paint_Demo.Properties.Resources.add;
            this.pbAdd.Location = new System.Drawing.Point(12, 172);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(114, 37);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 0;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::Paint_Demo.Properties.Resources.minus;
            this.pictureBox1.Location = new System.Drawing.Point(12, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::Paint_Demo.Properties.Resources.triangle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnPlusFirstSideTriangle
            // 
            this.btnPlusFirstSideTriangle.Location = new System.Drawing.Point(12, 319);
            this.btnPlusFirstSideTriangle.Name = "btnPlusFirstSideTriangle";
            this.btnPlusFirstSideTriangle.Size = new System.Drawing.Size(28, 30);
            this.btnPlusFirstSideTriangle.TabIndex = 0;
            this.btnPlusFirstSideTriangle.Text = "1";
            this.btnPlusFirstSideTriangle.UseVisualStyleBackColor = true;
            this.btnPlusFirstSideTriangle.Click += new System.EventHandler(this.btnPlusFirstSideTriangle_Click);
            // 
            // btnPlusSecondSideTriangle
            // 
            this.btnPlusSecondSideTriangle.Location = new System.Drawing.Point(36, 319);
            this.btnPlusSecondSideTriangle.Name = "btnPlusSecondSideTriangle";
            this.btnPlusSecondSideTriangle.Size = new System.Drawing.Size(34, 30);
            this.btnPlusSecondSideTriangle.TabIndex = 13;
            this.btnPlusSecondSideTriangle.Text = "2";
            this.btnPlusSecondSideTriangle.UseVisualStyleBackColor = true;
            this.btnPlusSecondSideTriangle.Click += new System.EventHandler(this.btnPlusSecondSideTriangle_Click);
            // 
            // btnPlusThirdSideTriangle
            // 
            this.btnPlusThirdSideTriangle.Location = new System.Drawing.Point(64, 319);
            this.btnPlusThirdSideTriangle.Name = "btnPlusThirdSideTriangle";
            this.btnPlusThirdSideTriangle.Size = new System.Drawing.Size(28, 30);
            this.btnPlusThirdSideTriangle.TabIndex = 14;
            this.btnPlusThirdSideTriangle.Text = "3";
            this.btnPlusThirdSideTriangle.UseVisualStyleBackColor = true;
            this.btnPlusThirdSideTriangle.Click += new System.EventHandler(this.btnPlusThirdSideTriangle_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(98, 319);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(28, 30);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "0";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlusThirdSideTriangle);
            this.Controls.Add(this.btnPlusSecondSideTriangle);
            this.Controls.Add(this.btnPlusFirstSideTriangle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnFuchsia);
            this.Controls.Add(this.btnSilver);
            this.Controls.Add(this.btnAqua);
            this.Controls.Add(this.btnWhiteRed);
            this.Controls.Add(this.btnMediaAqua);
            this.Controls.Add(this.btnDarkRed);
            this.Controls.Add(this.btnWhiteBlue);
            this.Controls.Add(this.btnDarkWhite);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Paint | Chorrny Inc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnDarkWhite;
        private System.Windows.Forms.Button btnWhiteBlue;
        private System.Windows.Forms.Button btnDarkRed;
        private System.Windows.Forms.Button btnMediaAqua;
        private System.Windows.Forms.Button btnWhiteRed;
        private System.Windows.Forms.Button btnAqua;
        private System.Windows.Forms.Button btnSilver;
        private System.Windows.Forms.Button btnFuchsia;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPlusFirstSideTriangle;
        private System.Windows.Forms.Button btnPlusSecondSideTriangle;
        private System.Windows.Forms.Button btnPlusThirdSideTriangle;
        private System.Windows.Forms.Button btnReset;
    }
}

