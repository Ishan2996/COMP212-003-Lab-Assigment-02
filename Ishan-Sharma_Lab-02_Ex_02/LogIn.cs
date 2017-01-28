using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ishan_Sharma_Lab_02_Ex_02
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            lblUsername.Text = userControl.UserName;
            lblPassword.Text = userControl.Password;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
