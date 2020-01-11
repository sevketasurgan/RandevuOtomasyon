namespace HastahaneRandevuProje
{
    partial class DoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorGiris));
            this.dgvDoktor = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.randevusistemDataSet = new HastahaneRandevuProje.randevusistemDataSet();
            this.randevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevularTableAdapter = new HastahaneRandevuProje.randevusistemDataSetTableAdapters.randevularTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevusistemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoktor
            // 
            this.dgvDoktor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoktor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.value,
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
            this.dgvDoktor.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.dgvDoktor, "dgvDoktor");
            this.dgvDoktor.Name = "dgvDoktor";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            // 
            // value
            // 
            this.value.DataPropertyName = "value";
            resources.ApplyResources(this.value, "value");
            this.value.Name = "value";
            // 
            // isim
            // 
            this.isim.DataPropertyName = "isim";
            resources.ApplyResources(this.isim, "isim");
            this.isim.Name = "isim";
            // 
            // soyisim
            // 
            this.soyisim.DataPropertyName = "soyisim";
            resources.ApplyResources(this.soyisim, "soyisim");
            this.soyisim.Name = "soyisim";
            // 
            // bolum
            // 
            this.bolum.DataPropertyName = "bolum";
            resources.ApplyResources(this.bolum, "bolum");
            this.bolum.Name = "bolum";
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            resources.ApplyResources(this.tarih, "tarih");
            this.tarih.Name = "tarih";
            // 
            // saat
            // 
            this.saat.DataPropertyName = "saat";
            resources.ApplyResources(this.saat, "saat");
            this.saat.Name = "saat";
            // 
            // vki
            // 
            this.vki.DataPropertyName = "vki";
            resources.ApplyResources(this.vki, "vki");
            this.vki.Name = "vki";
            // 
            // doktorisim
            // 
            this.doktorisim.DataPropertyName = "doktorisim";
            resources.ApplyResources(this.doktorisim, "doktorisim");
            this.doktorisim.Name = "doktorisim";
            // 
            // kilo
            // 
            this.kilo.DataPropertyName = "kilo";
            resources.ApplyResources(this.kilo, "kilo");
            this.kilo.Name = "kilo";
            // 
            // boy
            // 
            this.boy.DataPropertyName = "boy";
            resources.ApplyResources(this.boy, "boy");
            this.boy.Name = "boy";
            // 
            // yas
            // 
            this.yas.DataPropertyName = "yas";
            resources.ApplyResources(this.yas, "yas");
            this.yas.Name = "yas";
            // 
            // cinsiyet
            // 
            this.cinsiyet.DataPropertyName = "cinsiyet";
            resources.ApplyResources(this.cinsiyet, "cinsiyet");
            this.cinsiyet.Name = "cinsiyet";
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
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoktorGiris
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDoktor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoktorGiris";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.DoktorGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevusistemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoktor;
        private randevusistemDataSet randevusistemDataSet;
        private System.Windows.Forms.BindingSource randevularBindingSource;
        private randevusistemDataSetTableAdapters.randevularTableAdapter randevularTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
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
    }
}