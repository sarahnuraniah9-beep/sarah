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

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            txtpass.PasswordChar = '*';

            // Hubungkan tombol Login
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Trim() == "" ||
                txtpass.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Username dan password wajib diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "SELECT u.id_user, u.nama_user, " +
                        "r.nama_role " +
                        "FROM t_user u " +
                        "INNER JOIN t_role r " +
                        "ON u.id_role = r.id_role " +
                        "WHERE u.username = @username " +
                        "AND u.password = @password";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@username",
                        txtuser.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@password",
                        txtpass.Text.Trim()
                    );

                    MySqlDataReader reader =
                        cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string nama =
                            reader["nama_user"].ToString();

                        string role =
                            reader["nama_role"].ToString();

                        reader.Close();

                        MessageBox.Show(
                            "Login berhasil sebagai " + role,
                            "Login",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        Formmenuutama menu =
                            new Formmenuutama(nama, role);

                        menu.Show();

                        this.Hide();
                    }
                    else
                    {
                        reader.Close();

                        MessageBox.Show(
                            "Username atau password salah!",
                            "Login Gagal",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Terjadi kesalahan:\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}

    




