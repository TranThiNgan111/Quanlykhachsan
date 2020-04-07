namespace QUẢN_LÝ_KHÁCH_SẠN
{
    partial class Quản_lý_khách_sạn_nhà_nghỉ
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Phong = new System.Windows.Forms.DataGridView();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntHuybo = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaphong.Location = new System.Drawing.Point(225, 42);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(100, 29);
            this.txtMaphong.TabIndex = 1;
            // 
            // txtTenphong
            // 
            this.txtTenphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenphong.Location = new System.Drawing.Point(225, 110);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(100, 29);
            this.txtTenphong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Phòng";
            // 
            // txtDongia
            // 
            this.txtDongia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.Location = new System.Drawing.Point(225, 185);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(100, 29);
            this.txtDongia.TabIndex = 5;
            this.txtDongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn Gía";
            // 
            // dataGridView_Phong
            // 
            this.dataGridView_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphong,
            this.Tenphong,
            this.Dongia});
            this.dataGridView_Phong.Location = new System.Drawing.Point(12, 232);
            this.dataGridView_Phong.Name = "dataGridView_Phong";
            this.dataGridView_Phong.Size = new System.Drawing.Size(684, 150);
            this.dataGridView_Phong.TabIndex = 6;
            this.dataGridView_Phong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Phong_CellCont);
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã Phòng";
            this.Maphong.Name = "Maphong";
            // 
            // Tenphong
            // 
            this.Tenphong.DataPropertyName = "Tenphong";
            this.Tenphong.HeaderText = "Tên Phòng";
            this.Tenphong.Name = "Tenphong";
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "Dongia";
            this.Dongia.HeaderText = "Đơn Gía";
            this.Dongia.Name = "Dongia";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(137, 404);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(16, 404);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 8;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntLuu
            // 
            this.bntLuu.Location = new System.Drawing.Point(260, 404);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(75, 23);
            this.bntLuu.TabIndex = 9;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.UseVisualStyleBackColor = true;
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // bntHuybo
            // 
            this.bntHuybo.Location = new System.Drawing.Point(383, 404);
            this.bntHuybo.Name = "bntHuybo";
            this.bntHuybo.Size = new System.Drawing.Size(75, 23);
            this.bntHuybo.TabIndex = 10;
            this.bntHuybo.Text = "Hủy bỏ";
            this.bntHuybo.UseVisualStyleBackColor = true;
            this.bntHuybo.Click += new System.EventHandler(this.bntHuybo_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(621, 404);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 11;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntSua
            // 
            this.bntSua.Location = new System.Drawing.Point(500, 404);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(75, 23);
            this.bntSua.TabIndex = 12;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // Quản_lý_khách_sạn_nhà_nghỉ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntHuybo);
            this.Controls.Add(this.bntLuu);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dataGridView_Phong);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenphong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.label1);
            this.Name = "Quản_lý_khách_sạn_nhà_nghỉ";
            this.Text = "Quản_lý_khách_sạn_nhà_nghỉ";
            this.Load += new System.EventHandler(this.Quản_lý_khách_sạn_nhà_nghỉ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntHuybo;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntSua;
    }
}