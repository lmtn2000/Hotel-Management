namespace demoDA
{
    partial class frmMain
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
            System.Windows.Forms.GroupBox gbxQuanLy;
            this.btnCSDichVu = new System.Windows.Forms.Button();
            this.btnCSPhong = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.gbxLeTan = new System.Windows.Forms.GroupBox();
            this.btnTTKhachHang = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.lbusername = new System.Windows.Forms.Label();
            this.lblPhanQuyen = new System.Windows.Forms.Label();
            this.txtPhanQuyen = new System.Windows.Forms.TextBox();
            this.btnLichSu = new System.Windows.Forms.Button();
            gbxQuanLy = new System.Windows.Forms.GroupBox();
            gbxQuanLy.SuspendLayout();
            this.gbxLeTan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxQuanLy
            // 
            gbxQuanLy.Controls.Add(this.btnCSDichVu);
            gbxQuanLy.Controls.Add(this.btnCSPhong);
            gbxQuanLy.Controls.Add(this.btnQLNhanVien);
            gbxQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gbxQuanLy.ForeColor = System.Drawing.Color.Red;
            gbxQuanLy.Location = new System.Drawing.Point(12, 248);
            gbxQuanLy.Name = "gbxQuanLy";
            gbxQuanLy.Size = new System.Drawing.Size(739, 152);
            gbxQuanLy.TabIndex = 0;
            gbxQuanLy.TabStop = false;
            gbxQuanLy.Text = "MANAGER";
            // 
            // btnCSDichVu
            // 
            this.btnCSDichVu.BackColor = System.Drawing.SystemColors.Info;
            this.btnCSDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSDichVu.ForeColor = System.Drawing.Color.Black;
            this.btnCSDichVu.Location = new System.Drawing.Point(515, 33);
            this.btnCSDichVu.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnCSDichVu.Name = "btnCSDichVu";
            this.btnCSDichVu.Size = new System.Drawing.Size(213, 98);
            this.btnCSDichVu.TabIndex = 7;
            this.btnCSDichVu.Text = "Chỉnh sửa dịch vụ";
            this.btnCSDichVu.UseVisualStyleBackColor = false;
            this.btnCSDichVu.Click += new System.EventHandler(this.btchinhsuaDV_Click);
            // 
            // btnCSPhong
            // 
            this.btnCSPhong.BackColor = System.Drawing.SystemColors.Info;
            this.btnCSPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSPhong.ForeColor = System.Drawing.Color.Black;
            this.btnCSPhong.Location = new System.Drawing.Point(255, 33);
            this.btnCSPhong.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnCSPhong.Name = "btnCSPhong";
            this.btnCSPhong.Size = new System.Drawing.Size(236, 98);
            this.btnCSPhong.TabIndex = 6;
            this.btnCSPhong.Text = "Chỉnh sửa phòng";
            this.btnCSPhong.UseVisualStyleBackColor = false;
            this.btnCSPhong.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.BackColor = System.Drawing.SystemColors.Info;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnQLNhanVien.Location = new System.Drawing.Point(9, 33);
            this.btnQLNhanVien.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(233, 98);
            this.btnQLNhanVien.TabIndex = 5;
            this.btnQLNhanVien.Text = "Quản lý nhân viên";
            this.btnQLNhanVien.UseVisualStyleBackColor = false;
            this.btnQLNhanVien.Click += new System.EventHandler(this.button7_Click);
            // 
            // gbxLeTan
            // 
            this.gbxLeTan.Controls.Add(this.btnLichSu);
            this.gbxLeTan.Controls.Add(this.btnTTKhachHang);
            this.gbxLeTan.Controls.Add(this.btnDatPhong);
            this.gbxLeTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLeTan.ForeColor = System.Drawing.Color.Red;
            this.gbxLeTan.Location = new System.Drawing.Point(12, 47);
            this.gbxLeTan.Name = "gbxLeTan";
            this.gbxLeTan.Size = new System.Drawing.Size(739, 186);
            this.gbxLeTan.TabIndex = 0;
            this.gbxLeTan.TabStop = false;
            this.gbxLeTan.Text = "RECEPTIONIST";
            // 
            // btnTTKhachHang
            // 
            this.btnTTKhachHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTTKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnTTKhachHang.Location = new System.Drawing.Point(255, 49);
            this.btnTTKhachHang.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnTTKhachHang.Name = "btnTTKhachHang";
            this.btnTTKhachHang.Size = new System.Drawing.Size(236, 98);
            this.btnTTKhachHang.TabIndex = 1;
            this.btnTTKhachHang.Text = "Quản lý thông tin khách hàng";
            this.btnTTKhachHang.UseVisualStyleBackColor = false;
            this.btnTTKhachHang.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDatPhong.Location = new System.Drawing.Point(9, 49);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(233, 98);
            this.btnDatPhong.TabIndex = 0;
            this.btnDatPhong.Text = "Đặt phòng và Trả phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btbook_Click);
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(566, 9);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(0, 17);
            this.lbusername.TabIndex = 1;
            // 
            // lblPhanQuyen
            // 
            this.lblPhanQuyen.AutoSize = true;
            this.lblPhanQuyen.Location = new System.Drawing.Point(628, 9);
            this.lblPhanQuyen.Name = "lblPhanQuyen";
            this.lblPhanQuyen.Size = new System.Drawing.Size(0, 17);
            this.lblPhanQuyen.TabIndex = 2;
            // 
            // txtPhanQuyen
            // 
            this.txtPhanQuyen.Enabled = false;
            this.txtPhanQuyen.Location = new System.Drawing.Point(465, 6);
            this.txtPhanQuyen.Name = "txtPhanQuyen";
            this.txtPhanQuyen.Size = new System.Drawing.Size(275, 22);
            this.txtPhanQuyen.TabIndex = 3;
            // 
            // btnLichSu
            // 
            this.btnLichSu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSu.ForeColor = System.Drawing.Color.Black;
            this.btnLichSu.Location = new System.Drawing.Point(515, 49);
            this.btnLichSu.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(224, 98);
            this.btnLichSu.TabIndex = 2;
            this.btnLichSu.Text = "Xem lịch sử đặt phòng";
            this.btnLichSu.UseVisualStyleBackColor = false;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(766, 416);
            this.Controls.Add(this.txtPhanQuyen);
            this.Controls.Add(this.lblPhanQuyen);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(gbxQuanLy);
            this.Controls.Add(this.gbxLeTan);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTEL";
            this.Load += new System.EventHandler(this.frmMain_Load);
            gbxQuanLy.ResumeLayout(false);
            this.gbxLeTan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLeTan;
        private System.Windows.Forms.Button btnTTKhachHang;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Button btnCSDichVu;
        private System.Windows.Forms.Button btnCSPhong;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Label lblPhanQuyen;
        private System.Windows.Forms.TextBox txtPhanQuyen;
        private System.Windows.Forms.Button btnLichSu;
    }
}