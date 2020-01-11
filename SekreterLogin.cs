using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastahaneRandevuProje
{
    public partial class SekreterLogin : Form
    {
        public SekreterLogin()
        {
            InitializeComponent();
            txtSekretersifre.PasswordChar = '*';
        }

        private void btnSekreterAnasayfa_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainPage main = new MainPage();
            main.Show();
        }
        RandevuModel model = new RandevuModel();
        private void btnSekreterGirisYap_Click(object sender, EventArgs e)
        {
            string kuadi = txtSekreterKadi.Text;
            var sifree = txtSekretersifre.Text;

            bool kadiVarmi = model.sekreterkayits.Any(p => p.kullaniciad.Contains(kuadi.ToString().Trim()));
            bool sifreVarmi = model.sekreterkayits.Any(p => p.sifre.Contains(sifree.ToString().Trim()));
            
            if (kadiVarmi == true)//|| sifreVarmi ==true
            {
                if (sifreVarmi == true)
                {
                    MessageBox.Show("Başarı ile Giriş Yapıldı!");
                    Form1 form = new Form1();
                    form.Show();

                    this.Visible = false;
                   
                }
                else if (sifreVarmi == false)
                {
                    MessageBox.Show("Lütfen şifrenizi doğru giriniz!");
                }
                //this.Visible = false;
                //docForm.Show();

            }
            else if (kuadi == "" || sifree.ToString() == "")
            {
                MessageBox.Show("Lütfen Boşluk bırakmayınız!");
            }
            else
            {
                MessageBox.Show("Giriş Başarısız Tekrar Deneyiniz!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
