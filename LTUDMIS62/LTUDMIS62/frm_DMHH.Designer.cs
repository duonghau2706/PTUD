
namespace LTUDMIS62
{
    partial class frm_DMHH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdData = new System.Windows.Forms.DataGridView();
            this.Manhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mahh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgvnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdgvnd = new System.Windows.Forms.TextBox();
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtSX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearFillter = new System.Windows.Forms.Button();
            this.btnFillter = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comTenTruong = new System.Windows.Forms.ComboBox();
            this.comGiaTri = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtManhom = new System.Windows.Forms.ComboBox();
            this.txtMahh = new System.Windows.Forms.TextBox();
            this.btnBC1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manhom,
            this.Mahh,
            this.TenHH,
            this.dvt,
            this.Dgvnd,
            this.sanxuat});
            this.grdData.Location = new System.Drawing.Point(12, 23);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 62;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.Size = new System.Drawing.Size(796, 492);
            this.grdData.TabIndex = 0;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // Manhom
            // 
            this.Manhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Manhom.DataPropertyName = "Manhom";
            this.Manhom.HeaderText = "Mã nhóm";
            this.Manhom.MinimumWidth = 8;
            this.Manhom.Name = "Manhom";
            this.Manhom.Width = 111;
            // 
            // Mahh
            // 
            this.Mahh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Mahh.DataPropertyName = "Mahh";
            this.Mahh.HeaderText = "Mã hàng";
            this.Mahh.MinimumWidth = 8;
            this.Mahh.Name = "Mahh";
            this.Mahh.Width = 107;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên hàng";
            this.TenHH.MinimumWidth = 8;
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 112;
            // 
            // dvt
            // 
            this.dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dvt.DataPropertyName = "dvt";
            this.dvt.HeaderText = "ĐVT";
            this.dvt.MinimumWidth = 8;
            this.dvt.Name = "dvt";
            this.dvt.Width = 77;
            // 
            // Dgvnd
            // 
            this.Dgvnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dgvnd.DataPropertyName = "Dgvnd";
            this.Dgvnd.HeaderText = "Đơn giá";
            this.Dgvnd.MinimumWidth = 8;
            this.Dgvnd.Name = "Dgvnd";
            // 
            // sanxuat
            // 
            this.sanxuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sanxuat.DataPropertyName = "sanxuat";
            this.sanxuat.HeaderText = "Nước SX";
            this.sanxuat.MinimumWidth = 8;
            this.sanxuat.Name = "sanxuat";
            this.sanxuat.Width = 108;
            // 
            // txtdgvnd
            // 
            this.txtdgvnd.Location = new System.Drawing.Point(976, 368);
            this.txtdgvnd.Name = "txtdgvnd";
            this.txtdgvnd.Size = new System.Drawing.Size(185, 26);
            this.txtdgvnd.TabIndex = 4;
            // 
            // txtDvt
            // 
            this.txtDvt.Location = new System.Drawing.Point(976, 325);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(185, 26);
            this.txtDvt.TabIndex = 3;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(976, 284);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(185, 26);
            this.txtTenHang.TabIndex = 6;
            // 
            // txtSX
            // 
            this.txtSX.Location = new System.Drawing.Point(976, 410);
            this.txtSX.Name = "txtSX";
            this.txtSX.Size = new System.Drawing.Size(185, 26);
            this.txtSX.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(865, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(865, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(865, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(865, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(865, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nước SX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(865, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đơn giá";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(10, 532);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(99, 49);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(115, 532);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(99, 49);
            this.btnPrv.TabIndex = 14;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(220, 532);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 49);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(325, 532);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(99, 49);
            this.btnLast.TabIndex = 15;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearFillter);
            this.groupBox1.Controls.Add(this.btnFillter);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comTenTruong);
            this.groupBox1.Controls.Add(this.comGiaTri);
            this.groupBox1.Location = new System.Drawing.Point(827, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 161);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            // 
            // btnClearFillter
            // 
            this.btnClearFillter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearFillter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFillter.Location = new System.Drawing.Point(178, 107);
            this.btnClearFillter.Name = "btnClearFillter";
            this.btnClearFillter.Size = new System.Drawing.Size(156, 46);
            this.btnClearFillter.TabIndex = 19;
            this.btnClearFillter.Text = "Hủy lọc dữ liệu";
            this.btnClearFillter.UseVisualStyleBackColor = false;
            this.btnClearFillter.Click += new System.EventHandler(this.btnClearFillter_Click);
            // 
            // btnFillter
            // 
            this.btnFillter.BackColor = System.Drawing.Color.Yellow;
            this.btnFillter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillter.Location = new System.Drawing.Point(16, 107);
            this.btnFillter.Name = "btnFillter";
            this.btnFillter.Size = new System.Drawing.Size(137, 46);
            this.btnFillter.TabIndex = 18;
            this.btnFillter.Text = "Lọc dữ liệu";
            this.btnFillter.UseVisualStyleBackColor = false;
            this.btnFillter.Click += new System.EventHandler(this.btnFillter_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giá trị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên trường";
            // 
            // comTenTruong
            // 
            this.comTenTruong.FormattingEnabled = true;
            this.comTenTruong.Items.AddRange(new object[] {
            "Manhom",
            "Mahh",
            "Tenhh",
            "sanxuat"});
            this.comTenTruong.Location = new System.Drawing.Point(16, 59);
            this.comTenTruong.Name = "comTenTruong";
            this.comTenTruong.Size = new System.Drawing.Size(137, 28);
            this.comTenTruong.TabIndex = 1;
            this.comTenTruong.SelectedIndexChanged += new System.EventHandler(this.comTenTruong_SelectedIndexChanged);
            // 
            // comGiaTri
            // 
            this.comGiaTri.FormattingEnabled = true;
            this.comGiaTri.Location = new System.Drawing.Point(178, 59);
            this.comGiaTri.Name = "comGiaTri";
            this.comGiaTri.Size = new System.Drawing.Size(156, 28);
            this.comGiaTri.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1048, 632);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 37);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(939, 632);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 37);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "   ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(857, 632);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(76, 37);
            this.btnDel.TabIndex = 20;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(767, 632);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 37);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(643, 632);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 37);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtManhom
            // 
            this.txtManhom.FormattingEnabled = true;
            this.txtManhom.Location = new System.Drawing.Point(976, 203);
            this.txtManhom.Name = "txtManhom";
            this.txtManhom.Size = new System.Drawing.Size(185, 28);
            this.txtManhom.TabIndex = 23;
            // 
            // txtMahh
            // 
            this.txtMahh.Location = new System.Drawing.Point(976, 243);
            this.txtMahh.Name = "txtMahh";
            this.txtMahh.Size = new System.Drawing.Size(185, 26);
            this.txtMahh.TabIndex = 24;
            // 
            // btnBC1
            // 
            this.btnBC1.Location = new System.Drawing.Point(865, 492);
            this.btnBC1.Name = "btnBC1";
            this.btnBC1.Size = new System.Drawing.Size(258, 44);
            this.btnBC1.TabIndex = 25;
            this.btnBC1.Text = "IN kiem ke theo nhom hang";
            this.btnBC1.UseVisualStyleBackColor = true;
            this.btnBC1.Click += new System.EventHandler(this.btnBC1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(862, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_DMHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1281, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBC1);
            this.Controls.Add(this.txtMahh);
            this.Controls.Add(this.txtManhom);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtSX);
            this.Controls.Add(this.txtdgvnd);
            this.Controls.Add(this.txtDvt);
            this.Controls.Add(this.grdData);
            this.Name = "frm_DMHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DMHH";
            this.Load += new System.EventHandler(this.frm_DMHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanxuat;
        private System.Windows.Forms.TextBox txtdgvnd;
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comTenTruong;
        private System.Windows.Forms.ComboBox comGiaTri;
        private System.Windows.Forms.Button btnClearFillter;
        private System.Windows.Forms.Button btnFillter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox txtManhom;
        private System.Windows.Forms.TextBox txtMahh;
        private System.Windows.Forms.Button btnBC1;
        private System.Windows.Forms.Button button1;
    }
}