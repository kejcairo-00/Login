﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmCart Cart = new frmCart();
            Cart.Show();
            this.Close();
        }
    }
}
