namespace bankaprojesi
{
    partial class Form2
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
            label3 = new Label();
            hesaphareketleri = new Button();
            Paratransferi = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(hesaphareketleri);
            groupBox1.Controls.Add(Paratransferi);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(58, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 387);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ana Sayfa";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DeepSkyBlue;
            label3.Location = new Point(312, 131);
            label3.Name = "label3";
            label3.Size = new Size(242, 20);
            label3.TabIndex = 5;
            label3.Text = "TR25 0006 1907 1978 6457 8413 25";
            // 
            // hesaphareketleri
            // 
            hesaphareketleri.BackColor = Color.DeepSkyBlue;
            hesaphareketleri.Location = new Point(367, 233);
            hesaphareketleri.Name = "hesaphareketleri";
            hesaphareketleri.Size = new Size(149, 29);
            hesaphareketleri.TabIndex = 3;
            hesaphareketleri.Text = "Hesap Hareketleri";
            hesaphareketleri.UseVisualStyleBackColor = false;
            hesaphareketleri.Click += hesaphareketleri_Click;
            // 
            // Paratransferi
            // 
            Paratransferi.BackColor = Color.DeepSkyBlue;
            Paratransferi.ForeColor = SystemColors.ControlText;
            Paratransferi.Location = new Point(141, 234);
            Paratransferi.Name = "Paratransferi";
            Paratransferi.Size = new Size(107, 28);
            Paratransferi.TabIndex = 2;
            Paratransferi.Text = "Para Transferi";
            Paratransferi.UseVisualStyleBackColor = false;
            Paratransferi.Click += Paratransferi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DeepSkyBlue;
            label2.Location = new Point(130, 131);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "Hesap Numarası";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button hesaphareketleri;
        private Button Paratransferi;
        private Label label2;
        private Label label3;
    }
}