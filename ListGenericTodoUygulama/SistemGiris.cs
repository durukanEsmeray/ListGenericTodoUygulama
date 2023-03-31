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
    public partial class SistemGiris : Form
    {
        public SistemGiris()
        {
            InitializeComponent();
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtKullaniciAdi.Text) || !string.IsNullOrEmpty(txtSifre.Text))
            {

            }
            else
            {
                MessageBox.Show("Lütfen giriş bilgilerinizi eksiksiz olarak giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
