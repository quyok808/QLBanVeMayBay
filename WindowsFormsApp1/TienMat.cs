using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TienMat : Form
    {
        public TienMat()
        {
            InitializeComponent();
        }

        #region TIMA Payment
        private void btnTIMA_Click(object sender, EventArgs e)
        {
            int tong = Form1.tong;
            txtTongTien.Text = tong.ToString();
            for (int i = 0; i < 6; i++)
            {
                Button btn = new Button();
                btn.Location = new System.Drawing.Point(15 + i * 95, 28);
                btn.Name = (500000 * i + 500000).ToString();
                btn.Size = new System.Drawing.Size(86, 47);
                btn.TabIndex = 0;
                btn.Click += Click_chooseNumber;
                btn.Text = (500000 * i + 500000).ToString();
                btn.UseVisualStyleBackColor = true;
                panel1.Controls.Add(btn);
            }

        }

        private bool checkNum(string num)
        {
            bool check = int.TryParse(num, out int o);
            return check;
        }

        private void txtTraLai_TextChanged(object sender, EventArgs e)
        {
            int khachdua = 0;
            int tongtien = 0;
            if (txtTienKhachDua.Text != "" && checkNum(txtTienKhachDua.Text) == true)
            {
                khachdua = int.Parse(txtTienKhachDua.Text);
                tongtien = int.Parse(txtTongTien.Text);

            }
            int tralai = khachdua - tongtien;
            txtTraLai.Text = tralai.ToString();
        }

        private void txtTienKhachDua_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtTienKhachDua.Text == "0")
            {
                txtTienKhachDua.Text = "";
            }
        }

        private void Click_chooseNumber(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtTienKhachDua.Text = btn.Name;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkNum(txtTienKhachDua.Text) == false)
            {
                MessageBox.Show("Tiền khách đưa phải là số");
            }
            else if (int.Parse(txtTienKhachDua.Text) < int.Parse(txtTongTien.Text))
            {
                MessageBox.Show("Số tiền khách đưa phải lớn hơn tổng tiền");
            }
            else
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("Thanh toán thành công", "Thông báo",MessageBoxButtons.OK);
                this.Close();
            }
        }

       
    }
}
