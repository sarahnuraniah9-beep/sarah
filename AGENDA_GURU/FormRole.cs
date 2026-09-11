using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AGENDA_GURU
{
    public partial class FormRole : Form
    {
        public FormRole()
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

                    string query = "SELECT id_role, nama_role FROM t_role";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvrole.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void Bersihkan()
        {
            txtidrole.Clear();
            txtnamarole.Clear();
            txtnamarole.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtnamarole.Text == "")
            {
                MessageBox.Show("Nama role belum diisi!");
                return;
            }

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "INSERT INTO t_role (nama_role) VALUES (@nama)";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nama",
                        txtnamarole.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Role berhasil ditambahkan!");

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
            if (txtidrole.Text == "")
            {
                MessageBox.Show("Pilih data yang ingin diedit!");
                return;
            }

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "UPDATE t_role SET nama_role=@nama " +
                        "WHERE id_role=@id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nama",
                        txtnamarole.Text);

                    cmd.Parameters.AddWithValue("@id",
                        txtidrole.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Role berhasil diubah!");

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
            if (txtidrole.Text == "")
            {
                MessageBox.Show("Pilih data yang ingin dihapus!");
                return;
            }

            DialogResult hasil =
                MessageBox.Show(
                    "Yakin ingin menghapus role ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo);

            if (hasil == DialogResult.No)
                return;

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "DELETE FROM t_role WHERE id_role=@id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id",
                        txtidrole.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Role berhasil dihapus!");

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvRole_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtidrole.Text =
                    dgvrole.Rows[e.RowIndex]
                    .Cells["id_role"].Value.ToString();

                txtnamarole.Text =
                    dgvrole.Rows[e.RowIndex]
                    .Cells["nama_role"].Value.ToString();
            }
        }
    }
}
    
