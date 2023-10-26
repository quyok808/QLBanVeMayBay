namespace WindowsFormsApp1
{
    partial class TienMat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TienMat));
            this.txtTraLai = new System.Windows.Forms.TextBox();
            this.txtTienKhachDua = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTraLai
            // 
            this.txtTraLai.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraLai.ForeColor = System.Drawing.Color.White;
            this.txtTraLai.Location = new System.Drawing.Point(327, 224);
            this.txtTraLai.Name = "txtTraLai";
            this.txtTraLai.ReadOnly = true;
            this.txtTraLai.Size = new System.Drawing.Size(421, 39);
            this.txtTraLai.TabIndex = 10;
            this.txtTraLai.Text = "0";
            this.txtTraLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKhachDua.Location = new System.Drawing.Point(327, 137);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.Size = new System.Drawing.Size(421, 39);
            this.txtTienKhachDua.TabIndex = 11;
            this.txtTienKhachDua.Text = "0";
            this.txtTienKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienKhachDua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTienKhachDua_MouseClick);
            this.txtTienKhachDua.TextChanged += new System.EventHandler(this.txtTraLai_TextChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Transparent;
            this.txtTongTien.Location = new System.Drawing.Point(327, 49);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(421, 39);
            this.txtTongTien.TabIndex = 12;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số tiền trả lại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số Tiền Khách Đưa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tổng Tiền:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 109);
            this.panel1.TabIndex = 14;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btn_XacNhan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_XacNhan.BackgroundImage")));
            this.btn_XacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhan.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.ForeColor = System.Drawing.Color.PeachPuff;
            this.btn_XacNhan.Location = new System.Drawing.Point(694, 437);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(80, 68);
            this.btn_XacNhan.TabIndex = 15;
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // TienMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTraLai);
            this.Controls.Add(this.txtTienKhachDua);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TienMat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TienMat";
            this.Load += new System.EventHandler(this.btnTIMA_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTraLai;
        private System.Windows.Forms.TextBox txtTienKhachDua;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_XacNhan;
    }
}