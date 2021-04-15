using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjWinCsExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            txtNumber.Text = txtName.Text = txtPin.Text = "";
            txtStatus.Text = "active";
            txtNumber.Focus();
            ActivateButtons(false, false, false, true);
        }
    }
}
