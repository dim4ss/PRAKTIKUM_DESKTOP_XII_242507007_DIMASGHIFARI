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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRAKTIKUM_DESKTOP_XII_242507007_DIMASGHIFARI
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        string konfigurasi = "server=localhost;password=;database=db_apotek_petugas;username=root";

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin pindah3 = new FormLogin();
            pindah3.FormClosed += Pindah3_FormClosed;
            pindah3.Show();
            this.Hide();
        }

        private void Pindah3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void butdaftar_Click(object sender, EventArgs e)
        {
            if (textpw == textkonfirpw)
            {
                MessageBox.Show("password dan konfirmasi benar");
            }
            else
            { MessageBox.Show("passsword dan konfirmasi tidaksama"); }

            MySqlConnection configurasi = new MySqlConnection(this.konfigurasi);
            try
            {
                configurasi.Open();

                string query = "INSERT INTO tb_apoteker (username, password, role, nama_petugas, shift) VALUES (@username, @password, @role, @nama_petugas, @shift)";
                MySqlCommand cmd = new MySqlCommand(query, configurasi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@username", textuser.Text));
                cmd.Parameters.Add(new MySqlParameter("@password", textpw.Text));
                cmd.Parameters.Add(new MySqlParameter("@role", cmbrole.SelectedItem.ToString()));
                cmd.Parameters.Add(new MySqlParameter("@nama_petugas", textnamapetugas.Text));
                cmd.Parameters.Add(new MySqlParameter("@shift", cmbshift.SelectedItem.ToString()));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                configurasi.Close();
                MessageBox.Show("Gagal Menyimpan Data. Pesan Kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(konfigurasi);
            string query = "SELECT @role FORM tb_petugas";
            MySqlCommand cmd = new MySqlCommand(query, con);
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            cmbrole.SelectedIndex = 0;
            cmbshift.SelectedIndex = 0;
        }
    }
}
