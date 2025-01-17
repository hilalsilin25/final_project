namespace bankaprojesi
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtTutar = new TextBox();
            txtAliciHesapNumarasi = new TextBox();
            txtAliciAdSoyad = new TextBox();
            txtGondericiAdSoyad = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btnçek = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(txtTutar);
            groupBox1.Controls.Add(txtAliciHesapNumarasi);
            groupBox1.Controls.Add(txtAliciAdSoyad);
            groupBox1.Controls.Add(txtGondericiAdSoyad);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(75, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 360);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesap Hareketleri";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(312, 233);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(125, 27);
            txtTutar.TabIndex = 6;
            // 
            // txtAliciHesapNumarasi
            // 
            txtAliciHesapNumarasi.Location = new Point(312, 200);
            txtAliciHesapNumarasi.Name = "txtAliciHesapNumarasi";
            txtAliciHesapNumarasi.Size = new Size(125, 27);
            txtAliciHesapNumarasi.TabIndex = 5;
            // 
            // txtAliciAdSoyad
            // 
            txtAliciAdSoyad.Location = new Point(312, 167);
            txtAliciAdSoyad.Name = "txtAliciAdSoyad";
            txtAliciAdSoyad.Size = new Size(125, 27);
            txtAliciAdSoyad.TabIndex = 4;
            // 
            // txtGondericiAdSoyad
            // 
            txtGondericiAdSoyad.Location = new Point(312, 123);
            txtGondericiAdSoyad.Name = "txtGondericiAdSoyad";
            txtGondericiAdSoyad.Size = new Size(125, 27);
            txtGondericiAdSoyad.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(6, 37);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Görüntüle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnçek
            // 
            btnçek.Location = new Point(857, 370);
            btnçek.Name = "btnçek";
            btnçek.Size = new Size(94, 29);
            btnçek.TabIndex = 1;
            btnçek.Text = "btnVeriCek";
            btnçek.UseVisualStyleBackColor = true;
            btnçek.Click += btnçek_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button1;
            ClientSize = new Size(1152, 518);
            Controls.Add(btnçek);
            Controls.Add(groupBox1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox txtTutar;
        private TextBox txtAliciHesapNumarasi;
        private TextBox txtAliciAdSoyad;
        private TextBox txtGondericiAdSoyad;
        private Button btnçek;
    }
}