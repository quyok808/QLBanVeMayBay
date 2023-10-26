using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int role = Login.role;
        public Form1()
        {
            InitializeComponent();
        }
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (role == 0)
            {
                btn_Huy.Enabled = false;
                TSM.Visible = false;
            }
            txt_MaCB.Text = "";
            txt_TenKH.Text = "";
            txt_GiaTien.Text = "";
            txt_CCCD.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }
        public string mcb = ChuyenBay.mscb;
        private void btn_Check_Click(object sender, EventArgs e)
        {
            ChuyenBay frm = new ChuyenBay();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txt_MaCB.Text = frm.mcb;
            }
        }
        public string mave;
        private void btn_ChonVe_Click(object sender, EventArgs e)
        {
            if (txt_MaCB.Text != "")
            {
                ChonVe frm = new ChonVe();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txt_GiaTien.Text = frm.giatien.ToString();
                    mave = frm.mave;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn chuyến bay");
            }
        }
        public static int tong;
        private int tongtt()
        {  
            int tong = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                tong += int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }  
            return tong;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            int rows = -1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString().Trim() == mave.Trim())
                {

                    rows = i;
                    break;
                }
            }
            if (rows == -1)
            {
                if (txt_MaCB.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn chuyến bay");
                }
                else
                {
                    CHUYENBAY cb = db.CHUYENBAYs.FirstOrDefault(p => p.MaCB == txt_MaCB.Text);
                    int newRow = dataGridView1.Rows.Add();
                    dataGridView1.Rows[newRow].Cells[0].Value = cb.MaCB;
                    dataGridView1.Rows[newRow].Cells[1].Value = mave;
                    dataGridView1.Rows[newRow].Cells[2].Value = txt_TenKH.Text;
                    dataGridView1.Rows[newRow].Cells[5].Value = txt_CCCD.Text;
                    dataGridView1.Rows[newRow].Cells[6].Value = txt_GiaTien.Text;
                    dataGridView1.Rows[newRow].Cells[3].Value = cb.NoiDi;
                    dataGridView1.Rows[newRow].Cells[4].Value = cb.NoiDen;

                    txt_MaCB.Text = "";
                    txt_TenKH.Text = "";
                    txt_GiaTien.Text = "";
                    txt_CCCD.Text = "";
                    txt_MaCB.Select();

                    tong = tongtt();
                    if (tong > 1900000) btn_ChonKM.Visible = true;
                }                
            }
            else
            {
                MessageBox.Show("Vé này đã được chọn, mời chọn vé khác");
            }


        }

        private void btn_Mua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn vé", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                ThanhToan frm = new ThanhToan();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                string t = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                Ve x = db.Ves.FirstOrDefault(p => p.MaVe == t.Trim());
                                if (x != null)
                                {
                                    x.TrangThai = 1;
                                }
                            }

                            HOADON hd = new HOADON();
                            hd.NgayLap = DateTime.Now;
                            hd.TongTien = tong;
                            hd.MaKM = ChonKM.MaKM;
                            db.HOADONs.Add(hd);

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                CTHD ct = new CTHD();
                                ct.MaHD = hd.MaHD;
                                ct.MaVe = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                ct.GiaTien = int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                                db.CTHDs.Add(ct);
                            }
                            db.SaveChanges();
                            transaction.Commit();
                            MessageBox.Show("Thanh toán thành công!!!", "Thông báo", MessageBoxButtons.OK);
                            dataGridView1.Rows.Clear();
                        }
                        catch
                        {
                            transaction.Rollback();
                        }
                    }
                }
            }

        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btn_LichBay_Click(object sender, EventArgs e)
        {
            ThemLichBay frm = new ThemLichBay();
            frm.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            FormNV frm = new FormNV();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKM frm = new FormKM();
            frm.Show();
        }
        string makm = ChonKM.MaKM;
        private void btn_ChonKM_Click(object sender, EventArgs e)
        {
            ChonKM frm = new ChonKM();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                tong = tong - frm.GTKM;
            }
        }

        private void btn_Ve_Click(object sender, EventArgs e)
        {
            QLVe frm = new QLVe();
            frm.Show();
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKeHoaDon frm = new ThongKeHoaDon();
            frm.Show();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Tim_HUY frm = new Tim_HUY();
            frm.Show();
        }
    }
}
