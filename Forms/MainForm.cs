using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimijenjenaMatematika_DC.Forms
{
    public partial class MainForm : Form
    {
        #region Ctor

        public MainForm()
        {
            InitializeComponent();

            DisplayForm(Section.Home);
        }

        #endregion Ctor

        #region Methods

        private void DisplayForm(Section section)
        {
            Form form = null;

            switch (section)
            {
                case Section.Home:
                    form = new Home();
                    break;


                case Section.Matrix2x2:
                    form = new Matrix2x2();
                    break;

                case Section.Matrix3x3:
                    form = new Matrix3x3();
                    break;

                case Section.CramerRule:
                    form = new CramerRule();
                    break;


                default:
                    break;
            }

            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();

            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(form);
        }

        #endregion Methods

        #region UI Events

        private void btnMatrix2x2_Click(object sender, System.EventArgs e)
        {
            DisplayForm(Section.Matrix2x2);
        }

        private void btnMatrix3x3_Click(object sender, System.EventArgs e)
        {
            DisplayForm(Section.Matrix3x3);
        }

        private void btnCramerRule_Click(object sender, System.EventArgs e)
        {
            DisplayForm(Section.CramerRule);
        }

        #endregion
    }
}