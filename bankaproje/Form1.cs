using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;



namespace bankaprojesi
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

            // Form öðeleri
            Label lblUsername = new Label
            {
                Text = "Kullanýcý Adý:",
                AutoSize = true
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form3 yeniForm= new Form3();
            //yeni formu aç
            yeniForm.Show();

        }

        private void Giriþ_Click(object sender, EventArgs e)
        {
            Form2 yeniForm = new Form2();
            //yeni formu aç

            textBox1.Text = "11";
            textBox2.Text = "6";
           

            // Kullanýcýdan alýnan Þifre
            string Þifre = textBox2.Text;

            // Þifre uzunluk
            if (Þifre.Length > 6)
            {
                MessageBox.Show("Þifre en fazla 6 karakter olmalýdýr.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kullanýcý adý ve þifreyi al
            string kullanýcýAdý = textBox2.Text;
            string þifre = Þifre.Trim();

            // Alanlar boþsa uyarý göster ve devam etme
            if (string.IsNullOrEmpty(kullanýcýAdý) || string.IsNullOrEmpty(þifre))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Giriþ yapýlmasýný engeller
            }
            else
            {
                // Bilgiler doluysa iþlem devam eder (buraya giriþ iþlemi kodu yazýlýr)
                MessageBox.Show("Giriþ baþarýlý!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yeniForm.Show();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Kullanýcýdan alýnan T.C.Kimlik No
            string TCKimlikNo = textBox1.Text;


            // T.C.Kimlik No uzunluk
            if (TCKimlikNo.Length > 11)
            {
                MessageBox.Show("T.C.Kimlik No en fazla 11 karakter olmalýdýr.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Kullanýcýdan alýnan Þifre
            string Þifre = textBox2.Text;

            // Þifre uzunluk
            if (Þifre.Length > 6)
            {
                MessageBox.Show("Þifre en fazla 6 karakter olmalýdýr.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

    }
}
