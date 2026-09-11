using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGENDA_GURU
{
    public partial class FormGuru : Form
    {
        public FormGuru()
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
                        "SELECT * FROM t_guru";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvguru.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void Bersihkan()
        {
            txtidguru.Clear();
            txtnip.Clear();
            txtnamaguru.Clear();
            txtmapel.Clear();
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "INSERT INTO t_guru " +
                        "(nip,nama_guru,mata_pelajaran,username,password) " +
                        "VALUES (@nip,@nama,@mapel,@username,@password)";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@nip", txtnip.Text);

                    cmd.Parameters.AddWithValue(
                        "@nama", txtnamaguru.Text);

                    cmd.Parameters.AddWithValue(
                        "@mapel", txtmapel.Text);

                    cmd.Parameters.AddWithValue(
                        "@username", txtusername.Text);

                    cmd.Parameters.AddWithValue(
                        "@password", txtpassword.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data guru berhasil ditambahkan!");

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
            if (txtidguru.Text == "")
            {
                MessageBox.Show("Pilih data guru!");
                return;
            }

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "UPDATE t_guru SET " +
                        "nip=@nip, " +
                        "nama_guru=@nama, " +
                        "mata_pelajaran=@mapel, " +
                        "username=@username, " +
                        "password=@password " +
                        "WHERE id_guru=@id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@nip", txtnip.Text);

                    cmd.Parameters.AddWithValue(
                        "@nama", txtnamaguru.Text);

                    cmd.Parameters.AddWithValue(
                        "@mapel", txtmapel.Text);

                    cmd.Parameters.AddWithValue(
                        "@username", txtusername.Text);

                    cmd.Parameters.AddWithValue(
                        "@password", txtpassword.Text);

                    cmd.Parameters.AddWithValue(
                        "@id", txtidguru.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data guru berhasil diubah!");

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
            if (txtidguru.Text == "")
            {
                MessageBox.Show("Pilih data guru!");
                return;
            }

            if (MessageBox.Show(
                "Yakin ingin menghapus data guru?",
                "Konfirmasi",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "DELETE FROM t_guru WHERE id_guru=@id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@id", txtidguru.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data guru berhasil dihapus!");

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvGuru_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtidguru.Text =
                    dgvguru.Rows[e.RowIndex]
                    .Cells["id_guru"].Value.ToString();

                txtnip.Text =
                    dgvguru.Rows[e.RowIndex]
                    .Cells["nip"].Value.ToString();

                txtnamaguru.Text =
                    dgvguru.Rows[e.RowIndex]
                    .Cells["nama_guru"].Value.ToString();

                txtmapel.Text =
                    dgvguru.Rows[e.RowIndex]
                    .Cells["mata_pelajaran"].Value.ToString();

                txtusername.Text =
                    dgvguru.Rows[e.RowIndex]
                    .Cells["username"].Value.ToString();

                txtpassword.Text =
                    dgvguru.Rows[e.RowIndex]
                    .Cells["password"].Value.ToString();
            }
        }
    }
}
       

