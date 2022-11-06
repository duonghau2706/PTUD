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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void kếtThúcChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPT f = new GiaiPT();
            f.ShowDialog();
        }

        private void táchTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tachTen f = new tachTen();
            f.ShowDialog();
        }

        private void máyTínhToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            calculator f = new calculator();
            f.ShowDialog();
        }

        private void đồngHồHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator f = new calculator();
            f.ShowDialog();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giảiPhươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Giải phương trình bậc 2";
            GiaiPT f = new GiaiPT();
            f.ShowDialog();
            status1.Text = "Ready";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GiaiPT f = new GiaiPT();
            f.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status3.Text = "Thời gian hệ thống: " + System.DateTime.Now.ToString();
        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DMHH f = new frm_DMHH();
            f.Show();
        }
    }
}
