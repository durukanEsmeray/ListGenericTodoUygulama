﻿namespace ListGenericTodoUygulama
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlIslemListesi = new System.Windows.Forms.Panel();
            this.grpBoxIslemListe = new System.Windows.Forms.GroupBox();
            this.btnUygulamaKapat = new System.Windows.Forms.Button();
            this.btnKayitListe = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblZaman = new System.Windows.Forms.Label();
            this.tmZamanla = new System.Windows.Forms.Timer(this.components);
            this.pnlIslemListesi.SuspendLayout();
            this.grpBoxIslemListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIslemListesi
            // 
            this.pnlIslemListesi.Controls.Add(this.grpBoxIslemListe);
            this.pnlIslemListesi.Controls.Add(this.pictureBox1);
            this.pnlIslemListesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIslemListesi.Location = new System.Drawing.Point(0, 0);
            this.pnlIslemListesi.Name = "pnlIslemListesi";
            this.pnlIslemListesi.Size = new System.Drawing.Size(226, 609);
            this.pnlIslemListesi.TabIndex = 1;
            this.pnlIslemListesi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIslemListesi_Paint);
            // 
            // grpBoxIslemListe
            // 
            this.grpBoxIslemListe.Controls.Add(this.btnUygulamaKapat);
            this.grpBoxIslemListe.Controls.Add(this.btnKayitListe);
            this.grpBoxIslemListe.Controls.Add(this.btnYeniKayit);
            this.grpBoxIslemListe.Location = new System.Drawing.Point(12, 209);
            this.grpBoxIslemListe.Name = "grpBoxIslemListe";
            this.grpBoxIslemListe.Size = new System.Drawing.Size(187, 233);
            this.grpBoxIslemListe.TabIndex = 1;
            this.grpBoxIslemListe.TabStop = false;
            this.grpBoxIslemListe.Text = "İşlem Listesi";
            // 
            // btnUygulamaKapat
            // 
            this.btnUygulamaKapat.Location = new System.Drawing.Point(6, 91);
            this.btnUygulamaKapat.Name = "btnUygulamaKapat";
            this.btnUygulamaKapat.Size = new System.Drawing.Size(175, 29);
            this.btnUygulamaKapat.TabIndex = 2;
            this.btnUygulamaKapat.Text = "Uygulamayı Kapat";
            this.btnUygulamaKapat.UseVisualStyleBackColor = true;
            this.btnUygulamaKapat.Click += new System.EventHandler(this.btnUygulamaKapat_Click);
            // 
            // btnKayitListe
            // 
            this.btnKayitListe.Location = new System.Drawing.Point(6, 56);
            this.btnKayitListe.Name = "btnKayitListe";
            this.btnKayitListe.Size = new System.Drawing.Size(175, 29);
            this.btnKayitListe.TabIndex = 1;
            this.btnKayitListe.Text = "Kayıt Listele";
            this.btnKayitListe.UseVisualStyleBackColor = true;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(6, 21);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(175, 29);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblZaman);
            this.panel1.Location = new System.Drawing.Point(980, 556);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 53);
            this.panel1.TabIndex = 2;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(45, 16);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(150, 22);
            this.lblZaman.TabIndex = 0;
            this.lblZaman.Text = "31.03.2023 10:05";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlIslemListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Todo - Uygulaması 2023";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlIslemListesi.ResumeLayout(false);
            this.grpBoxIslemListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIslemListesi;
        private System.Windows.Forms.GroupBox grpBoxIslemListe;
        private System.Windows.Forms.Button btnUygulamaKapat;
        private System.Windows.Forms.Button btnKayitListe;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer tmZamanla;
    }
}

