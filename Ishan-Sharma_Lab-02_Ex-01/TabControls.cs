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

            System.Diagnostics.Process.Start(textBox1.Text);
        }

        private void lblCanada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblCanada.LinkVisited = true;

            System.Diagnostics.Process.Start("textBox2.Text");
        }

        private void lblUSA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblUSA.LinkVisited = true;

            System.Diagnostics.Process.Start("textBox3.Text");
        }

        private void lblFrance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblFrance.LinkVisited = true;

            System.Diagnostics.Process.Start("textBox4.Text");
        }

        private void lblLondon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblLondon.LinkVisited = true;

            System.Diagnostics.Process.Start("textBox5.Text");
        }

        private void lblSydney_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblSydney.LinkVisited = true;

            System.Diagnostics.Process.Start("textBox6.Text");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkLabel[] linklabel = { lblIndia, lblCanada, lblUSA, lblFrance, lblLondon, lblSydney };
            foreach (int checkIndex in checkedListBox.CheckedIndices)
            {
                linklabel[checkIndex].Visible = true;
            }
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
