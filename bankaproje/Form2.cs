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


    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Paratransferi_Click(object sender, EventArgs e)
        {

            Form4 yeniForm = new Form4();
            //yeni formu aç
            yeniForm.Show();

        }

        private void hesaphareketleri_Click(object sender, EventArgs e)
        {
            Form5 yeniForm = new Form5();
            // yeni formu aç
            yeniForm.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
