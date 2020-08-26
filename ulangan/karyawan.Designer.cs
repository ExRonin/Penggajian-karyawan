namespace ulangan
{
    partial class karyawan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nip_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nama_box = new System.Windows.Forms.TextBox();
            this.cboxkode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jabatan_box = new System.Windows.Forms.TextBox();
            this.gajilembur_box = new System.Windows.Forms.TextBox();
            this.gajipokok_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxstatus = new System.Windows.Forms.ComboBox();
            this.tunjanganistri_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tunjangananak_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.jumlahanak_box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gajikotor_box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pajak_box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gajijamlembur_box = new System.Windows.Forms.TextBox();
            this.jamlembur_box = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gajibersih_box = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_bersih = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_keluar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nip";
            // 
            // nip_box
            // 
            this.nip_box.Location = new System.Drawing.Point(120, 151);
            this.nip_box.Name = "nip_box";
            this.nip_box.Size = new System.Drawing.Size(123, 20);
            this.nip_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // nama_box
            // 
            this.nama_box.Location = new System.Drawing.Point(120, 191);
            this.nama_box.Name = "nama_box";
            this.nama_box.Size = new System.Drawing.Size(123, 20);
            this.nama_box.TabIndex = 3;
            // 
            // cboxkode
            // 
            this.cboxkode.FormattingEnabled = true;
            this.cboxkode.Items.AddRange(new object[] {
            "KJ-01",
            "KJ-02",
            "KJ-03",
            "KJ-04",
            "KJ-05",
            "KJ-06"});
            this.cboxkode.Location = new System.Drawing.Point(120, 227);
            this.cboxkode.Name = "cboxkode";
            this.cboxkode.Size = new System.Drawing.Size(123, 21);
            this.cboxkode.TabIndex = 4;
            this.cboxkode.SelectedIndexChanged += new System.EventHandler(this.Cboxkode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kode Jabatan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jabatan";
            // 
            // jabatan_box
            // 
            this.jabatan_box.Enabled = false;
            this.jabatan_box.Location = new System.Drawing.Point(120, 260);
            this.jabatan_box.Name = "jabatan_box";
            this.jabatan_box.Size = new System.Drawing.Size(123, 20);
            this.jabatan_box.TabIndex = 7;
            // 
            // gajilembur_box
            // 
            this.gajilembur_box.Enabled = false;
            this.gajilembur_box.Location = new System.Drawing.Point(120, 328);
            this.gajilembur_box.Name = "gajilembur_box";
            this.gajilembur_box.Size = new System.Drawing.Size(123, 20);
            this.gajilembur_box.TabIndex = 8;
            this.gajilembur_box.TextChanged += new System.EventHandler(this.Gajilembur_box_TextChanged);
            // 
            // gajipokok_box
            // 
            this.gajipokok_box.Enabled = false;
            this.gajipokok_box.Location = new System.Drawing.Point(120, 294);
            this.gajipokok_box.Name = "gajipokok_box";
            this.gajipokok_box.Size = new System.Drawing.Size(123, 20);
            this.gajipokok_box.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tunjangan lembur";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gaji Pokok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Status Menikah";
            // 
            // cboxstatus
            // 
            this.cboxstatus.FormattingEnabled = true;
            this.cboxstatus.Items.AddRange(new object[] {
            "Sudah",
            "Belum"});
            this.cboxstatus.Location = new System.Drawing.Point(531, 111);
            this.cboxstatus.Name = "cboxstatus";
            this.cboxstatus.Size = new System.Drawing.Size(121, 21);
            this.cboxstatus.TabIndex = 14;
            this.cboxstatus.SelectedIndexChanged += new System.EventHandler(this.Cboxstatus_SelectedIndexChanged);
            // 
            // tunjanganistri_box
            // 
            this.tunjanganistri_box.Enabled = false;
            this.tunjanganistri_box.Location = new System.Drawing.Point(531, 143);
            this.tunjanganistri_box.Name = "tunjanganistri_box";
            this.tunjanganistri_box.Size = new System.Drawing.Size(123, 20);
            this.tunjanganistri_box.TabIndex = 15;
            this.tunjanganistri_box.TextChanged += new System.EventHandler(this.Tunjanganistri_box_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tunjangan Istri";
            // 
            // tunjangananak_box
            // 
            this.tunjangananak_box.Enabled = false;
            this.tunjangananak_box.Location = new System.Drawing.Point(531, 211);
            this.tunjangananak_box.Name = "tunjangananak_box";
            this.tunjangananak_box.Size = new System.Drawing.Size(123, 20);
            this.tunjangananak_box.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(410, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tunjangan anak";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(410, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Jumlah Anak";
            // 
            // jumlahanak_box
            // 
            this.jumlahanak_box.Location = new System.Drawing.Point(531, 180);
            this.jumlahanak_box.Name = "jumlahanak_box";
            this.jumlahanak_box.Size = new System.Drawing.Size(123, 20);
            this.jumlahanak_box.TabIndex = 20;
            this.jumlahanak_box.TextChanged += new System.EventHandler(this.Jumlahanak_box_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(410, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Gaji Kotor";
            // 
            // gajikotor_box
            // 
            this.gajikotor_box.Enabled = false;
            this.gajikotor_box.Location = new System.Drawing.Point(531, 240);
            this.gajikotor_box.Name = "gajikotor_box";
            this.gajikotor_box.Size = new System.Drawing.Size(123, 20);
            this.gajikotor_box.TabIndex = 22;
            this.gajikotor_box.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(414, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Pajak";
            // 
            // pajak_box
            // 
            this.pajak_box.Enabled = false;
            this.pajak_box.Location = new System.Drawing.Point(531, 269);
            this.pajak_box.Name = "pajak_box";
            this.pajak_box.Size = new System.Drawing.Size(123, 20);
            this.pajak_box.TabIndex = 24;
            this.pajak_box.TextChanged += new System.EventHandler(this.Pajak_box_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(399, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "Gaji Jam Lembur";
            // 
            // gajijamlembur_box
            // 
            this.gajijamlembur_box.Enabled = false;
            this.gajijamlembur_box.Location = new System.Drawing.Point(531, 355);
            this.gajijamlembur_box.Name = "gajijamlembur_box";
            this.gajijamlembur_box.Size = new System.Drawing.Size(123, 20);
            this.gajijamlembur_box.TabIndex = 26;
            // 
            // jamlembur_box
            // 
            this.jamlembur_box.Location = new System.Drawing.Point(531, 305);
            this.jamlembur_box.Name = "jamlembur_box";
            this.jamlembur_box.Size = new System.Drawing.Size(123, 20);
            this.jamlembur_box.TabIndex = 27;
            this.jamlembur_box.TextChanged += new System.EventHandler(this.Jamlembur_box_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(410, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "jam lembur";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Jokerman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(217, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(282, 51);
            this.label15.TabIndex = 29;
            this.label15.Text = "Gaji Karyawan";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(414, 411);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Gaji Bersih";
            // 
            // gajibersih_box
            // 
            this.gajibersih_box.Enabled = false;
            this.gajibersih_box.Location = new System.Drawing.Point(529, 404);
            this.gajibersih_box.Name = "gajibersih_box";
            this.gajibersih_box.Size = new System.Drawing.Size(123, 20);
            this.gajibersih_box.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(727, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 313);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // button_bersih
            // 
            this.button_bersih.Location = new System.Drawing.Point(15, 373);
            this.button_bersih.Name = "button_bersih";
            this.button_bersih.Size = new System.Drawing.Size(75, 23);
            this.button_bersih.TabIndex = 34;
            this.button_bersih.Text = "Bersih";
            this.button_bersih.UseVisualStyleBackColor = true;
            this.button_bersih.Click += new System.EventHandler(this.Button_bersih_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Location = new System.Drawing.Point(96, 373);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(75, 23);
            this.button_simpan.TabIndex = 35;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.Button_simpan_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(177, 373);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 36;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.Button_edit_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(258, 373);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 37;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(96, 411);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 38;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // button_keluar
            // 
            this.button_keluar.Location = new System.Drawing.Point(177, 411);
            this.button_keluar.Name = "button_keluar";
            this.button_keluar.Size = new System.Drawing.Size(75, 23);
            this.button_keluar.TabIndex = 39;
            this.button_keluar.Text = "keluar";
            this.button_keluar.UseVisualStyleBackColor = true;
            this.button_keluar.Click += new System.EventHandler(this.Button_keluar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 440);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(211, 443);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "<-- Search sama Delete Disini";
            // 
            // karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1010, 505);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_keluar);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.button_bersih);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gajibersih_box);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.jamlembur_box);
            this.Controls.Add(this.gajijamlembur_box);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pajak_box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gajikotor_box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.jumlahanak_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tunjangananak_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tunjanganistri_box);
            this.Controls.Add(this.cboxstatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gajipokok_box);
            this.Controls.Add(this.gajilembur_box);
            this.Controls.Add(this.jabatan_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxkode);
            this.Controls.Add(this.nama_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nip_box);
            this.Controls.Add(this.label1);
            this.Name = "karyawan";
            this.Text = "Karyawan";
            this.Load += new System.EventHandler(this.Karyawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nip_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nama_box;
        private System.Windows.Forms.ComboBox cboxkode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jabatan_box;
        private System.Windows.Forms.TextBox gajilembur_box;
        private System.Windows.Forms.TextBox gajipokok_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxstatus;
        private System.Windows.Forms.TextBox tunjanganistri_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tunjangananak_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox jumlahanak_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox gajikotor_box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pajak_box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox gajijamlembur_box;
        private System.Windows.Forms.TextBox jamlembur_box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox gajibersih_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_bersih;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_keluar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
    }
}