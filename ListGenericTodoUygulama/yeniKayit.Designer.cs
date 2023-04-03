namespace ListGenericTodoUygulama
{
    partial class yeniKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtKisaAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOnemDerecesi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(134, 31);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(214, 22);
            this.txtBaslik.TabIndex = 0;
            this.txtBaslik.Enter += new System.EventHandler(this.txtBaslik_Enter);
            this.txtBaslik.Leave += new System.EventHandler(this.txtBaslik_Leave);
            // 
            // txtKisaAciklama
            // 
            this.txtKisaAciklama.Location = new System.Drawing.Point(134, 59);
            this.txtKisaAciklama.Multiline = true;
            this.txtKisaAciklama.Name = "txtKisaAciklama";
            this.txtKisaAciklama.Size = new System.Drawing.Size(214, 82);
            this.txtKisaAciklama.TabIndex = 1;
            this.txtKisaAciklama.Enter += new System.EventHandler(this.txtBaslik_Enter);
            this.txtKisaAciklama.Leave += new System.EventHandler(this.txtBaslik_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kısa Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(134, 147);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(214, 82);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.Enter += new System.EventHandler(this.txtBaslik_Enter);
            this.txtAciklama.Leave += new System.EventHandler(this.txtBaslik_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama";
            // 
            // txtOnemDerecesi
            // 
            this.txtOnemDerecesi.Location = new System.Drawing.Point(134, 234);
            this.txtOnemDerecesi.Name = "txtOnemDerecesi";
            this.txtOnemDerecesi.Size = new System.Drawing.Size(214, 22);
            this.txtOnemDerecesi.TabIndex = 3;
            this.txtOnemDerecesi.Enter += new System.EventHandler(this.txtBaslik_Enter);
            this.txtOnemDerecesi.Leave += new System.EventHandler(this.txtBaslik_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Önem Derecesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durum";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanamadı",
            "İptal edildi",
            "Ertelendi"});
            this.cmbDurum.Location = new System.Drawing.Point(134, 267);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(214, 24);
            this.cmbDurum.TabIndex = 4;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(134, 297);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(214, 40);
            this.btnYeniKayit.TabIndex = 5;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            // 
            // yeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 349);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOnemDerecesi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKisaAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "yeniKayit";
            this.Text = "Todo - Yeni Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtKisaAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOnemDerecesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Button btnYeniKayit;
    }
}