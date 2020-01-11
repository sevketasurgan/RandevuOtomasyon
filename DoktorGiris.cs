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
    public partial class DoktorGiris : Form
    {
        public DoktorGiris()
        {
            InitializeComponent();
        }
        public static string kullancad;
        RandevuModel db = new RandevuModel();
        void DoldurDataGridView()
        {

            //Doktor login sayfasindan isim alınıp, isime göre listelenecek.
        }
        private void DoktorGiris_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string doktorismi = DoktorLogin.kalitimdoktorisim;
          

            dgvDoktor.DataSource = db.randevulars.Where(p => p.value.Contains(doktorismi)).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            this.Visible = false;
            main.Show();
        }
    }
}
