using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmSignIn frmSignIn = new frmSignIn();
            frmSignIn.ShowDialog();
        }
        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            frmForgorPass RecoverAccount = new frmForgorPass();
            RecoverAccount.ShowDialog();           
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {           
            frmHome HomePage = new frmHome();
            HomePage.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            Home.ShowDialog();
        }
    }
}
