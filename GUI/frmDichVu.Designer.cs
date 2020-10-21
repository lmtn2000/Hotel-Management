namespace demoDA
{
    partial class frmDichVu
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
            this.lblMaDV = new System.Windows.Forms.Label();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.lblGiaDV = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnSuaDichVu = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.gbxDichVu = new System.Windows.Forms.GroupBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.gbxDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = true;
            this.lblMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaDV.Location = new System.Drawing.Point(54, 44);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(66, 20);
            this.lblMaDV.TabIndex = 0;
            this.lblMaDV.Text = "Mã DV";
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTenDV.Location = new System.Drawing.Point(54, 88);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(72, 20);
            this.lblTenDV.TabIndex = 2;
            this.lblTenDV.Text = "Tên DV";
            // 
            // lblGiaDV
            // 
            this.lblGiaDV.AutoSize = true;
            this.lblGiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGiaDV.Location = new System.Drawing.Point(56, 138);
            this.lblGiaDV.Name = "lblGiaDV";
            this.lblGiaDV.Size = new System.Drawing.Size(70, 20);
            this.lblGiaDV.TabIndex = 3;
            this.lblGiaDV.Text = "Giá DV";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Location = new System.Drawing.Point(150, 41);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(155, 26);
            this.txtMaDV.TabIndex = 6;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(150, 88);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(155, 26);
            this.txtTenDV.TabIndex = 7;
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaDV.Location = new System.Drawing.Point(150, 132);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(155, 26);
            this.txtGiaDV.TabIndex = 9;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemDV.Location = new System.Drawing.Point(398, 41);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(75, 35);
            this.btnThemDV.TabIndex = 11;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnSuaDichVu
            // 
            this.btnSuaDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDichVu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuaDichVu.Location = new System.Drawing.Point(398, 82);
            this.btnSuaDichVu.Name = "btnSuaDichVu";
            this.btnSuaDichVu.Size = new System.Drawing.Size(75, 35);
            this.btnSuaDichVu.TabIndex = 12;
            this.btnSuaDichVu.Text = "Sửa";
            this.btnSuaDichVu.UseVisualStyleBackColor = true;
            this.btnSuaDichVu.Click += new System.EventHandler(this.btnSuaDichVu_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaDV.Location = new System.Drawing.Point(398, 123);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(75, 35);
            this.btnXoaDV.TabIndex = 13;
            this.btnXoaDV.Text = "Xoá";
            this.btnXoaDV.UseVisualStyleBackColor = true;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // gbxDichVu
            // 
            this.gbxDichVu.Controls.Add(this.btnXoaDV);
            this.gbxDichVu.Controls.Add(this.lblMaDV);
            this.gbxDichVu.Controls.Add(this.btnSuaDichVu);
            this.gbxDichVu.Controls.Add(this.lblTenDV);
            this.gbxDichVu.Controls.Add(this.btnThemDV);
            this.gbxDichVu.Controls.Add(this.lblGiaDV);
            this.gbxDichVu.Controls.Add(this.txtGiaDV);
            this.gbxDichVu.Controls.Add(this.txtMaDV);
            this.gbxDichVu.Controls.Add(this.txtTenDV);
            this.gbxDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDichVu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbxDichVu.Location = new System.Drawing.Point(25, 267);
            this.gbxDichVu.Name = "gbxDichVu";
            this.gbxDichVu.Size = new System.Drawing.Size(610, 221);
            this.gbxDichVu.TabIndex = 14;
            this.gbxDichVu.TabStop = false;
            this.gbxDichVu.Text = "Thông tin dịch vụ";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvDichVu.Location = new System.Drawing.Point(25, 12);
            this.dgvDichVu.MultiSelect = false;
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.RowHeadersVisible = false;
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(610, 249);
            this.dgvDichVu.TabIndex = 15;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(658, 518);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.gbxDichVu);
            this.MaximizeBox = false;
            this.Name = "frmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa dịch vụ";
            this.Load += new System.EventHandler(this.formchinhsuaDV_Load);
            this.gbxDichVu.ResumeLayout(false);
            this.gbxDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.Label lblGiaDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnSuaDichVu;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.GroupBox gbxDichVu;
        private System.Windows.Forms.DataGridView dgvDichVu;
    }
}