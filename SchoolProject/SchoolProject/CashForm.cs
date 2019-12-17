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
    public partial class CashForm : Form
    {
        public CashForm()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            payment pym = new payment();
            this.Hide();
            pym.Show();
        }

        private void TextLabelSum_Click(object sender, EventArgs e)
        {

        }

        private void PayButton_Click(object sender, EventArgs e)
        {
        }
    }
}
