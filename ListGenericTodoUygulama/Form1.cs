using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListGenericTodoUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlIslemListesi_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ButonAcKapa(bool kontrol)
        {
            foreach (Control item in grpBoxIslemListe.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Enabled = kontrol;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmZamanla.Interval = 15000; // her 15sn de bir çalışıp, vermiş olduğum işlemi yapmaya çalışacak.
            tmZamanla.Tick += TmZamanla_Tick;
            tmZamanla.Start();

            ButonAcKapa(false);

            SistemGiris kullaniciKontrol = new SistemGiris();
            kullaniciKontrol.MdiParent = this;
            kullaniciKontrol.StartPosition = FormStartPosition.CenterScreen;
            kullaniciKontrol.Show();
        }

        private void TmZamanla_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm");
        }

        private void btnUygulamaKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
