using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace LTUDMIS62
{
    public partial class frm_DMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;

        public frm_DMHH()
        {
            InitializeComponent();
        }

        private void frm_DMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-MA2UE8D\\HAU123;"
                + "Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select Manhom, Mahh, Tenhh, dvt, Dgvnd, sanxuat from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdData.RowCount;
            grdData.CurrentCell = grdData[0, i-2];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i < grdData.RowCount - 1) i++;
            else i = 0;
            grdData.CurrentCell = grdData[0, i];
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i > 0) i--;
            else i = grdData.RowCount - 2;
            grdData.CurrentCell = grdData[0, i];
            NapCT();
        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "select distinct " + comTenTruong.Text + " from tblDmhh";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGiaTri.DataSource = comdt;
            comGiaTri.DisplayMember = comTenTruong.Text;
        }

        private void btnFillter_Click(object sender, EventArgs e)
        {
            sql = "select Manhom, Mahh, Tenhh, dvt, Dgvnd, sanxuat from tblDMHH"
            + " where " + comTenTruong.Text + " = N'" + comGiaTri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnClearFillter_Click(object sender, EventArgs e)
        {
            sql = "select Manhom, Mahh, Tenhh, dvt, Dgvnd, sanxuat from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtManhom.Text = grdData.Rows[i].Cells["Manhom"].Value.ToString();
            txtMahh.Text = grdData.Rows[i].Cells["Mahh"].Value.ToString();
            txtTenHang.Text = grdData.Rows[i].Cells["Tenhh"].Value.ToString();
            txtDvt.Text = grdData.Rows[i].Cells["dvt"].Value.ToString();
            txtdgvnd.Text = grdData.Rows[i].Cells["Dgvnd"].Value.ToString();
            txtSX.Text = grdData.Rows[i].Cells["sanxuat"].Value.ToString();
        }

    }
}
