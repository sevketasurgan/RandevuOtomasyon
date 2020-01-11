namespace HastahaneRandevuProje
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsaat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkilo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.randevusistemDataSet = new HastahaneRandevuProje.randevusistemDataSet();
            this.randevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevularTableAdapter = new HastahaneRandevuProje.randevusistemDataSetTableAdapters.randevularTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxBolum = new System.Windows.Forms.ComboBox();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevusistemDataSet3 = new HastahaneRandevuProje.randevusistemDataSet3();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.comboBoxDokİsim = new System.Windows.Forms.ComboBox();
            this.doktorkayitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.randevusistemDataSet2 = new HastahaneRandevuProje.randevusistemDataSet2();
            this.randevusistemDataSet1 = new HastahaneRandevuProje.randevusistemDataSet1();
            this.doktorkayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doktorkayitTableAdapter = new HastahaneRandevuProje.randevusistemDataSet1TableAdapters.doktorkayitTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.doktorkayitTableAdapter1 = new HastahaneRandevuProje.randevusistemDataSet2TableAdapters.doktorkayitTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bolumlerTableAdapter = new HastahaneRandevuProje.randevusistemDataSet3TableAdapters.bolumlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.randevusistemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevusistemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorkayitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevusistemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevusistemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorkayitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(99, 61);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(116, 20);
            this.txtisim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(33, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İSİM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOYİSİM";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(99, 99);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(116, 20);
            this.txtsoyisim.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "BÖLÜM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(33, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TARİH";
            // 
            // txttarih
            // 
            this.txttarih.Location = new System.Drawing.Point(99, 173);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(116, 20);
            this.txttarih.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(33, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SAAT";
            // 
            // txtsaat
            // 
            this.txtsaat.Location = new System.Drawing.Point(99, 210);
            this.txtsaat.Name = "txtsaat";
            this.txtsaat.Size = new System.Drawing.Size(116, 20);
            this.txtsaat.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(33, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "KİLO";
            // 
            // txtkilo
            // 
            this.txtkilo.Location = new System.Drawing.Point(99, 259);
            this.txtkilo.Name = "txtkilo";
            this.txtkilo.Size = new System.Drawing.Size(116, 20);
            this.txtkilo.TabIndex = 10;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 554);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(87, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(108, 554);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 23);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(203, 554);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(87, 23);
            this.btniptal.TabIndex = 15;
            this.btniptal.Text = "İPTAL";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(33, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "BOY";
            // 
            // txtboy
            // 
            this.txtboy.Location = new System.Drawing.Point(99, 300);
            this.txtboy.Name = "txtboy";
            this.txtboy.Size = new System.Drawing.Size(116, 20);
            this.txtboy.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(33, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "YAS";
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(99, 338);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(116, 20);
            this.txtyas.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(27, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "CİNSİYET";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(27, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 26);
            this.label10.TabIndex = 23;
            this.label10.Text = "DOKTOR\r\nİSİM";
            // 
            // randevusistemDataSet
            // 
            this.randevusistemDataSet.DataSetName = "randevusistemDataSet";
            this.randevusistemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevularBindingSource
            // 
            this.randevularBindingSource.DataMember = "randevular";
            this.randevularBindingSource.DataSource = this.randevusistemDataSet;
            // 
            // randevularTableAdapter
            // 
            this.randevularTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.isim,
            this.soyisim,
            this.bolum,
            this.tarih,
            this.saat,
            this.vki,
            this.doktorisim,
            this.kilo,
            this.boy,
            this.yas,
            this.cinsiyet});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(230, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 487);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // isim
            // 
            this.isim.DataPropertyName = "isim";
            this.isim.HeaderText = "isim";
            this.isim.Name = "isim";
            this.isim.ReadOnly = true;
            // 
            // soyisim
            // 
            this.soyisim.DataPropertyName = "soyisim";
            this.soyisim.HeaderText = "soyisim";
            this.soyisim.Name = "soyisim";
            this.soyisim.ReadOnly = true;
            // 
            // bolum
            // 
            this.bolum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolum.DataPropertyName = "bolum";
            this.bolum.HeaderText = "bolum";
            this.bolum.Name = "bolum";
            this.bolum.ReadOnly = true;
            this.bolum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "tarih";
            this.tarih.Name = "tarih";
            this.tarih.ReadOnly = true;
            // 
            // saat
            // 
            this.saat.DataPropertyName = "saat";
            this.saat.HeaderText = "saat";
            this.saat.Name = "saat";
            this.saat.ReadOnly = true;
            // 
            // vki
            // 
            this.vki.DataPropertyName = "vki";
            this.vki.HeaderText = "vki";
            this.vki.Name = "vki";
            this.vki.ReadOnly = true;
            this.vki.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vki.Width = 40;
            // 
            // doktorisim
            // 
            this.doktorisim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doktorisim.DataPropertyName = "doktorisim";
            this.doktorisim.HeaderText = "doktorisim";
            this.doktorisim.Name = "doktorisim";
            this.doktorisim.ReadOnly = true;
            // 
            // kilo
            // 
            this.kilo.DataPropertyName = "kilo";
            this.kilo.HeaderText = "kilo";
            this.kilo.Name = "kilo";
            this.kilo.ReadOnly = true;
            this.kilo.Width = 40;
            // 
            // boy
            // 
            this.boy.DataPropertyName = "boy";
            this.boy.HeaderText = "boy";
            this.boy.Name = "boy";
            this.boy.ReadOnly = true;
            // 
            // yas
            // 
            this.yas.DataPropertyName = "yas";
            this.yas.HeaderText = "yas";
            this.yas.Name = "yas";
            this.yas.ReadOnly = true;
            // 
            // cinsiyet
            // 
            this.cinsiyet.DataPropertyName = "cinsiyet";
            this.cinsiyet.HeaderText = "cinsiyet";
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.ReadOnly = true;
            // 
            // comboBoxBolum
            // 
            this.comboBoxBolum.DataSource = this.bolumlerBindingSource;
            this.comboBoxBolum.DisplayMember = "bölümler";
            this.comboBoxBolum.FormattingEnabled = true;
            this.comboBoxBolum.Location = new System.Drawing.Point(99, 133);
            this.comboBoxBolum.Name = "comboBoxBolum";
            this.comboBoxBolum.Size = new System.Drawing.Size(116, 21);
            this.comboBoxBolum.TabIndex = 25;
            this.comboBoxBolum.ValueMember = "bölümler";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "bolumler";
            this.bolumlerBindingSource.DataSource = this.randevusistemDataSet3;
            // 
            // randevusistemDataSet3
            // 
            this.randevusistemDataSet3.DataSetName = "randevusistemDataSet3";
            this.randevusistemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN",
            "ERKEK-ÇOCUK",
            "KIZ-ÇOCUK"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(99, 380);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(116, 21);
            this.comboBoxCinsiyet.TabIndex = 26;
            // 
            // comboBoxDokİsim
            // 
            this.comboBoxDokİsim.DataSource = this.doktorkayitBindingSource1;
            this.comboBoxDokİsim.DisplayMember = "fullname";
            this.comboBoxDokİsim.FormattingEnabled = true;
            this.comboBoxDokİsim.Location = new System.Drawing.Point(99, 422);
            this.comboBoxDokİsim.Name = "comboBoxDokİsim";
            this.comboBoxDokİsim.Size = new System.Drawing.Size(116, 21);
            this.comboBoxDokİsim.TabIndex = 27;
            this.comboBoxDokİsim.ValueMember = "kullaniciad";
            // 
            // doktorkayitBindingSource1
            // 
            this.doktorkayitBindingSource1.DataMember = "doktorkayit";
            this.doktorkayitBindingSource1.DataSource = this.randevusistemDataSet2;
            // 
            // randevusistemDataSet2
            // 
            this.randevusistemDataSet2.DataSetName = "randevusistemDataSet2";
            this.randevusistemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevusistemDataSet1
            // 
            this.randevusistemDataSet1.DataSetName = "randevusistemDataSet1";
            this.randevusistemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorkayitBindingSource
            // 
            this.doktorkayitBindingSource.DataMember = "doktorkayit";
            this.doktorkayitBindingSource.DataSource = this.randevusistemDataSet1;
            // 
            // doktorkayitTableAdapter
            // 
            this.doktorkayitTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 27);
            this.button1.TabIndex = 28;
            this.button1.Text = "<- GERİ DÖN ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doktorkayitTableAdapter1
            // 
            this.doktorkayitTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(1074, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 28);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "isim ve soyisim\'e göre arar.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Noto Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(966, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 26);
            this.label11.TabIndex = 31;
            this.label11.Text = "ARAMA :";
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1334, 581);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxDokİsim);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.comboBoxBolum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtyas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtboy);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtkilo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsaat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtisim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTAHANE RANDEVU OTOMASYONU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.randevusistemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevusistemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorkayitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevusistemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevusistemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorkayitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsaat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtkilo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private randevusistemDataSet randevusistemDataSet;
        private System.Windows.Forms.BindingSource randevularBindingSource;
        private randevusistemDataSetTableAdapters.randevularTableAdapter randevularTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxBolum;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.ComboBox comboBoxDokİsim;
        private randevusistemDataSet1 randevusistemDataSet1;
        private System.Windows.Forms.BindingSource doktorkayitBindingSource;
        private randevusistemDataSet1TableAdapters.doktorkayitTableAdapter doktorkayitTableAdapter;
        private System.Windows.Forms.Button button1;
        private randevusistemDataSet2 randevusistemDataSet2;
        private System.Windows.Forms.BindingSource doktorkayitBindingSource1;
        private randevusistemDataSet2TableAdapters.doktorkayitTableAdapter doktorkayitTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn vki;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn boy;
        private System.Windows.Forms.DataGridViewTextBoxColumn yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyet;
        private randevusistemDataSet3 randevusistemDataSet3;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private randevusistemDataSet3TableAdapters.bolumlerTableAdapter bolumlerTableAdapter;
    }
}

