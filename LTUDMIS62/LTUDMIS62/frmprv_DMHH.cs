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
    public partial class frmprv_DMHH : Form
    {
        public frmprv_DMHH(rptDMHH rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void frmprv_DMHH_Load(object sender, EventArgs e)
        {

        }
    }
}
