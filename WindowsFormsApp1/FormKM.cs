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
    public partial class FormKM : Form
    {
        public FormKM()
        {
            InitializeComponent();
        }

        DB_BanVeMayBay context = new DB_BanVeMayBay();

        private void FormKM_Load(object sender, EventArgs e)
        {
            List<KHUYENMAI> listKM = context.KHUYENMAIs.ToList();
            BindGrid(listKM);
        }
        
        // Xác nhận đóng form
        private void FormKM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Fill
        public void BindGrid(List<KHUYENMAI> khuyenmais)
        {
            dtgv_KM.Rows.Clear();
            foreach (var item in khuyenmais)
            {
                int index = dtgv_KM.Rows.Add();
                dtgv_KM.Rows[index].Cells[0].Value = item.MaKM;
                dtgv_KM.Rows[index].Cells[1].Value = item.NgayBatDau;
                dtgv_KM.Rows[index].Cells[2].Value = item.NgayKetThuc;
                dtgv_KM.Rows[index].Cells[3].Value = item.DieuKienSD;
                dtgv_KM.Rows[index].Cells[4].Value = item.GiaTriKhuyenMai;
            }
        }

        // Thêm
        public void add(KHUYENMAI n)
        {
            context.KHUYENMAIs.Add(n);
            context.SaveChanges();
        }

        // Xóa
        public void delete(KHUYENMAI n)
        {
            context.KHUYENMAIs.Remove(n);
            context.SaveChanges();
        }
        // Kiểm tra rỗng
        public bool checkNull()
        {
            if (txtMaKM.Text == "" || txtDKSD.Text == "" || txtGTKM.Text == "")
                return true;
            return false;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            KHUYENMAI dbDelete = context.KHUYENMAIs.FirstOrDefault(p => p.MaKM == txtMaKM.Text);
            if (dbDelete != null)
            {
                delete(dbDelete);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                var khuyenmais = context.KHUYENMAIs.ToList();
                BindGrid(khuyenmais);
            }
        }

        private void dtgv_KM_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = int.Parse(e.RowIndex.ToString());
            txtMaKM.Text = dtgv_KM[0, index].Value.ToString();
            BDPicker.Text = dtgv_KM[1, index].Value.ToString();
            KTPicker.Text = dtgv_KM[2, index].Value.ToString();
            txtDKSD.Text = dtgv_KM[3, index].Value.ToString();
            txtGTKM.Text = dtgv_KM[4, index].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkNull())
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                    return;
                }
                else
                {
                    KHUYENMAI n = new KHUYENMAI()
                    {
                        MaKM = txtMaKM.Text,
                        NgayBatDau = BDPicker.Value,
                        NgayKetThuc = KTPicker.Value,
                        DieuKienSD = txtDKSD.Text,
                        GiaTriKhuyenMai = float.Parse(txtGTKM.Text)
                    };
                    add(n);
                    MessageBox.Show("Thêm mới dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                    var khuyenmais = context.KHUYENMAIs.ToList();
                    BindGrid(khuyenmais);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KHUYENMAI dpUpdate = context.KHUYENMAIs.FirstOrDefault(p => p.MaKM == txtMaKM.Text);
            if (dpUpdate != null)
            {
                dpUpdate.MaKM = txtMaKM.Text;
                dpUpdate.NgayBatDau = BDPicker.Value;
                dpUpdate.NgayKetThuc = KTPicker.Value;
                dpUpdate.DieuKienSD = txtDKSD.Text;
                dpUpdate.GiaTriKhuyenMai = float.Parse(txtGTKM.Text);
                context.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                var khuyenmais = context.KHUYENMAIs.ToList();
                BindGrid(khuyenmais);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KHUYENMAI dbDelete = context.KHUYENMAIs.FirstOrDefault(p => p.MaKM == txtMaKM.Text);
            if (dbDelete != null)
            {
                delete(dbDelete);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                var khuyenmais = context.KHUYENMAIs.ToList();
                BindGrid(khuyenmais);
            }
        }
    }
}
