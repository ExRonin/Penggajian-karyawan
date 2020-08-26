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


    public partial class karyawan : Form
    {
        string database = ("server = localhost; uid = root; database=prafit; pwd='';");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        Double p1;
        Double pokok1;
        Double ti;
        Double gk;
        Double pj;
        Double gj;
        Double gb;

        public karyawan()
        {
            InitializeComponent();
            baca();
        }

     
        public void q(string query)
        {
            koneksi = new MySqlConnection(database);
            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            finally
            {
                koneksi.Close();
            }

        }
        public void simpan()
        {
            try

            { 
                q("insert into karyawan values('" + textBox1.Text + "','" + nip_box.Text + "','" + nama_box.Text + "','" + cboxkode.Text + "','" + jabatan_box.Text + "','" + gajipokok_box.Text + "','" + gajilembur_box.Text + "','" + cboxkode.Text + "','" + tunjanganistri_box.Text + "','" + jumlahanak_box.Text + "','" + tunjangananak_box.Text + "','" + gajikotor_box.Text + "','" + pajak_box.Text + "','" + jamlembur_box.Text + "','" + gajilembur_box.Text + "','" + gajibersih_box.Text + "')");
                MessageBox.Show("insert berhasil", "informasi");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            baca();

        }
        public void update()
         {
           
            try
            {
                q("UPDATE karyawan SET Nip='" + nip_box.Text + "',Nama='" + nama_box.Text + "',Kode_jabatan='" + cboxkode.Text + "',Jabatan='" + jabatan_box.Text + "',gaji_pokok='" + gajipokok_box.Text + "',Tunjangan_lembur='" + gajilembur_box.Text + "',Status='" + cboxkode.Text + "',Tunjangan_istri='" + tunjanganistri_box.Text + "',jml_anak='" + jumlahanak_box.Text + "',Tunjangan_anak='" + tunjangananak_box.Text + "',Gaji_kotor='" + gajikotor_box.Text + "',Pajak='" + pajak_box.Text + "',Jam_lembur='" + jamlembur_box.Text + "',Gaji_lembur='" + gajilembur_box.Text + "',Gaji_bersih='" + gajibersih_box.Text + "'WHERE id_kode_jabatan='" + textBox1.Text + "'");
        koneksi.Close(); MessageBox.Show("Update Sukses", "Berhasil", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void delete()
        {
            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open(); string del = "delete from karyawan WHERE id_kode_jabatan='" + textBox1.Text + "'";
                cmd = new MySqlCommand(del, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Delete Sukses", "Berhasil", MessageBoxButtons.OK);
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        public void CariData(string Nip)
        {
            string sql = "select * from karyawan where (Nip like'%" + Nip + "%')";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }


        }
        public void konek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Open();
        }
        public void diskonek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Close();
        }
        public DataTable baca()
        {
            string sql = "select * from karyawan";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            diskonek(); return dt;
        }
        public void gajibersih()
        {
            Double pajk = Convert.ToDouble(pajak_box.Text);
            Double jb = Convert.ToDouble(gajijamlembur_box.Text);
            gb = gk - pajk + jb;
            gajibersih_box.Text = Convert.ToString(gb);
        }
        public void gajilembur()
        {
            Double gj2 = Convert.ToDouble(gajilembur_box.Text);
            Double gj1 = Convert.ToDouble(jamlembur_box.Text);
            gj = gj1 * gj2 ;
            gajijamlembur_box.Text = Convert.ToString(gj);
        }
        public void pajak()
        {
            pj = gk * 10 / 100;
            pajak_box.Text = Convert.ToString(pj);
        }
        public void gajikotor()
        {
            if (cboxstatus.Text=="Sudah")
            {
                gk = pokok1 + p1 + ti;
                gajikotor_box.Text = Convert.ToString(gk);
            }
            else
            {
                gk = pokok1 ;
                gajikotor_box.Text = Convert.ToString(gk);
            }
        }
        public void tunjangananak()
        {
            Double kk = Convert.ToDouble(jumlahanak_box.Text);
            if (kk > 2)
            {
                ti = pokok1 * 2 * 15 / 100 ;
                tunjangananak_box.Text = Convert.ToString(ti);
            }
            else
            {
                ti = pokok1 * 15 / 100;
                tunjangananak_box.Text = Convert.ToString(ti);
            }

        }

       public void tunjanganistri()
        {
            
            if (cboxstatus.Text == "Sudah" )
            {
                p1 = pokok1 * 20 / 100;
                tunjanganistri_box.Text = Convert.ToString(p1);
                jumlahanak_box.Enabled = true;





            }
            else
            {
                tunjanganistri_box.Text = "";
                tunjangananak_box.Text = "";
                jumlahanak_box.Enabled = false;
            }
        }
        public void bersih()
        {
            nip_box.Text = "";
            nama_box.Text = "";
            cboxkode.Text = "";
            jabatan_box.Text = "";
            gajipokok_box.Text = "";
            gajilembur_box.Text = "";
            cboxstatus.Text = "";
            tunjanganistri_box.Text = "";
            jumlahanak_box.Text = "";
            tunjangananak_box.Text = "";
            gajikotor_box.Text = "";
            pajak_box.Text = "";
            jamlembur_box.Text = "";
            gajilembur_box.Text = "";
            gajibersih_box.Text = "";


        }
        public void pindahtextbox()
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["id_kode_jabatan"].Value.ToString();
            nip_box.Text = dataGridView1.CurrentRow.Cells["Nip"].Value.ToString();
            nama_box.Text = dataGridView1.CurrentRow.Cells["Nama"].Value.ToString();
            cboxkode.Text = dataGridView1.CurrentRow.Cells["Kode_jabatan"].Value.ToString();
            jabatan_box.Text = dataGridView1.CurrentRow.Cells["Jabatan"].Value.ToString();
            gajipokok_box.Text = dataGridView1.CurrentRow.Cells["Gaji_pokok"].Value.ToString();
            gajilembur_box.Text = dataGridView1.CurrentRow.Cells["Tunjangan_lembur"].Value.ToString();
            cboxstatus.Text = dataGridView1.CurrentRow.Cells["Status"].Value.ToString();
            tunjanganistri_box.Text = dataGridView1.CurrentRow.Cells["Tunjangan_istri"].Value.ToString();
            jumlahanak_box.Text = dataGridView1.CurrentRow.Cells["Jml_anak"].Value.ToString();
            tunjangananak_box.Text = dataGridView1.CurrentRow.Cells["Tunjangan_anak"].Value.ToString();
            gajikotor_box.Text = dataGridView1.CurrentRow.Cells["Gaji_kotor"].Value.ToString();
            jamlembur_box.Text = dataGridView1.CurrentRow.Cells["Jam_lembur"].Value.ToString();
            gajilembur_box.Text = dataGridView1.CurrentRow.Cells["Gaji_lembur"].Value.ToString();
            gajibersih_box.Text = dataGridView1.CurrentRow.Cells["Gaji_bersih"].Value.ToString();
           
        }
        private void Karyawan_Load(object sender, EventArgs e)
        {

        }

        private void Cboxkode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxkode.Text == "KJ-01")
            {
                jabatan_box.Text = "Direktur";
                gajilembur_box.Text = "70000";
                Double t = 7000000;
                pokok1 = t;
                gajipokok_box.Text = Convert.ToString(pokok1);

            }
            else if (cboxkode.Text == "KJ-02")
            {
                jabatan_box.Text = "Manager";
                Double t = 5000000;
                gajilembur_box.Text = "50000";
                pokok1 = t;
                gajipokok_box.Text = Convert.ToString(pokok1);
            }
            else if (cboxkode.Text == "KJ-03")
            {
                jabatan_box.Text = "Kabag";
                Double t = 4000000;
                gajilembur_box.Text = "40000";
                pokok1 = t;
                gajipokok_box.Text = Convert.ToString(pokok1);
            }
            else if (cboxkode.Text == "KJ-04")
            {
                jabatan_box.Text = "Secketaris";
                Double t = 3000000;
                gajilembur_box.Text = "30000";
                pokok1 = t;
                gajipokok_box.Text = Convert.ToString(pokok1);
            }
            else if (cboxkode.Text == "KJ-05")
            {
                jabatan_box.Text = "Karyawan";
                Double t = 2000000;
                gajilembur_box.Text = "20000";
                pokok1 = t;
                gajipokok_box.Text = Convert.ToString(pokok1);
            }
            else
            {
                jabatan_box.Text = "OfficeBoy";
                Double t = 1000000;
                gajilembur_box.Text = "10000";
                pokok1 = t;
                gajipokok_box.Text = Convert.ToString(pokok1);
            }
            tunjanganistri();
            }

        private void Tunjanganistri_box_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Cboxstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            tunjanganistri();
            pajak();
            gajikotor();
        }

        private void Jumlahanak_box_TextChanged(object sender, EventArgs e)
        {
            tunjangananak();
            gajikotor();
            pajak();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Gajilembur_box_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Jamlembur_box_TextChanged(object sender, EventArgs e)
        {
            gajilembur();
            gajibersih();
        }

        private void Button_simpan_Click(object sender, EventArgs e)
        {
            simpan();
            baca();
        }

        private void Button_bersih_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            delete();
            baca();
        }

        private void Button_keluar_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Beneran Mau Exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cancel == DialogResult.Yes)
            {
                Close();
            }
           
        }

        private void Button_search_Click(object sender, EventArgs e)
        {
            CariData(textBox1.Text);
        }

        private void Pajak_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pindahtextbox();
        }

        private void Button_edit_Click(object sender, EventArgs e)
        {
            update();
            baca();
        }
    }
}
