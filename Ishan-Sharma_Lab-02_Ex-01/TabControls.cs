using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ishan_Sharma_Lab_02_Ex_01
{
    public partial class TabControls : Form
    {
        public TabControls()
        {
            InitializeComponent();
        }

        private void lblIndia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblIndia.LinkVisited = true;

            System.Diagnostics.Process.Start("https://india.gov.in/");
        }

        private void lblCanada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblCanada.LinkVisited = true;

            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Canada");
        }

        private void lblUSA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblUSA.LinkVisited = true;

            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/United_States");
        }

        private void lblFrance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblFrance.LinkVisited = true;

            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/France");
        }

        private void lblLondon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblLondon.LinkVisited = true;

            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/London");
        }

        private void lblSydney_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblSydney.LinkVisited = true;

            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Sydney");
        }
    }
}
