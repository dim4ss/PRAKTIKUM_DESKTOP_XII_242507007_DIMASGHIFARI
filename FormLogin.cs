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

namespace PRAKTIKUM_DESKTOP_XII_242507007_DIMASGHIFARI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        string konfigurasi = "server=localhost;database=db_apotek_petugas;uid=root;pwd=;";

        private void butlogin_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_apoteker WHERE username = '" + textuser.Text + "' AND password = '" + textpw.Text + "'", new MySqlConnection(konfigurasi));
        }
    }
}
