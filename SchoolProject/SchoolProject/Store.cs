using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace SchoolProject
{
    public partial class Store : Form
    {
            db connect = new db();
            MySqlCommand kmt = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable datatable = new DataTable();
        public Store()
        {
            InitializeComponent();

            kmt.Connection = connect.baglan();
            kmt.CommandText = "select * from ürünler";
            adapter.SelectCommand = kmt;
            adapter.Fill(datatable);
            DATA.DataSource = datatable;
            kmt.Connection = connect.kapat();
        }

        private void Store_Load(object sender, EventArgs e)
        {

        }

        private void DATA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DATA.SelectedCells[0].RowIndex;
            urundatalabel.Text = DATA.Rows[secilen].Cells[1].Value.ToString();
            urunfiyatdatalabel.Text = DATA.Rows[secilen].Cells[2].Value.ToString();
            
            if ((DATA.Rows[secilen].Cells[3].Value.ToString()).Equals("True"))
            {
                urunstokdatalabel.Text = "Stokta var ";
            }
            else
            {
                urunstokdatalabel.Text = "Stokta yok ";
            }
            DataPic.ImageLocation = DATA.Rows[secilen].Cells[4].Value.ToString();
        }
    }
}
