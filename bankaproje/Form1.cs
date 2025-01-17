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
           

            // Form ��eleri
            Label lblUsername = new Label
            {
                Text = "Kullan�c� Ad�:",
                AutoSize = true
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form3 yeniForm= new Form3();
            //yeni formu a�
            yeniForm.Show();

        }

        private void Giri�_Click(object sender, EventArgs e)
        {
            Form2 yeniForm = new Form2();
            //yeni formu a�

            textBox1.Text = "11";
            textBox2.Text = "6";
           

            // Kullan�c�dan al�nan �ifre
            string �ifre = textBox2.Text;

            // �ifre uzunluk
            if (�ifre.Length > 6)
            {
                MessageBox.Show("�ifre en fazla 6 karakter olmal�d�r.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kullan�c� ad� ve �ifreyi al
            string kullan�c�Ad� = textBox2.Text;
            string �ifre = �ifre.Trim();

            // Alanlar bo�sa uyar� g�ster ve devam etme
            if (string.IsNullOrEmpty(kullan�c�Ad�) || string.IsNullOrEmpty(�ifre))
            {
                MessageBox.Show("L�tfen t�m alanlar� doldurun.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Giri� yap�lmas�n� engeller
            }
            else
            {
                // Bilgiler doluysa i�lem devam eder (buraya giri� i�lemi kodu yaz�l�r)
                MessageBox.Show("Giri� ba�ar�l�!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yeniForm.Show();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Kullan�c�dan al�nan T.C.Kimlik No
            string TCKimlikNo = textBox1.Text;


            // T.C.Kimlik No uzunluk
            if (TCKimlikNo.Length > 11)
            {
                MessageBox.Show("T.C.Kimlik No en fazla 11 karakter olmal�d�r.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Kullan�c�dan al�nan �ifre
            string �ifre = textBox2.Text;

            // �ifre uzunluk
            if (�ifre.Length > 6)
            {
                MessageBox.Show("�ifre en fazla 6 karakter olmal�d�r.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

    }
}
