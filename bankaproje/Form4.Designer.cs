namespace bankaprojesi
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            errorProvider = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            txtTutar = new TextBox();
            txtAlıcıHesapNumarası = new TextBox();
            txtAlıcıAdSoyad = new TextBox();
            txtGondericiAdSoyad = new TextBox();
            btnOnayla = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(txtTutar);
            groupBox1.Controls.Add(txtAlıcıHesapNumarası);
            groupBox1.Controls.Add(txtAlıcıAdSoyad);
            groupBox1.Controls.Add(txtGondericiAdSoyad);
            groupBox1.Controls.Add(btnOnayla);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(50, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 375);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Para Transferi";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(246, 250);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(125, 27);
            txtTutar.TabIndex = 8;
            // 
            // txtAlıcıHesapNumarası
            // 
            txtAlıcıHesapNumarası.Location = new Point(246, 182);
            txtAlıcıHesapNumarası.Name = "txtAlıcıHesapNumarası";
            txtAlıcıHesapNumarası.Size = new Size(125, 27);
            txtAlıcıHesapNumarası.TabIndex = 7;
            txtAlıcıHesapNumarası.KeyPress += txtAlıcıHesapNumarası_KeyPress;
            // 
            // txtAlıcıAdSoyad
            // 
            txtAlıcıAdSoyad.Location = new Point(246, 112);
            txtAlıcıAdSoyad.Name = "txtAlıcıAdSoyad";
            txtAlıcıAdSoyad.Size = new Size(125, 27);
            txtAlıcıAdSoyad.TabIndex = 6;
            // 
            // txtGondericiAdSoyad
            // 
            txtGondericiAdSoyad.Location = new Point(246, 47);
            txtGondericiAdSoyad.Name = "txtGondericiAdSoyad";
            txtGondericiAdSoyad.Size = new Size(125, 27);
            txtGondericiAdSoyad.TabIndex = 5;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.Red;
            btnOnayla.Location = new Point(264, 325);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(94, 29);
            btnOnayla.TabIndex = 4;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DeepSkyBlue;
            label4.Location = new Point(19, 253);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "Tutar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DeepSkyBlue;
            label3.Location = new Point(11, 182);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 2;
            label3.Text = "Alıcı Hesap Numarası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DeepSkyBlue;
            label2.Location = new Point(19, 112);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Alıcı Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DeepSkyBlue;
            label1.Location = new Point(19, 47);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Gönderici Ad Soyad";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider;
        private TextBox txtAliciHesapNumarasi_KeyPress;
        private GroupBox groupBox1;
        private TextBox txtTutar;
        private TextBox txtAlıcıHesapNumarası;
        private TextBox txtAlıcıAdSoyad;
        private TextBox txtGondericiAdSoyad;
        private Button btnOnayla;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}