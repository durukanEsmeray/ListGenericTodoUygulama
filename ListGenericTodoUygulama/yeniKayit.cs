﻿using System;
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
    public partial class yeniKayit : Form
    {
        public yeniKayit()
        {
            InitializeComponent();
        }

        private void txtBaslik_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txtBaslik_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }


    }
}
