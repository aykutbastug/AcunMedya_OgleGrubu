﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            lblAdiSoyadi.Text = UygulamaAyarlari.GirisYapanPersonel.Adi + " " + UygulamaAyarlari.GirisYapanPersonel.Soyadi;
            lblEmail.Text = UygulamaAyarlari.GirisYapanPersonel.EMail;
        }
    }
}