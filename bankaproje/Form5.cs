using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System.Data.SqlClient;
using System.Windows.Forms;




namespace bankaprojesi
{

    public partial class Form5 : Form
    {


        public Form5()
        {
            InitializeComponent();



        }



        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=HİLAL\\EXPLORER;Database=banka_projesi;User Id=HİLAL;Password=123456;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Bağlantı başarılı!");
                    NewMethod(connectionString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message);
                }
            }


        }

        private static void NewMethod(string connectionString)
        {

            // Veritabanı işlemleri
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO AccountTransactions (SenderAccountNumber, ReceiverAccountNumber," +
                        " SenderName, ReceiverName, Amount, TransactionType, Description, Status) " +
                                   "VALUES (@SenderAccountNumber, @ReceiverAccountNumber, @SenderName, @ReceiverName," +
                                   " @Amount, @TransactionType, @Description, @Status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri tanımla
                        command.Parameters.AddWithValue("@SenderAccountNumber", "TR123456789012345678901234");
                        command.Parameters.AddWithValue("@ReceiverAccountNumber", "TR987654321098765432109876");
                        command.Parameters.AddWithValue("@SenderName", "Ali Veli");
                        command.Parameters.AddWithValue("@ReceiverName", "Ahmet Yılmaz");
                        command.Parameters.AddWithValue("@Amount", 5000.00);
                        command.Parameters.AddWithValue("@TransactionType", "Para Transferi");
                        command.Parameters.AddWithValue("@Description", "Bankadan para transferi");
                        command.Parameters.AddWithValue("@Status", "Başarılı");

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Hesap hareketi başarıyla kaydedildi.");
                        }
                        else
                        {
                            MessageBox.Show("Hesap hareketi kaydedilemedi.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnçek_Click(object sender, EventArgs e)
        {
           
            {
                // Bağlantı dizesi
                string connectionString = "string connectionString = \"Server=DESKTOP-12345\\\\SQLEXPRESS;Database=BankaProjesi;Trusted_Connection=True;\";\r\n";

                // SQL sorgusu
                string query = "SELECT * FROM [Hesap bilgileri]";



                // DataTable oluştur
                DataTable dataTable = new DataTable();

                try
                {
                    // SQL bağlantısını aç
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // SQL komutunu hazırla
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Verileri oku
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable); // Verileri DataTable'a doldur
                            }
                        }
                    }

                    // Verileri DataGridView'e ata
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }



        }
    }
}