using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankaprojesi
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            // Form ayarları
            this.Text = "Şifre Yenileme";
            // Form öğeleri
            Label lblUsername = new Label
            {
                Text = "Kullanıcı Adı:",
                Location = new Point(20, 20),
                AutoSize = true
            };

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan şifreler
            string YeniŞifre = textBox1.Text;
            string ŞifreyiDoğrula = textBox2.Text;
            {


                // Şifrelerin eşleşip eşleşmediğini kontrol et
                if (YeniŞifre != ŞifreyiDoğrula)
                {
                    MessageBox.Show("Şifreler eşleşmiyor! Lütfen tekrar deneyin.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Şifreniz başarıyla güncellenmiştir.", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Şifre minimum uzunluk kontrolü
                if (YeniŞifre.Length < 6)
                {
                    MessageBox.Show("Şifre en az 6 karakter olmalıdır.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }
    }
}
