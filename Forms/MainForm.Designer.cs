using System;
using System.Drawing;

namespace PrimijenjenaMatematika_DC.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.StripMenuComponent = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2x2Matrix = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu3x3Matrix = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCramerRule = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnCramerRule = new System.Windows.Forms.Button();
            this.btnMatrix3x3 = new System.Windows.Forms.Button();
            this.CramerRuleLabel = new System.Windows.Forms.Label();
            this.btnMatrix2x2 = new System.Windows.Forms.Button();
            this.Matrix3x3Label = new System.Windows.Forms.Label();
            this.Matrix2x2Label = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();

            #region Menu Strip
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuComponent});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1226, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Menu Menu Label
            // 
            this.StripMenuComponent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu2x2Matrix,
            this.Menu3x3Matrix,
            this.MenuCramerRule});
            this.StripMenuComponent.Name = "StripMenuComponent";
            this.StripMenuComponent.Size = new System.Drawing.Size(50, 20);
            this.StripMenuComponent.Text = "Menu";
            // 
            // Menu 2x2 Matrix Label
            // 
            this.Menu2x2Matrix.Name = "Menu2x2Matrix";
            this.Menu2x2Matrix.Size = new System.Drawing.Size(147, 22);
            this.Menu2x2Matrix.Text = "2x2 Matrix";
            this.Menu2x2Matrix.Click += new System.EventHandler(this.btnMatrix2x2_Click);
            // 
            // Menu 3x3 Matrix Label
            // 
            this.Menu3x3Matrix.Name = "Menu3x3Matrix";
            this.Menu3x3Matrix.Size = new System.Drawing.Size(147, 22);
            this.Menu3x3Matrix.Text = "3x3 Matrix";
            // 
            // Menu Cramer's Rule Label
            // 
            this.MenuCramerRule.Name = "MenuCramerRule";
            this.MenuCramerRule.Size = new System.Drawing.Size(147, 22);
            this.MenuCramerRule.Text = "Cramer\'s Rule";

            #endregion

            #region Panel (Left)
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnCramerRule);
            this.pnlLeft.Controls.Add(this.btnMatrix3x3);
            this.pnlLeft.Controls.Add(this.CramerRuleLabel);
            this.pnlLeft.Controls.Add(this.btnMatrix2x2);
            this.pnlLeft.Controls.Add(this.Matrix3x3Label);
            this.pnlLeft.Controls.Add(this.Matrix2x2Label);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 24);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(166, 462);
            this.pnlLeft.TabIndex = 1;
            this.pnlLeft.BackColor = Color.LightSkyBlue;

            #region Cramer's Rule Button
            // 
            // Cramer's Rule Image
            // 
            this.btnCramerRule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.btnCramerRule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCramerRule.Location = new System.Drawing.Point(31, 299);
            this.btnCramerRule.Name = "btnCramerRule";
            this.btnCramerRule.Size = new System.Drawing.Size(113, 109);
            this.btnCramerRule.TabIndex = 9;
            this.btnCramerRule.TabStop = false;
            this.btnCramerRule.BackColor = Color.White;
            this.btnCramerRule.Click += new System.EventHandler(this.btnCramerRule_Click);
            // 
            // Cramer's Rule Label
            // 
            this.CramerRuleLabel.AutoSize = true;
            this.CramerRuleLabel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CramerRuleLabel.Location = new System.Drawing.Point(28, 411);
            this.CramerRuleLabel.Name = "CramerRuleLabel";
            this.CramerRuleLabel.Size = new System.Drawing.Size(67, 15);
            this.CramerRuleLabel.TabIndex = 7;
            this.CramerRuleLabel.Text = "Cramer\'s Rule";

            #endregion

            #region 2x2 Matrix Button

            // 
            // 2x2 Matrix Button
            // 
            this.btnMatrix2x2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.btnMatrix2x2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMatrix2x2.Location = new System.Drawing.Point(31, 30);
            this.btnMatrix2x2.Name = "btnMatrix2x2";
            this.btnMatrix2x2.Size = new System.Drawing.Size(113, 109);
            this.btnMatrix2x2.TabIndex = 5;
            this.btnMatrix2x2.TabStop = false;
            this.btnMatrix2x2.Click += new System.EventHandler(this.btnMatrix2x2_Click);
            this.btnMatrix2x2.BackColor = Color.White;
            // 
            // Matrix2x2Label
            // 
            this.Matrix2x2Label.AutoSize = true;
            this.Matrix2x2Label.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matrix2x2Label.Location = new System.Drawing.Point(28, 142);
            this.Matrix2x2Label.Name = "Matrix2x2Label";
            this.Matrix2x2Label.Size = new System.Drawing.Size(52, 15);
            this.Matrix2x2Label.TabIndex = 1;
            this.Matrix2x2Label.Text = "2x2 Matrix";

            #endregion

            #region 3x3 Matrix Button

            // 
            // 3x3 Matrix Image
            // 
            this.btnMatrix3x3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.btnMatrix3x3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMatrix3x3.Location = new System.Drawing.Point(31, 160);
            this.btnMatrix3x3.Name = "btnMatrix3x3";
            this.btnMatrix3x3.Size = new System.Drawing.Size(113, 109);
            this.btnMatrix3x3.TabIndex = 8;
            this.btnMatrix3x3.TabStop = false;
            this.btnMatrix3x3.Click += new System.EventHandler(this.btnMatrix3x3_Click);
            this.btnMatrix3x3.BackColor = Color.White;
            // 
            // Matrix3x3Label
            // 
            this.Matrix3x3Label.AutoSize = true;
            this.Matrix3x3Label.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matrix3x3Label.Location = new System.Drawing.Point(28, 272);
            this.Matrix3x3Label.Name = "Matrix3x3Label";
            this.Matrix3x3Label.Size = new System.Drawing.Size(52, 15);
            this.Matrix3x3Label.TabIndex = 3;
            this.Matrix3x3Label.Text = "3x3 Matrix";

            #endregion

            #endregion

            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(166, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1060, 462);
            this.pnlMain.TabIndex = 2;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 486);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem StripMenuComponent;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label Matrix2x2Label;
        private System.Windows.Forms.ToolStripMenuItem Menu2x2Matrix;
        private System.Windows.Forms.ToolStripMenuItem Menu3x3Matrix;
        private System.Windows.Forms.Label Matrix3x3Label;
        private System.Windows.Forms.ToolStripMenuItem MenuCramerRule;
        private System.Windows.Forms.Label CramerRuleLabel;
        private System.Windows.Forms.Button btnMatrix2x2;
        private System.Windows.Forms.Button btnMatrix3x3;
        private System.Windows.Forms.Button btnCramerRule;
    }
}