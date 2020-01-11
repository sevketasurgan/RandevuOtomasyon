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
    public partial class DoktorLogin : Form
    {
        public static string kalitimdoktorisim = "";
        public DoktorLogin()
        {
            InitializeComponent();
            txtdoktorSifre.PasswordChar = '*';
        }
      
        RandevuModel model = new RandevuModel();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            string kuadi = txtdoktorKadi.Text;
            var sifree = txtdoktorSifre.Text;
            bool kadiVarmi = model.doktorkayits.Any(p => p.kullaniciad.Contains(kuadi.ToString().Trim()));
            bool sifreVarmi = model.doktorkayits.Any(p => p.sifre.Contains(sifree.ToString().Trim()));
            
            if (kadiVarmi == true)
            {
                if (sifreVarmi == true)
                {
                    MessageBox.Show("Başarı ile Giriş Yapıldı!");
                    DoktorGiris docform = new DoktorGiris();
                    this.Visible = false;
                    docform.Show();
                    kalitimdoktorisim = txtdoktorKadi.Text;
                    
                }
                else if (sifreVarmi == false)
                {
                    MessageBox.Show("Lütfen şifrenizi doğru giriniz!");
                }
               

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

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage main = new MainPage();
            main.Show();
            
        }

        private void DoktorLogin_Load(object sender, EventArgs e)
        {


        }
    }
}
