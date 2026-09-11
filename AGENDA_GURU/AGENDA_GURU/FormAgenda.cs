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
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();

            // Pengaturan jam
            dtpJamMulai.Format =
                DateTimePickerFormat.Time;

            dtpJamMulai.ShowUpDown = true;

            dtpJamSelesai.Format =
                DateTimePickerFormat.Time;

            dtpJamSelesai.ShowUpDown = true;

            // Hubungkan tombol
            btnTambah.Click += btnTambah_Click;
            btnEdit.Click += btnEdit_Click;
            btnHapus.Click += btnHapus_Click;
            btnBatal.Click += btnBatal_Click;

            // Hubungkan DataGridView
            dgvAgenda.CellClick += dgvAgenda_CellClick;

            // Isi ComboBox
            TampilGuru();
            TampilKelas();

            // Isi DataGridView
            TampilData();

            // Isi status
            TampilStatus();
        }

        // ==========================
        // STATUS
        // ==========================

        private void TampilStatus()
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("belum");
            cmbStatus.Items.Add("selesai");

            if (cmbStatus.Items.Count > 0)
            {
                cmbStatus.SelectedIndex = 0;
            }
        }

        // ==========================
        // TAMPIL GURU
        // ==========================

        private void TampilGuru()
        {
            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "SELECT id_guru, nama_guru " +
                        "FROM t_guru " +
                        "ORDER BY nama_guru";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cmbGuru.DataSource = dt;
                    cmbGuru.DisplayMember = "nama_guru";
                    cmbGuru.ValueMember = "id_guru";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal menampilkan guru:\n" +
                        ex.Message
                    );
                }
            }
        }

        // ==========================
        // TAMPIL KELAS
        // ==========================

        private void TampilKelas()
        {
            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "SELECT id_kelas, nama_kelas " +
                        "FROM t_kelas " +
                        "ORDER BY nama_kelas";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cmbKelas.DataSource = dt;
                    cmbKelas.DisplayMember = "nama_kelas";
                    cmbKelas.ValueMember = "id_kelas";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal menampilkan kelas:\n" +
                        ex.Message
                    );
                }
            }
        }

        // ==========================
        // TAMPIL DATA AGENDA
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
                        "a.id_agenda, " +
                        "a.tanggal, " +
                        "a.jam_mulai, " +
                        "a.jam_selesai, " +
                        "a.id_guru, " +
                        "g.nama_guru, " +
                        "a.id_kelas, " +
                        "k.nama_kelas, " +
                        "a.materi, " +
                        "a.kegiatan, " +
                        "a.tugas, " +
                        "a.keterangan, " +
                        "a.status " +
                        "FROM t_agenda a " +
                        "INNER JOIN t_guru g " +
                        "ON a.id_guru = g.id_guru " +
                        "INNER JOIN t_kelas k " +
                        "ON a.id_kelas = k.id_kelas " +
                        "ORDER BY a.id_agenda";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvAgenda.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal menampilkan agenda:\n" +
                        ex.Message
                    );
                }
            }
        }

        // ==========================
        // BERSIHKAN
        // ==========================

        private void Bersihkan()
        {
            txtIdAgenda.Clear();

            txtMateri.Clear();
            txtKegiatan.Clear();
            txtTugas.Clear();
            txtKeterangan.Clear();

            if (cmbGuru.Items.Count > 0)
            {
                cmbGuru.SelectedIndex = 0;
            }

            if (cmbKelas.Items.Count > 0)
            {
                cmbKelas.SelectedIndex = 0;
            }

            if (cmbStatus.Items.Count > 0)
            {
                cmbStatus.SelectedIndex = 0;
            }

            dtpTanggal.Value =
                DateTime.Now;

            dtpJamMulai.Value =
                DateTime.Now;

            dtpJamSelesai.Value =
                DateTime.Now;
        }

        // ==========================
        // TAMBAH AGENDA
        // ==========================

        private void btnTambah_Click(
            object sender,
            EventArgs e)
        {
            if (cmbGuru.SelectedValue == null ||
                cmbKelas.SelectedValue == null)
            {
                MessageBox.Show(
                    "Guru dan kelas harus dipilih!"
                );

                return;
            }

            if (txtMateri.Text.Trim() == "" ||
                txtKegiatan.Text.Trim() == "" ||
                txtTugas.Text.Trim() == "" ||
                txtKeterangan.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Data agenda belum lengkap!"
                );

                return;
            }

            if (dtpJamSelesai.Value.TimeOfDay <=
                dtpJamMulai.Value.TimeOfDay)
            {
                MessageBox.Show(
                    "Jam selesai harus lebih besar " +
                    "dari jam mulai!"
                );

                return;
            }

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "INSERT INTO t_agenda " +
                        "(tanggal, jam_mulai, jam_selesai, " +
                        "id_guru, id_kelas, materi, kegiatan, " +
                        "tugas, keterangan, status) " +
                        "VALUES " +
                        "(@tanggal, @mulai, @selesai, " +
                        "@guru, @kelas, @materi, @kegiatan, " +
                        "@tugas, @keterangan, @status)";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@tanggal",
                        dtpTanggal.Value.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "@mulai",
                        dtpJamMulai.Value.TimeOfDay
                    );

                    cmd.Parameters.AddWithValue(
                        "@selesai",
                        dtpJamSelesai.Value.TimeOfDay
                    );

                    cmd.Parameters.AddWithValue(
                        "@guru",
                        cmbGuru.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@kelas",
                        cmbKelas.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@materi",
                        txtMateri.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@kegiatan",
                        txtKegiatan.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@tugas",
                        txtTugas.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@keterangan",
                        txtKeterangan.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@status",
                        cmbStatus.Text
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Agenda berhasil disimpan!"
                    );

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal menyimpan agenda:\n" +
                        ex.Message
                    );
                }
            }
        }

        // ==========================
        // EDIT AGENDA
        // ==========================

        private void btnEdit_Click(
            object sender,
            EventArgs e)
        {
            if (txtIdAgenda.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Pilih agenda yang ingin diubah!"
                );

                return;
            }

            using (MySqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "UPDATE t_agenda SET " +
                        "tanggal = @tanggal, " +
                        "jam_mulai = @mulai, " +
                        "jam_selesai = @selesai, " +
                        "id_guru = @guru, " +
                        "id_kelas = @kelas, " +
                        "materi = @materi, " +
                        "kegiatan = @kegiatan, " +
                        "tugas = @tugas, " +
                        "keterangan = @keterangan, " +
                        "status = @status " +
                        "WHERE id_agenda = @id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@tanggal",
                        dtpTanggal.Value.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "@mulai",
                        dtpJamMulai.Value.TimeOfDay
                    );

                    cmd.Parameters.AddWithValue(
                        "@selesai",
                        dtpJamSelesai.Value.TimeOfDay
                    );

                    cmd.Parameters.AddWithValue(
                        "@guru",
                        cmbGuru.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@kelas",
                        cmbKelas.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@materi",
                        txtMateri.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@kegiatan",
                        txtKegiatan.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@tugas",
                        txtTugas.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@keterangan",
                        txtKeterangan.Text.Trim()
                    );

                    cmd.Parameters.AddWithValue(
                        "@status",
                        cmbStatus.Text
                    );

                    cmd.Parameters.AddWithValue(
                        "@id",
                        txtIdAgenda.Text
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Agenda berhasil diubah!"
                    );

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal mengubah agenda:\n" +
                        ex.Message
                    );
                }
            }
        }

        // ==========================
        // HAPUS AGENDA
        // ==========================

        private void btnHapus_Click(
            object sender,
            EventArgs e)
        {
            if (txtIdAgenda.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Pilih agenda yang ingin dihapus!"
                );

                return;
            }

            DialogResult hasil =
                MessageBox.Show(
                    "Yakin ingin menghapus agenda ini?",
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
                        "DELETE FROM t_agenda " +
                        "WHERE id_agenda = @id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        txtIdAgenda.Text
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Agenda berhasil dihapus!"
                    );

                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal menghapus agenda:\n" +
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

        private void dgvAgenda_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvAgenda.Rows[e.RowIndex];

            txtIdAgenda.Text =
                row.Cells["id_agenda"]
                .Value.ToString();

            dtpTanggal.Value =
                Convert.ToDateTime(
                    row.Cells["tanggal"].Value
                );

            TimeSpan jamMulai =
                (TimeSpan)row.Cells["jam_mulai"].Value;

            TimeSpan jamSelesai =
                (TimeSpan)row.Cells["jam_selesai"].Value;

            dtpJamMulai.Value =
                DateTime.Today.Add(jamMulai);

            dtpJamSelesai.Value =
                DateTime.Today.Add(jamSelesai);

            cmbGuru.SelectedValue =
                row.Cells["id_guru"].Value;

            cmbKelas.SelectedValue =
                row.Cells["id_kelas"].Value;

            txtMateri.Text =
                row.Cells["materi"]
                .Value.ToString();

            txtKegiatan.Text =
                row.Cells["kegiatan"]
                .Value.ToString();

            txtTugas.Text =
                row.Cells["tugas"]
                .Value.ToString();

            txtKeterangan.Text =
                row.Cells["keterangan"]
                .Value.ToString();

            cmbStatus.Text =
                row.Cells["status"]
                .Value.ToString();
        }
    }

}
