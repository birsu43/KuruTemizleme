namespace KuruTemizleme.App
{
    partial class SignIn
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
            txtAd = new System.Windows.Forms.TextBox();
            txtSoyad = new System.Windows.Forms.TextBox();
            txtTel = new System.Windows.Forms.TextBox();
            txtAdres = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label6 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            btnKayit = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            txtSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new System.Drawing.Point(108, 225);
            txtAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new System.Drawing.Size(186, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new System.Drawing.Point(440, 225);
            txtSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new System.Drawing.Size(202, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtTel
            // 
            txtTel.Location = new System.Drawing.Point(440, 310);
            txtTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTel.Name = "txtTel";
            txtTel.Size = new System.Drawing.Size(202, 27);
            txtTel.TabIndex = 4;
            // 
            // txtAdres
            // 
            txtAdres.Location = new System.Drawing.Point(108, 405);
            txtAdres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new System.Drawing.Size(186, 27);
            txtAdres.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(50, 229);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(28, 20);
            label1.TabIndex = 6;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(359, 229);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 314);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 20);
            label3.TabIndex = 8;
            label3.Text = "Cinsiyet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(353, 314);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 20);
            label4.TabIndex = 9;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(31, 412);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 20);
            label5.TabIndex = 10;
            label5.Text = "Adres";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_sign_in_78;
            pictureBox1.Location = new System.Drawing.Point(269, 15);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 101);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(262, 120);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(129, 39);
            label6.TabIndex = 12;
            label6.Text = "Kayıt Ol";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "  ", "Kadın", "Erkek", "Diğer" });
            comboBox1.Location = new System.Drawing.Point(108, 308);
            comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(184, 28);
            comboBox1.TabIndex = 13;
            // 
            // btnKayit
            // 
            btnKayit.Location = new System.Drawing.Point(269, 499);
            btnKayit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new System.Drawing.Size(151, 42);
            btnKayit.TabIndex = 14;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(359, 408);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(39, 20);
            label7.TabIndex = 15;
            label7.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Location = new System.Drawing.Point(440, 405);
            txtSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new System.Drawing.Size(202, 27);
            txtSifre.TabIndex = 16;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Thistle;
            ClientSize = new System.Drawing.Size(692, 582);
            Controls.Add(txtSifre);
            Controls.Add(label7);
            Controls.Add(btnKayit);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAdres);
            Controls.Add(txtTel);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SignIn";
            Text = "SignIn";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSifre;
    }
}