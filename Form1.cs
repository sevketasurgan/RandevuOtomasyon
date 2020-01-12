using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace HastahaneRandevuProje
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        //RandevuModel model = new RandevuModel();
        randevular model = new randevular();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'randevusistemDataSet3.bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.randevusistemDataSet3.bolumler);
            // TODO: This line of code loads data into the 'randevusistemDataSet2.doktorkayit' table. You can move, or remove it, as needed.
            this.doktorkayitTableAdapter1.Fill(this.randevusistemDataSet2.doktorkayit);
            // TODO: This line of code loads data into the 'randevusistemDataSet1.doktorkayit' table. You can move, or remove it, as needed.
            this.doktorkayitTableAdapter.Fill(this.randevusistemDataSet1.doktorkayit);
            DoldurDataGridView();
            temizle();

           

        }
        void temizle()
        {
           comboBoxDokİsim.Text = comboBoxBolum.Text = maskedTextBoxBoy.Text = comboBoxCinsiyet.Text =  txtisim.Text = txtkilo.Text = maskedTextBoxSaat.Text = txtsoyisim.Text = maskedTextBoxTarih.Text = txtyas.Text = "";
            btnEkle.Text = "Ekle";
            btnSil.Enabled = false;
            model.id = 0;
            

        }

        void DoldurDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (RandevuModel db = new RandevuModel())
            {
                dataGridView1.DataSource = db.randevulars.ToList<randevular>();


            }

        }
        
        private void btniptal_Click(object sender, EventArgs e)
        {
            temizle();
        }
        // vki hesaplama
        //private int kitle_indeks { get; set; }
        //public int mi
        //{
        //    get { return kitle_indeks; }
        //    set
        //    {
        //       
        //        vkihesap = value;
        //    }
        //}
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            double boyy = Convert.ToDouble(maskedTextBoxBoy.Text);
            double kilo = Convert.ToDouble(txtkilo.Text);
            double vkihesap = kilo / (boyy * 2);
            


            string val = comboBoxDokİsim.SelectedValue.ToString();
             // vücut kitle indeks hesaplaması eklenecek
            model.isim = txtisim.Text.Trim().ToUpper();
            model.soyisim = txtsoyisim.Text.Trim().ToUpper();
            model.bolum = comboBoxBolum.Text.Trim();
            model.cinsiyet = comboBoxCinsiyet.Text.Trim();
            model.doktorisim = comboBoxDokİsim.Text;
            model.kilo = txtkilo.Text.Trim();
            model.tarih = maskedTextBoxTarih.Text;
            model.saat = maskedTextBoxSaat.Text;//textbox  maskedtextbox ile değişti
            model.boy = maskedTextBoxBoy.Text;
            model.vki = Convert.ToInt32(vkihesap).ToString();
            model.yas = txtyas.Text.Trim();
            model.value = val;
           

            using (RandevuModel db = new RandevuModel())
            {
                if(model.id == 0) { //Insert
                db.randevulars.Add(model);
                }
                else//update
                {
                    db.Entry(model).State = EntityState.Modified;
                }
                db.SaveChanges();

            }
            temizle();
            MessageBox.Show("Hasta Kayıt İşlemi Başarı ile Gerçekleştirildi!");
            DoldurDataGridView();
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string val = comboBoxDokİsim.SelectedValue.ToString();//Doktor isim combobox ın seçili değeri.
            if (dataGridView1.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                using (RandevuModel db = new RandevuModel())
                {
                    model = db.randevulars.Where(x => x.id == model.id).FirstOrDefault();
                    
                        comboBoxBolum.Text = model.bolum;
                        maskedTextBoxBoy.Text = model.boy;
                        comboBoxCinsiyet.Text = model.cinsiyet;
                        comboBoxDokİsim.Text = model.doktorisim;
                        txtisim.Text = model.isim;
                        txtkilo.Text = model.kilo;
                        maskedTextBoxSaat.Text = model.saat;
                        txtsoyisim.Text = model.soyisim;
                        maskedTextBoxTarih.Text = model.tarih;
                        txtyas.Text = model.yas;
                        val = model.value; // value değerini tutuyoruz.dgvDoktor da filtreleme için.
                        


                    
                    
                  
                }
                btnEkle.Text = "Güncelle";
                btnSil.Enabled = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize emin misiniz ?", "Veri Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RandevuModel db = new RandevuModel())
                {
                    //var entry = db.Entry(model);
                    //if (entry.State == EntityState.Detached)
                    //    db.randevulars.Attach(model);
                    var deleteVal = db.randevulars.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value));

                    //db.randevulars.Remove(model);
                    db.randevulars.Remove(deleteVal);
                    db.SaveChanges();
                    DoldurDataGridView();
                    temizle();
                    MessageBox.Show("Başarı ile silindi!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            this.Visible = false;
            main.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          
        }

        private void dateTimePickerAna_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (RandevuModel db = new RandevuModel())
            {
                dataGridView1.DataSource = db.randevulars.Where(p =>  p.isim.Contains(textBox1.Text) || p.soyisim.Contains(textBox1.Text)).ToList();
            }
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
