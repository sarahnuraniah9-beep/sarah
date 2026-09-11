using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGENDA_GURU
{
    public partial class FormKelas : Form
    {
        public FormKelas()
        {
            InitializeComponent();
            TampilData();
        }

        void TampilData()
        {
            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "SELECT id_kelas, nama_kelas FROM t_kelas";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvkelas.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void Bersihkan()
        {
            txtidkelas.Clear();
            txtnamakelas.Clear();
            txtnamakelas.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtnamakelas.Text == "")
            {
                MessageBox.Show("Nama kelas belum diisi!");
                return;
            }

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "INSERT INTO t_kelas (nama_kelas) " +
                        "VALUES (@nama)";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@nama", txtnamakelas.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kelas berhasil ditambahkan!");

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtidkelas.Text == "")
            {
                MessageBox.Show("Pilih kelas!");
                return;
            }

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "UPDATE t_kelas SET nama_kelas=@nama " +
                        "WHERE id_kelas=@id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@nama", txtnamakelas.Text);

                    cmd.Parameters.AddWithValue(
                        "@id", txtidkelas.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kelas berhasil diubah!");

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtidkelas.Text == "")
            {
                MessageBox.Show("Pilih kelas!");
                return;
            }

            if (MessageBox.Show(
                "Yakin ingin menghapus kelas?",
                "Konfirmasi",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "DELETE FROM t_kelas WHERE id_kelas=@id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@id", txtidkelas.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kelas berhasil dihapus!");

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvKelas_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtidkelas.Text =
                    dgvkelas.Rows[e.RowIndex]
                    .Cells["id_kelas"].Value.ToString();

                txtnamakelas.Text =
                    dgvkelas.Rows[e.RowIndex]
                    .Cells["nama_kelas"].Value.ToString();
            }
        }
    }
}

