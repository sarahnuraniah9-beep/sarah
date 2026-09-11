using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGENDA_GURU
{
    public partial class Formmenuutama : Form
    {
    
            private string namaUser;
            private string role;

            public Formmenuutama(string nama, string role)
            {
                InitializeComponent();

                namaUser = nama;
                this.role = role;
            }
        

    }
}
