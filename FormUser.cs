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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();

            txtpassword.PasswordChar = '*';

            // Hubungkan tombol
            btnsimpan.Click += btnTambah_Click;
            btnubah.Click += btnEdit_Click;
            hapus.Click += btnHapus_Click;
            btnbatal.Click += btnBatal_Click;

            // Hubungkan DataGridView
            dgvuser.CellClick += dgvUser_CellClick;

            TampilRole();
            TampilData();
        }

        // ==========================
        // TAMPIL ROLE
        // ==========================

        private void TampilRole()
        {
            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "SELECT id_role, nama_role " +
                        "FROM t_role " +
                        "ORDER BY id_role";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cmbrole.DataSource = dt;
                    cmbrole.DisplayMember = "nama_role";
                    cmbrole.ValueMember = "id_role";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal menampilkan role:\n" +
                        ex.Message
                    );
                }
            }
        }

        // ==========================
        // TAMPIL DATA USER
        // ==========================

        private void TampilData()
        {
            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "SELECT " +
                        "u.id_user, " +
                        "u.nama_user, " +
                        "u.username, " +
                        "u.password, " +
                        "u.id_role, " +
                        "r.nama_role " +
                        "FROM t_user u " +
                        "INNER JOIN t_role r " +
                        "ON u.id_role = r.id_role " +
                        "ORDER BY u.id_user";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvuser.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal menampilkan user:\n" +
                        ex.Message
                    );
                }
            }
        }

        // ==========================
        // BERSIHKAN FORM
        // ==========================

        private void Bersihkan()
        {
            txtiduser.Clear();
            txtnamauser.Clear();
            txtusername.Clear();
            txtpassword.Clear();

            if (cmbrole.Items.Count > 0)
            {
                cmbrole.SelectedIndex = 0;
            }

            txtnamauser.Focus();
        }

        // ==========================
        // SIMPAN USER
        // ==========================

        private void btnTambah_Click(
            object sender,
            EventArgs e)
        {
            if (txtnamauser.Text.Trim() == "" ||
            txtusername.Text.Trim() == "" ||
            txtpassword.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Data user belum lengkap!"
                );

                return;
            }

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "INSERT INTO t_user " +
                        "(nama_user, username, password, id_role) " +
                        "VALUES " +
                        "(@nama, @username, @password, @role)";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@nama",
                        txtnamauser.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@username",
                        txtusername.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@password",
                        txtpassword.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@role",
                        cmbrole.SelectedValue
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "User berhasil disimpan!",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal menyimpan user:\n" +
                        ex.Message
                    );
                }
            }
        }

        // ==========================
        // EDIT USER
        // ==========================

        private void btnEdit_Click(
            object sender,
            EventArgs e)
        {
            if (txtiduser.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Pilih user yang ingin diubah!"
                );

                return;
            }

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "UPDATE t_user SET " +
                        "nama_user = @nama, " +
                        "username = @username, " +
                        "password = @password, " +
                        "id_role = @role " +
                        "WHERE id_user = @id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@nama",
                        txtnamauser.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@username",
                        txtusername.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@password",
                        txtpassword.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@role",
                        cmbrole.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@id",
                        txtiduser.Text
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "User berhasil diubah!"
                    );

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal mengubah user:\n" +
                        ex.Message
                    );
                }
            }
        }

        // ==========================
        // HAPUS USER
        // ==========================

        private void btnHapus_Click(
            object sender,
            EventArgs e)
        {
            if (txtiduser.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Pilih user yang ingin dihapus!"
                );

                return;
            }

            DialogResult hasil =
                MessageBox.Show(
                    "Yakin ingin menghapus user ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (hasil == DialogResult.No)
            {
                return;
            }

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "DELETE FROM t_user " +
                        "WHERE id_user = @id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        txtiduser.Text
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "User berhasil dihapus!"
                    );

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal menghapus user:\n" +
                        ex.Message
                    );
                }
            }
        }

        // ==========================
        // BATAL
        // ==========================

        private void btnBatal_Click(
            object sender,
            EventArgs e)
        {
            Bersihkan();
        }

        // ==========================
        // KLIK DATA GRID
        // ==========================

        private void dgvUser_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvuser.Rows[e.RowIndex];

            txtiduser.Text =
                row.Cells["id_user"]
                .Value.ToString();

            txtnamauser.Text =
                row.Cells["nama_user"]
                .Value.ToString();

            txtusername.Text =
                row.Cells["username"]
                .Value.ToString();

            txtpassword.Text =
                row.Cells["password"]
                .Value.ToString();

            if (row.Cells["id_role"].Value != null)
            {
                cmbrole.SelectedValue =
                    row.Cells["id_role"].Value;
            }
        }
    }
}

    
  
    
    
    




