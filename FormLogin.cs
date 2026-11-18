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
        string konfigurasi = "server=localhost;database=db_apotek_petugas;username=root;password=;";

        private void butlogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(konfigurasi);
            try {
                conn.Open();
                string query = "SELECT * FROM tb_apoteker WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", textuser.Text);
                cmd.Parameters.AddWithValue("@password", textpw.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Login berhasil!");
                    formDashboard pindah1= new formDashboard();
                    pindah1.FormClosed += Pindah1_FormClosed;
                    pindah1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Pindah1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister pindah2 = new FormRegister();
            pindah2.FormClosed += Pindah2_FormClosed; ;
            pindah2.Show();
            this.Hide();
        }

        private void Pindah2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
