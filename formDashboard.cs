using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PRAKTIKUM_DESKTOP_XII_242507007_DIMASGHIFARI
{
    public partial class formDashboard : Form
    {
        string konfigurasi = "server=localhost;database=db_apotek_petugas;username=root;password=;";
        public formDashboard()
        {
            InitializeComponent();
        }

        private void butlogout_Click(object sender, EventArgs e)
        {
            FormLogin pindah1 = new FormLogin();
            pindah1.FormClosed += Pindah1_FormClosed;
            pindah1.Show();
            this.Hide();
        }

        private void Pindah1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(konfigurasi);
            try
            {
                conn.Open();
                string query = "SELECT nama_petugas = @nama_petugas, shift = @shift, role = @role FROM tb_apoteker";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama_petugas", labelmunculnama.Text);
                cmd.Parameters.AddWithValue("@shift", labelmunculshift.Text);
                cmd.Parameters.AddWithValue("@role", labelmunculjabatan.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
