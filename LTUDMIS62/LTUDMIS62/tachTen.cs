using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDMIS62
{
    public partial class tachTen : Form
    {

        public tachTen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            int vt = input.IndexOf(" ");
            res.Text = input.Substring(vt, input.Length - vt);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            /* string input = txtInput.Text.Trim();
             int vt1 = input.IndexOf(" ");
             int vt2 = input.LastIndexOf(" ");
             res.Text = input.Substring(vt1, vt2 - vt1);*/
             name(txtInput.Text.Trim());
        }

        private string name(string s)
        {
            string input = s;
            int vt1 = input.IndexOf(" ");
            int vt2 = input.LastIndexOf(" ");
            res.Text = input.Substring(vt1, vt2 - vt1);
            return res.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            int vt = input.LastIndexOf(" ");
            res.Text = input.Substring(0, vt);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
