using System;

namespace PrimijenjenaMatematika_DC.Forms
{
    partial class Matrix3x3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matrix3x3));
            this.Matrix3x3Component = new System.Windows.Forms.PictureBox();
            this.AnswerBoxImage = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix3x3Component)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Matrix3x3Component
            // 
            this.Matrix3x3Component.Image = ((System.Drawing.Image)(resources.GetObject("Matrix3x3Component.Image")));
            this.Matrix3x3Component.Location = new System.Drawing.Point(0, 0);
            this.Matrix3x3Component.Name = "Matrix3x3Component";
            this.Matrix3x3Component.Size = new System.Drawing.Size(801, 412);
            this.Matrix3x3Component.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Matrix3x3Component.TabIndex = 0;
            this.Matrix3x3Component.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = this.BackColor;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.textBox1.Location = new System.Drawing.Point(124, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 76);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.calculate3x3Determinant);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = this.BackColor;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.textBox2.Location = new System.Drawing.Point(324, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 76);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.calculate3x3Determinant);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = this.BackColor;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.textBox3.Location = new System.Drawing.Point(526, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 76);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.calculate3x3Determinant);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = this.BackColor;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.textBox4.Location = new System.Drawing.Point(124, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 76);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.calculate3x3Determinant);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = this.BackColor;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.textBox5.Location = new System.Drawing.Point(324, 160);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 76);
            this.textBox5.TabIndex = 14;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.calculate3x3Determinant);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = this.BackColor;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.textBox6.Location = new System.Drawing.Point(526, 160);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(158, 76);
            this.textBox6.TabIndex = 15;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.calculate3x3Determinant);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = this.BackColor;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.textBox7.Location = new System.Drawing.Point(124, 275);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(158, 76);
            this.textBox7.TabIndex = 16;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.calculate3x3Determinant);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = this.BackColor;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.textBox8.Location = new System.Drawing.Point(324, 275);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(158, 76);
            this.textBox8.TabIndex = 17;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.calculate3x3Determinant);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = this.BackColor;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.textBox9.Location = new System.Drawing.Point(526, 275);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(158, 76);
            this.textBox9.TabIndex = 18;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.calculate3x3Determinant);
            // 
            // AnswerBoxImage
            // 
            this.AnswerBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("AnswerBox.Image")));
            this.AnswerBoxImage.Location = new System.Drawing.Point(198, 398);
            this.AnswerBoxImage.Name = "AnswerBoxImage";
            this.AnswerBoxImage.Size = new System.Drawing.Size(438, 67);
            this.AnswerBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AnswerBoxImage.TabIndex = 19;
            this.AnswerBoxImage.TabStop = false;
            // 
            // AnswerBox
            // 
            this.AnswerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AnswerBox.Location = new System.Drawing.Point(405, 416);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.ReadOnly = true;
            this.AnswerBox.Size = new System.Drawing.Size(201, 31);
            this.AnswerBox.TabIndex = 20;
            // 
            // Matrix3x3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AnswerBoxImage);
            this.Controls.Add(this.Matrix3x3Component);
            this.Name = "Matrix3x3";
            this.Text = "Matrix3x3";
            ((System.ComponentModel.ISupportInitialize)(this.Matrix3x3Component)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        public void calculate3x3Determinant(object sender, EventArgs e)
        {
            double a, b, c, d, f, g, h, i, j;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b) && double.TryParse(textBox3.Text, out c) && double.TryParse(textBox4.Text, out d) && double.TryParse(textBox5.Text, out f) && double.TryParse(textBox6.Text, out g) && double.TryParse(textBox7.Text, out h) && double.TryParse(textBox8.Text, out i) && double.TryParse(textBox9.Text, out j))
            {
                double determinant = a * f * j + b * g * h + c * d * i - c * f * h - b * d * j - a * g * i;

                AnswerBox.Text = determinant.ToString();
            }

        }

        private System.Windows.Forms.PictureBox Matrix3x3Component;
        private System.Windows.Forms.PictureBox AnswerBoxImage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox AnswerBox;
    }
}