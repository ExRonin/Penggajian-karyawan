using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ulangan
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Beneran Mau Exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cancel == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
             
            }
        }

        private void DataSekolahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            karyawan muncul = new karyawan();
            muncul.Show();
        }
    }
}
