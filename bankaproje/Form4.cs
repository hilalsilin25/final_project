
using System.Data.SqlClient;



namespace bankaprojesi
{

    public partial class Form4 : Form
    {
        public Form4()
        {

            InitializeComponent();
        }
        private decimal gondericiBakiye = 50000m; // Başlangıç bakiyesi
        private decimal miktar;
        private object gondericiHesap;
        private object aliciHesapNo;

        private void btnOnayla_Click(object sender, EventArgs e)
        {

            // Hesap numarası ve tutarları al
            string senderName = txtGondericiAdSoyad.Text.Trim();
            string receiverAccount = txtAlıcıHesapNumarası.Text.Trim();
            string receiverName = txtAlıcıAdSoyad.Text.Trim();
            string amountText = txtTutar.Text.Trim();

            decimal amount;
            decimal mevcutLimit = 50000; // Belirlenen limit

            errorProvider.Clear();
            bool isValid = true;

            // Alıcı hesap numarasının doğruluğunu kontrol et
            if (!ValidateAccountNumber(receiverAccount))
            {
                errorProvider.SetError(txtAlıcıHesapNumarası, "Hesap numarası geçerli olmalı ve 'TR' ile başlamalı, 24 haneli olmalıdır.");
                isValid = false;
            }

            // Para miktarı kontrolü
            if (string.IsNullOrEmpty(amountText) || !decimal.TryParse(amountText, out amount) || amount <= 0)
            {
                errorProvider.SetError(txtTutar, "Geçerli bir miktar girin.");
                isValid = false;
            }
            else if (amount > mevcutLimit)
            {
                errorProvider.SetError(txtTutar, "Gönderilen tutar mevcut limitten fazla olamaz.");
                isValid = false;
            }
            if (miktar > gondericiBakiye)
            {
                MessageBox.Show("Yetersiz bakiye! Lütfen geçerli bir tutar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gondericiBakiye -= miktar;
            MessageBox.Show($"Transfer başarılı!\nKalan bakiye: {gondericiBakiye:C}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Tüm kontroller başarılıysa
            if (isValid)


            {
                MessageBox.Show($"Transfer Başarılı!\nGönderen Hesap: {senderName}\nAlıcı Hesap: {receiverAccount}\nMiktar: " +
                    $"{ToString}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Girişleri temizle
                txtGondericiAdSoyad.Clear();
                txtAlıcıHesapNumarası.Clear();
                txtAlıcıAdSoyad.Clear();
                txtTutar.Clear();
            }

            decimal tutar;
            if (!decimal.TryParse(txtTutar.Text, out tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir tutar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tutar > gondericiBakiye)
            {
                MessageBox.Show("Yetersiz bakiye! Lütfen geçerli bir tutar girin.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Bakiye güncelle
            gondericiBakiye -= tutar;

            // Başarılı mesajı
            MessageBox.Show($"Transfer başarılı!\nKalan bakiye: {gondericiBakiye:C}", "Başarılı",
                MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
        // Alıcı hesap numarasının doğruluğunu kontrol et
        private bool ValidateAccountNumber(string accountNumber)
        {
            // Hesap numarasının 'TR' ile başlayıp başlamadığını kontrol et
            if (!accountNumber.StartsWith("TR"))
            {
                return false;
            }

            // Hesap numarasının 24 haneli olup olmadığını kontrol et
            if (accountNumber.Length != 26)
            {
                return false;
            }

            // Hesap numarasındaki sadece rakamların geçerli olduğunu kontrol et
            if (!accountNumber.Substring(2).All(char.IsDigit))
            {
                return false;
            }

            return true;
        }

        private void txtAlıcıHesapNumarası_KeyPress(object sender, KeyPressEventArgs e)
        {

            // İlk iki karakter 'TR' olacak şekilde ayarla
            if (txtAlıcıHesapNumarası.Text.Length < 2 && !char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Sadece 'TR' harflerine izin ver
            }
            // Sonraki karakterler için sadece rakamlar kabul edilir
            else if (txtAlıcıHesapNumarası.Text.Length >= 2 && txtAlıcıHesapNumarası.Text.Length < 26 && !char.IsDigit(e.KeyChar)
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Sayı dışında karakterler engellenir
            }
            // 26 karakterden fazla girilmesine izin verilmez
            else if (txtAlıcıHesapNumarası.Text.Length >= 26 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // 26. karakterden sonrasına izin verilmez
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

       
    }

    /*  private bool ValidateAccountNumber(string receiverAccount)
      {
          throw new NotImplementedException();
      }*/
}





