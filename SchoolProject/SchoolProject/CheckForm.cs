using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();
        }

        private void BackButtonCheck_Click(object sender, EventArgs e)
        {
            payment pym = new payment();
            this.Hide();
            pym.Show();
        }
    }
}
