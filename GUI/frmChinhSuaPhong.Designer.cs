namespace demoDA
{
    partial class frmChinhSuaPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxPhong = new System.Windows.Forms.GroupBox();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.lblGiaPhong = new System.Windows.Forms.Label();
            this.lblTimKiemPhong = new System.Windows.Forms.Label();
            this.txtTimKiemPhong = new System.Windows.Forms.TextBox();
            this.btnTimKiemPhong = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoNguoiO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLP = new System.Windows.Forms.TextBox();
            this.gbxPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPhong
            // 
            this.gbxPhong.Controls.Add(this.txtMaLP);
            this.gbxPhong.Controls.Add(this.label2);
            this.gbxPhong.Controls.Add(this.txtSoNguoiO);
            this.gbxPhong.Controls.Add(this.label1);
            this.gbxPhong.Controls.Add(this.btnSuaPhong);
            this.gbxPhong.Controls.Add(this.txtGiaPhong);
            this.gbxPhong.Controls.Add(this.lblGiaPhong);
            this.gbxPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPhong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbxPhong.Location = new System.Drawing.Point(12, 252);
            this.gbxPhong.Name = "gbxPhong";
            this.gbxPhong.Size = new System.Drawing.Size(732, 141);
            this.gbxPhong.TabIndex = 1;
            this.gbxPhong.TabStop = false;
            this.gbxPhong.Text = "Thông tin phòng";
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuaPhong.Location = new System.Drawing.Point(612, 54);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(75, 31);
            this.btnSuaPhong.TabIndex = 17;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(450, 35);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(147, 30);
            this.txtGiaPhong.TabIndex = 13;
            // 
            // lblGiaPhong
            // 
            this.lblGiaPhong.AutoSize = true;
            this.lblGiaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaPhong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGiaPhong.Location = new System.Drawing.Point(339, 42);
            this.lblGiaPhong.Name = "lblGiaPhong";
            this.lblGiaPhong.Size = new System.Drawing.Size(96, 20);
            this.lblGiaPhong.TabIndex = 8;
            this.lblGiaPhong.Text = "Giá Phòng";
            // 
            // lblTimKiemPhong
            // 
            this.lblTimKiemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemPhong.Location = new System.Drawing.Point(7, 21);
            this.lblTimKiemPhong.Name = "lblTimKiemPhong";
            this.lblTimKiemPhong.Size = new System.Drawing.Size(138, 57);
            this.lblTimKiemPhong.TabIndex = 2;
            this.lblTimKiemPhong.Text = "Số phòng /  Mã phòng :";
            this.lblTimKiemPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimKiemPhong
            // 
            this.txtTimKiemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemPhong.Location = new System.Drawing.Point(12, 95);
            this.txtTimKiemPhong.Name = "txtTimKiemPhong";
            this.txtTimKiemPhong.Size = new System.Drawing.Size(133, 26);
            this.txtTimKiemPhong.TabIndex = 3;
            // 
            // btnTimKiemPhong
            // 
            this.btnTimKiemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemPhong.Location = new System.Drawing.Point(30, 151);
            this.btnTimKiemPhong.Name = "btnTimKiemPhong";
            this.btnTimKiemPhong.Size = new System.Drawing.Size(93, 34);
            this.btnTimKiemPhong.TabIndex = 4;
            this.btnTimKiemPhong.Text = "Tìm kiếm";
            this.btnTimKiemPhong.UseVisualStyleBackColor = true;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhong.Location = new System.Drawing.Point(151, 12);
            this.dgvPhong.Name = "dgvPhong";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(593, 233);
            this.dgvPhong.TabIndex = 5;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Số ngưởi ở";
            // 
            // txtSoNguoiO
            // 
            this.txtSoNguoiO.Location = new System.Drawing.Point(450, 76);
            this.txtSoNguoiO.Name = "txtSoNguoiO";
            this.txtSoNguoiO.Size = new System.Drawing.Size(147, 30);
            this.txtSoNguoiO.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã loại phòng";
            // 
            // txtMaLP
            // 
            this.txtMaLP.Location = new System.Drawing.Point(162, 60);
            this.txtMaLP.Name = "txtMaLP";
            this.txtMaLP.Size = new System.Drawing.Size(147, 30);
            this.txtMaLP.TabIndex = 21;
            // 
            // frmChinhSuaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(781, 429);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.btnTimKiemPhong);
            this.Controls.Add(this.txtTimKiemPhong);
            this.Controls.Add(this.lblTimKiemPhong);
            this.Controls.Add(this.gbxPhong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmChinhSuaPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa phòng";
            this.Load += new System.EventHandler(this.formchinhsuaphong_Load);
            this.gbxPhong.ResumeLayout(false);
            this.gbxPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label lblGiaPhong;
        private System.Windows.Forms.Label lblTimKiemPhong;
        private System.Windows.Forms.TextBox txtTimKiemPhong;
        private System.Windows.Forms.Button btnTimKiemPhong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.TextBox txtSoNguoiO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLP;
        private System.Windows.Forms.Label label2;
    }
}