using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace AGENDA_GURU
{
    class koneksi
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString =
                "server=localhost;" +
                "database=db_agenda_guru;" +
                "uid=root;" +
                "pwd=;";

            return new MySqlConnection(connectionString);
        }
    }
}
