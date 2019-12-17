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
    public partial class KullaniciGİris : Form
    {

        public KullaniciGİris()
        {
            InitializeComponent();
            KullaniciSifreTextBox.Text = "";
            KullaniciSifreTextBox.PasswordChar = '*';
            KullaniciSifreTextBox.MaxLength = 20;
            KullaniciAdiTextBox.MaxLength = 20;
        }

        private void AdminGirisButton_Click(object sender, EventArgs e)
        {
            db connect = new db();
            MySqlCommand kmt = new MySqlCommand();
            MySqlDataReader dr;
            kmt.Connection = connect.baglan();
            kmt.CommandText = "Select * FROM girisbilgikullanici where KullaniciAdi = '" + KullaniciAdiTextBox.Text + "' AND Sifre = '" + KullaniciSifreTextBox.Text + "'";
            dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı \nAktarılıyorsunuz ...");
                Store store = new Store();
                this.Hide();
                store.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz !");
            }


            kmt.Connection = connect.kapat();
        }
    }
}
