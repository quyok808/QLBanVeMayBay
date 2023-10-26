using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    
    public partial class ThanhToan : Form
    {
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TienMat frm = new TienMat();
            if (frm.ShowDialog() == DialogResult.OK);
            {
                btn_XacNhan.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MOMO frm = new MOMO();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                btn_XacNhan.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tong = Form1.tong;
            txtTongVNPay.Text = tong.ToString();
            panel1.Visible = true;
            btn_XacNhan.Enabled = true;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

       
    }
}

