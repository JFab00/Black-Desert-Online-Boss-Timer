using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormInterfaceNew : Form
    {
        public FormInterfaceNew()
        {
            //   allows the transparency on the project
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            //   cut off the windows form's border
            this.FormBorderStyle = FormBorderStyle.None;

            //   display over everything
            this.TopMost = true;

            // Makes the background transparent (it makes it green and then it turns transparent... like a green screen)
            this.BackColor = Color.Gray;
            this.TransparencyKey = BackColor;

            InitializeComponent();
        }

        private void FormInterfaceNew_Load(object sender, EventArgs e)
        {

        }
    }
}
