using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PrimijenjenaMatematika_DC.Forms
{
    partial class CramerRule
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(134, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 79);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Izračunaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calculateCramersRule);
            this.textBox1.Text = $"2x + 3y - 4z = 1{Environment.NewLine}5x + 2y - 2z = -1{Environment.NewLine}1x - 1y + 1z = 3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.ReadOnly = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(199, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.ReadOnly = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(199, 234);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.ReadOnly = true;
            // 
            // CramerRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "CramerRule";
            this.Text = "CramerRule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void calculateCramersRule(object sender, System.EventArgs e)
        {

            string[] text = textBox1.Text.Split('\n')
                                            .Where((line, index) => !string.IsNullOrWhiteSpace(line))
                                            .Select(line => line.Trim())
                                            .ToArray();

            var cramers = CramersRule(text[0], text[1], text[2]);

            textBox2.Text = $"x = {Math.Round(cramers[0], 5)}";
            textBox3.Text = $"y = {Math.Round(cramers[1], 5)}";
            textBox4.Text = $"z = {Math.Round(cramers[2], 5)}";
        }

        static double[] ParseEquation(string equation)
        {
            var match = Regex.Match(equation, @"(-?\b\d*)\s*x\s*([+-]\s*\d*)?\s*y?\s*([+-]\s*\d*)?\s*z?\s*=\s*(-?\b\d+)");

            return match.Groups.Cast<Group>().Skip(1).Select(coefficient => string.IsNullOrEmpty(coefficient.Value) ? 0 : double.Parse(coefficient.Value.Replace(" ", ""))).ToArray();
        }

        static double Determinant(double[][] matrix)
        {
            var a = matrix[0][0];
            var b = matrix[0][1];
            var c = matrix[0][2];
            var d = matrix[1][0];
            var e = matrix[1][1];
            var f = matrix[1][2];
            var g = matrix[2][0];
            var h = matrix[2][1];
            var i = matrix[2][2];

            return a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
        }

        static double[] CramersRule(string equation1, string equation2, string equation3)
        {
            var coefficients = new[] { ParseEquation(equation1), ParseEquation(equation2), ParseEquation(equation3) };
            var constants = coefficients.Select(coefficient => coefficient[coefficient.Length - 1]).ToArray();
            for (int i = 0; i < coefficients.Length; i++)
            {
                Array.Resize(ref coefficients[i], coefficients[i].Length - 1);
            }

            double D = Determinant(coefficients);

            double Dx = Determinant(new[] { new[] { constants[0], coefficients[0][1], coefficients[0][2] }, new[] { constants[1], coefficients[1][1], coefficients[1][2] }, new[] { constants[2], coefficients[2][1], coefficients[2][2] } });
            double Dy = Determinant(new[] { new[] { coefficients[0][0], constants[0], coefficients[0][2] }, new[] { coefficients[1][0], constants[1], coefficients[1][2] }, new[] { coefficients[2][0], constants[2], coefficients[2][2] } });
            double Dz = Determinant(new[] { new[] { coefficients[0][0], coefficients[0][1], constants[0] }, new[] { coefficients[1][0], coefficients[1][1], constants[1] }, new[] { coefficients[2][0], coefficients[2][1], constants[2] } });

            return new[] { Dx / D, Dy / D, Dz / D };
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}