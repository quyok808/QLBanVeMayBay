namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GRB_DatVe = new System.Windows.Forms.GroupBox();
            this.btn_ChonKM = new System.Windows.Forms.Button();
            this.btn_ChonVe = new System.Windows.Forms.Button();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.txt_GiaTien = new System.Windows.Forms.TextBox();
            this.txt_MaCB = new System.Windows.Forms.TextBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Mua = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngKêDoanhThuTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.thốngKêSốVéBánĐượcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLịchBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quảnLýVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.quảnLýKhuyếnMãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.thốngKêToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GRB_DatVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GRB_DatVe
            // 
            this.GRB_DatVe.BackColor = System.Drawing.Color.PeachPuff;
            this.GRB_DatVe.Controls.Add(this.btn_ChonKM);
            this.GRB_DatVe.Controls.Add(this.btn_ChonVe);
            this.GRB_DatVe.Controls.Add(this.txt_TenKH);
            this.GRB_DatVe.Controls.Add(this.txt_CCCD);
            this.GRB_DatVe.Controls.Add(this.txt_GiaTien);
            this.GRB_DatVe.Controls.Add(this.txt_MaCB);
            this.GRB_DatVe.Controls.Add(this.btn_Huy);
            this.GRB_DatVe.Controls.Add(this.btn_Them);
            this.GRB_DatVe.Controls.Add(this.btn_Mua);
            this.GRB_DatVe.Controls.Add(this.btn_Check);
            this.GRB_DatVe.Controls.Add(this.dataGridView1);
            this.GRB_DatVe.Controls.Add(this.label4);
            this.GRB_DatVe.Controls.Add(this.label3);
            this.GRB_DatVe.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRB_DatVe.Location = new System.Drawing.Point(12, 261);
            this.GRB_DatVe.Name = "GRB_DatVe";
            this.GRB_DatVe.Size = new System.Drawing.Size(1092, 491);
            this.GRB_DatVe.TabIndex = 2;
            this.GRB_DatVe.TabStop = false;
            this.GRB_DatVe.Text = "Đặt Vé";
            // 
            // btn_ChonKM
            // 
            this.btn_ChonKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ChonKM.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonKM.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChonKM.Image")));
            this.btn_ChonKM.Location = new System.Drawing.Point(752, 440);
            this.btn_ChonKM.Name = "btn_ChonKM";
            this.btn_ChonKM.Size = new System.Drawing.Size(183, 45);
            this.btn_ChonKM.TabIndex = 5;
            this.btn_ChonKM.Text = "CHỌN KM";
            this.btn_ChonKM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ChonKM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChonKM.UseVisualStyleBackColor = false;
            this.btn_ChonKM.Visible = false;
            this.btn_ChonKM.Click += new System.EventHandler(this.btn_ChonKM_Click);
            // 
            // btn_ChonVe
            // 
            this.btn_ChonVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ChonVe.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonVe.Location = new System.Drawing.Point(81, 85);
            this.btn_ChonVe.Name = "btn_ChonVe";
            this.btn_ChonVe.Size = new System.Drawing.Size(116, 33);
            this.btn_ChonVe.TabIndex = 4;
            this.btn_ChonVe.Text = "CHỌN VÉ";
            this.btn_ChonVe.UseVisualStyleBackColor = false;
            this.btn_ChonVe.Click += new System.EventHandler(this.btn_ChonVe_Click);
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(718, 34);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(330, 27);
            this.txt_TenKH.TabIndex = 3;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CCCD.Location = new System.Drawing.Point(718, 82);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(330, 27);
            this.txt_CCCD.TabIndex = 3;
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaTien.Location = new System.Drawing.Point(217, 89);
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.ReadOnly = true;
            this.txt_GiaTien.Size = new System.Drawing.Size(287, 27);
            this.txt_GiaTien.TabIndex = 3;
            // 
            // txt_MaCB
            // 
            this.txt_MaCB.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaCB.Location = new System.Drawing.Point(217, 34);
            this.txt_MaCB.Name = "txt_MaCB";
            this.txt_MaCB.ReadOnly = true;
            this.txt_MaCB.Size = new System.Drawing.Size(287, 27);
            this.txt_MaCB.TabIndex = 3;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Huy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
            this.btn_Huy.Location = new System.Drawing.Point(783, 130);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(128, 45);
            this.btn_Huy.TabIndex = 0;
            this.btn_Huy.Text = "HỦY VÉ";
            this.btn_Huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Them.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.Location = new System.Drawing.Point(937, 130);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(139, 45);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "THÊM VÉ";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Mua
            // 
            this.btn_Mua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Mua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mua.Image")));
            this.btn_Mua.Location = new System.Drawing.Point(955, 440);
            this.btn_Mua.Name = "btn_Mua";
            this.btn_Mua.Size = new System.Drawing.Size(121, 45);
            this.btn_Mua.TabIndex = 0;
            this.btn_Mua.Text = "MUA";
            this.btn_Mua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Mua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Mua.UseVisualStyleBackColor = false;
            this.btn_Mua.Click += new System.EventHandler(this.btn_Mua_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Check.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(81, 31);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(116, 30);
            this.btn_Check.TabIndex = 2;
            this.btn_Check.Text = "CHỌN CB";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(16, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 252);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã chuyến bay";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Vé";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên khách hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nơi Đi";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nơi đến";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CCCD";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá vé";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "CCCD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "QUẢN LÝ BÁN VÉ MÁY BAY";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem,
            this.TSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngKêDoanhThuTheoNgàyToolStripMenuItem,
            this.toolStripSeparator3,
            this.thốngKêSốVéBánĐượcToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thốngKêToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêToolStripMenuItem.Image")));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.thốngKêToolStripMenuItem.Text = "Dream Cloud";
            // 
            // thôngKêDoanhThuTheoNgàyToolStripMenuItem
            // 
            this.thôngKêDoanhThuTheoNgàyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngKêDoanhThuTheoNgàyToolStripMenuItem.Image")));
            this.thôngKêDoanhThuTheoNgàyToolStripMenuItem.Name = "thôngKêDoanhThuTheoNgàyToolStripMenuItem";
            this.thôngKêDoanhThuTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.thôngKêDoanhThuTheoNgàyToolStripMenuItem.Text = "Đăng Xuất";
            this.thôngKêDoanhThuTheoNgàyToolStripMenuItem.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // thốngKêSốVéBánĐượcToolStripMenuItem
            // 
            this.thốngKêSốVéBánĐượcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêSốVéBánĐượcToolStripMenuItem.Image")));
            this.thốngKêSốVéBánĐượcToolStripMenuItem.Name = "thốngKêSốVéBánĐượcToolStripMenuItem";
            this.thốngKêSốVéBánĐượcToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thốngKêSốVéBánĐượcToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.thốngKêSốVéBánĐượcToolStripMenuItem.Text = "Thoát";
            this.thốngKêSốVéBánĐượcToolStripMenuItem.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // TSM
            // 
            this.TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýLịchBayToolStripMenuItem,
            this.toolStripSeparator2,
            this.quảnLýVéToolStripMenuItem,
            this.toolStripSeparator1,
            this.quảnLýNhânViênToolStripMenuItem,
            this.toolStripSeparator4,
            this.quảnLýKhuyếnMãiToolStripMenuItem,
            this.toolStripSeparator5,
            this.thốngKêToolStripMenuItem1});
            this.TSM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSM.Name = "TSM";
            this.TSM.Size = new System.Drawing.Size(75, 26);
            this.TSM.Text = "Quản lý";
            // 
            // quảnLýLịchBayToolStripMenuItem
            // 
            this.quảnLýLịchBayToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýLịchBayToolStripMenuItem.Image")));
            this.quảnLýLịchBayToolStripMenuItem.Name = "quảnLýLịchBayToolStripMenuItem";
            this.quảnLýLịchBayToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.quảnLýLịchBayToolStripMenuItem.Text = "Lịch bay";
            this.quảnLýLịchBayToolStripMenuItem.Click += new System.EventHandler(this.btn_LichBay_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(214, 6);
            // 
            // quảnLýVéToolStripMenuItem
            // 
            this.quảnLýVéToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýVéToolStripMenuItem.Image")));
            this.quảnLýVéToolStripMenuItem.Name = "quảnLýVéToolStripMenuItem";
            this.quảnLýVéToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.quảnLýVéToolStripMenuItem.Text = "Quản lý vé ";
            this.quảnLýVéToolStripMenuItem.Click += new System.EventHandler(this.btn_Ve_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýNhânViênToolStripMenuItem.Image")));
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(214, 6);
            // 
            // quảnLýKhuyếnMãiToolStripMenuItem
            // 
            this.quảnLýKhuyếnMãiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýKhuyếnMãiToolStripMenuItem.Image")));
            this.quảnLýKhuyếnMãiToolStripMenuItem.Name = "quảnLýKhuyếnMãiToolStripMenuItem";
            this.quảnLýKhuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.quảnLýKhuyếnMãiToolStripMenuItem.Text = "Khuyến mãi ";
            this.quảnLýKhuyếnMãiToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(214, 6);
            // 
            // thốngKêToolStripMenuItem1
            // 
            this.thốngKêToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêToolStripMenuItem1.Image")));
            this.thốngKêToolStripMenuItem1.Name = "thốngKêToolStripMenuItem1";
            this.thốngKêToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.thốngKêToolStripMenuItem1.Text = "Thống kê";
            this.thốngKêToolStripMenuItem1.Click += new System.EventHandler(this.thốngKêToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(235)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(879, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1117, 758);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GRB_DatVe);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Vé Máy Bay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GRB_DatVe.ResumeLayout(false);
            this.GRB_DatVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GRB_DatVe;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.TextBox txt_GiaTien;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Mua;
        private System.Windows.Forms.Button btn_ChonVe;
        public System.Windows.Forms.TextBox txt_MaCB;
        private System.Windows.Forms.Button btn_Them;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ChonKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngKêDoanhThuTheoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSốVéBánĐượcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSM;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLịchBayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quảnLýVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhuyếnMãiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

