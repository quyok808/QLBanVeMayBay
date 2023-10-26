namespace WindowsFormsApp1
{
    partial class ThemLichBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemLichBay));
            this.GRB_ThemCB = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbMaMB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.cmbNoiDen = new System.Windows.Forms.ComboBox();
            this.cmbNoiDi = new System.Windows.Forms.ComboBox();
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.dgvAddCB = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GRB_ThemCB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GRB_ThemCB
            // 
            this.GRB_ThemCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.GRB_ThemCB.Controls.Add(this.pictureBox2);
            this.GRB_ThemCB.Controls.Add(this.btnDel);
            this.GRB_ThemCB.Controls.Add(this.btnSua);
            this.GRB_ThemCB.Controls.Add(this.btnAdd);
            this.GRB_ThemCB.Controls.Add(this.cmbMaMB);
            this.GRB_ThemCB.Controls.Add(this.label2);
            this.GRB_ThemCB.Controls.Add(this.dtpNgayKhoiHanh);
            this.GRB_ThemCB.Controls.Add(this.cmbNoiDen);
            this.GRB_ThemCB.Controls.Add(this.cmbNoiDi);
            this.GRB_ThemCB.Controls.Add(this.txtMaCB);
            this.GRB_ThemCB.Controls.Add(this.dgvAddCB);
            this.GRB_ThemCB.Controls.Add(this.label5);
            this.GRB_ThemCB.Controls.Add(this.label4);
            this.GRB_ThemCB.Controls.Add(this.label3);
            this.GRB_ThemCB.Controls.Add(this.label1);
            this.GRB_ThemCB.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRB_ThemCB.Location = new System.Drawing.Point(12, 166);
            this.GRB_ThemCB.Name = "GRB_ThemCB";
            this.GRB_ThemCB.Size = new System.Drawing.Size(1211, 522);
            this.GRB_ThemCB.TabIndex = 3;
            this.GRB_ThemCB.TabStop = false;
            this.GRB_ThemCB.Text = "Thêm lịch bay";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(993, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 195);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(808, 195);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(120, 40);
            this.btnDel.TabIndex = 25;
            this.btnDel.Text = "XÓA";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSua.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(657, 195);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "SỬA";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(507, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbMaMB
            // 
            this.cmbMaMB.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaMB.FormattingEnabled = true;
            this.cmbMaMB.Location = new System.Drawing.Point(239, 202);
            this.cmbMaMB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaMB.Name = "cmbMaMB";
            this.cmbMaMB.Size = new System.Drawing.Size(221, 27);
            this.cmbMaMB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã máy bay";
            // 
            // dtpNgayKhoiHanh
            // 
            this.dtpNgayKhoiHanh.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpNgayKhoiHanh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKhoiHanh.Location = new System.Drawing.Point(239, 159);
            this.dtpNgayKhoiHanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayKhoiHanh.Name = "dtpNgayKhoiHanh";
            this.dtpNgayKhoiHanh.Size = new System.Drawing.Size(221, 27);
            this.dtpNgayKhoiHanh.TabIndex = 6;
            // 
            // cmbNoiDen
            // 
            this.cmbNoiDen.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNoiDen.FormattingEnabled = true;
            this.cmbNoiDen.Location = new System.Drawing.Point(239, 118);
            this.cmbNoiDen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNoiDen.Name = "cmbNoiDen";
            this.cmbNoiDen.Size = new System.Drawing.Size(221, 27);
            this.cmbNoiDen.TabIndex = 5;
            // 
            // cmbNoiDi
            // 
            this.cmbNoiDi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNoiDi.FormattingEnabled = true;
            this.cmbNoiDi.Location = new System.Drawing.Point(239, 75);
            this.cmbNoiDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNoiDi.Name = "cmbNoiDi";
            this.cmbNoiDi.Size = new System.Drawing.Size(221, 27);
            this.cmbNoiDi.TabIndex = 4;
            // 
            // txtMaCB
            // 
            this.txtMaCB.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCB.Location = new System.Drawing.Point(239, 32);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.Size = new System.Drawing.Size(221, 27);
            this.txtMaCB.TabIndex = 3;
            // 
            // dgvAddCB
            // 
            this.dgvAddCB.AllowUserToAddRows = false;
            this.dgvAddCB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddCB.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvAddCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddCB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column4,
            this.Column5});
            this.dgvAddCB.Location = new System.Drawing.Point(21, 248);
            this.dgvAddCB.Name = "dgvAddCB";
            this.dgvAddCB.RowHeadersWidth = 51;
            this.dgvAddCB.RowTemplate.Height = 24;
            this.dgvAddCB.Size = new System.Drawing.Size(1173, 268);
            this.dgvAddCB.TabIndex = 1;
            this.dgvAddCB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddCB_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã chuyến bay";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nơi đi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nơi đến";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày khởi hành";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mã sân bay đi";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã sân bay đến";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã máy bay";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nơi Đi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày khởi hành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nơi Đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chuyến Bay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 51);
            this.label6.TabIndex = 9;
            this.label6.Text = "QUẢN LÝ LỊCH BAY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ThemLichBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1229, 693);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GRB_ThemCB);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemLichBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lịch Bay";
            this.Load += new System.EventHandler(this.ThemLichBay_Load);
            this.GRB_ThemCB.ResumeLayout(false);
            this.GRB_ThemCB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRB_ThemCB;
        public System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.DataGridView dgvAddCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayKhoiHanh;
        private System.Windows.Forms.ComboBox cmbNoiDen;
        private System.Windows.Forms.ComboBox cmbNoiDi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMaMB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}