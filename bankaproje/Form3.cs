using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bankaprojesi
{
    public partial class Form3 : Form
    {
     


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 yeniForm = new Form7();
            //yeni formu aç

            string CorrectCode = "NfTr90";

            // txtSecurityCode kontrolünün Text değerini al
            if (txtSecurityCode.Text == CorrectCode)
            {
                MessageBox.Show("Doğru güvenlik kodu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güvenlik kodu yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            yeniForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan T.C.Kimlik No
            string TCKimlikNo = textBox1.Text;


            // T.C.Kimlik No uzunluk
            if (TCKimlikNo.Length > 11)
            {
                MessageBox.Show("T.C.Kimlik No en fazla 11 karakter olmalıdır.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan Cep Telefonu
            string CepTelefonu = textBox2.Text;


            //  Cep Telefonu uzunluk
            if (CepTelefonu.Length > 11)
            {
                MessageBox.Show("Cep Telefonu en fazla 11 karakter olmalıdır.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}

