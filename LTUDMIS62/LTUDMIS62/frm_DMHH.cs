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
        SqlCommand cmd = new SqlCommand();

        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable com2dt = new DataTable();
        string sql, constr;
        int i;
        Boolean addNewFlag = false;

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

            //List Manhom 
            sql = "select Manhom from tblDMNhom";
            da = new SqlDataAdapter(sql, conn);
            com2dt.Clear();
            da.Fill(com2dt);
            txtManhom.DataSource = com2dt;
            txtManhom.DisplayMember = "Manhom";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời không?Y/N", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "delete from tblDMHH where Mahh = '" + txtMahh.Text + "';";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }

            //Xóa bản ghi hiện tại
            grdData.Rows.RemoveAt(grdData.CurrentRow.Index);
            NapCT();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy thực hiện mọi sửa đổi mong muốn trên ô lưới, kết thúc bấm nút Cập nhật", "Thông báo", MessageBoxButtons.OK);
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update cái mới
            if(addNewFlag == true)
            {
                for (i = 0; i < grdData.RowCount - 1; i++)
                {
                    txtManhom.Text = grdData.Rows[i].Cells["Manhom"].Value.ToString();
                    txtMahh.Text = grdData.Rows[i].Cells["Mahh"].Value.ToString();
                    txtTenHang.Text = grdData.Rows[i].Cells["Tenhh"].Value.ToString();
                    txtDvt.Text = grdData.Rows[i].Cells["dvt"].Value.ToString();
                    txtdgvnd.Text = grdData.Rows[i].Cells["Dgvnd"].Value.ToString();
                    txtSX.Text = grdData.Rows[i].Cells["sanxuat"].Value.ToString();
                    sql = "update tblDMHH set Tenhh = '" + txtTenHang.Text + "', dvt = '" + txtDvt.Text + "', Dgvnd = '" + txtdgvnd.Text +  "', sanxuat = '" + txtSX.Text + "' where Mahh = '" + txtMahh.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
            }
            //Update cái có sẵn
            else
            {
                addNewFlag = false;
                sql = "insert into tblDMHH (Manhom, Mahh, Tenhh, dvt, Dgvnd, sanxuat) values ('" + txtManhom.Text + "', '" + txtMahh.Text + "', N'" + txtTenHang.Text + "', N'" + txtDvt.Text + "', N'" + txtdgvnd.Text + "', N'" + txtSX.Text + "');";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                //Nạp bản ghi vừa thêm vào bản ghi cuối cùng ô lưới
                //i = grdData.CurrentRow.Index;
                grdData.Rows[i].Cells["Manhom"].Value = txtManhom.Text;
                grdData.Rows[i].Cells["Mahh"].Value = txtMahh.Text;
                grdData.Rows[i].Cells["Tenhh"].Value = txtTenHang.Text;
                grdData.Rows[i].Cells["dvt"].Value = txtDvt.Text;
                grdData.Rows[i].Cells["Dgvnd"].Value = txtdgvnd.Text;
                grdData.Rows[i].Cells["sanxuat"].Value = txtSX.Text;
                grdData.Refresh();
            }
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Nạp lại dữ liệu để thêm dòng cuối trắng
            sql = "select Manhom, Mahh, Tenhh, dvt, Dgvnd, sanxuat from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();

            grdData.CurrentCell = grdData[0, grdData.RowCount-1];
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới, kết thúc bấm Cập nhật!");
            txtManhom.Focus();
            addNewFlag = true;
            btnUpdate.Enabled = true;
        }

        private void btnBC1_Click(object sender, EventArgs e)
        {
            rptDMHH rpt = new rptDMHH();
            DataTable rptData = new DataTable();
            sql = "Select Mahh, Tenhh, dvt, dgvnd, sanxuat From tblDMHH where " +
                " Manhom = '" + comGiaTri.Text + "'";
            da = new SqlDataAdapter(sql, conn); // lấy dữ liệu combobox hay ô lưới
            da.Fill(rptData);
            rpt.SetDataSource(rptData);
            rpt.DataDefinition.FormulaFields["tennhom"].Text = "'" + comGiaTri.Text + "'";
            frmprv_DMHH f = new frmprv_DMHH(rpt);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CrystalReport2 rpt = new CrystalReport2();
                DataTable rptData = new DataTable();
                sql = "select Manhom, mahh, tenhh, dvt, dgvnd, sanxuat from tblDMHH";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(rptData);
                rpt.SetDataSource(rptData);
                frmprv_NhomHH f = new frmprv_NhomHH(rpt);
                f.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show("Co loi " + err.Message);
            }
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
