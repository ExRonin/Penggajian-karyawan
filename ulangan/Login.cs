using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ulangan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void proses_login()
        {
            string username = username_box.Text;
            string password = password_box.Text;

            string database = ("server=localhost; uid=root; database=prafit; pwd='';");
            MySqlConnection connect = new MySqlConnection(database);
            try
            {
                connect.Open();
                MySqlDataAdapter data = new MySqlDataAdapter("SELECT * FROM admin WHERE username='" + username_box.Text + "' && password='" + password_box.Text + "'", connect);
                DataTable dt = new DataTable();
                data.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Password Salah");
                }
                else
                {
                    MessageBox.Show("Login Berhasil");
                    Menu muncul = new Menu();
                    muncul.Show();
                    this.Hide();
                }
                connect.Close();
            }
            catch (Exception ali)
            {
                MessageBox.Show("GAGAL!");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password_box.UseSystemPasswordChar = true;
            }
            else
            {
                password_box.UseSystemPasswordChar = false;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Beneran Mau Exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cancel == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            proses_login();
        }
    }
}
