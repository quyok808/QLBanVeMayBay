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
    public partial class FormNV : Form
    {
        public FormNV()
        {
            InitializeComponent();

        }

        DB_BanVeMayBay context = new DB_BanVeMayBay();

        private void Form1_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> listNV = context.NHANVIENs.ToList();
            FillFalcutyComboBox();
            BindGrid(listNV);
        }
        // Thoát form 
        private void Form_NV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?","Xác nhận", MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.No) 
            { 
                e.Cancel = true;
            }
        }

        //Fill combobox
        public void FillFalcutyComboBox()
        {
            cbbChucVu.Items.Add("Nhân Viên Thu Ngân");
            cbbChucVu.Items.Add("Quản Lý");
        }

        //Fill
        public void BindGrid(List<NHANVIEN> nhanviens)
        {
            dtgv_NV.Rows.Clear();
            foreach (var item in nhanviens)
            {
                int index = dtgv_NV.Rows.Add();
                dtgv_NV.Rows[index].Cells[0].Value = item.MaNV;
                dtgv_NV.Rows[index].Cells[1].Value = item.TenNV;
                dtgv_NV.Rows[index].Cells[2].Value = item.ChucVu;
                dtgv_NV.Rows[index].Cells[3].Value = item.SDT;
                dtgv_NV.Rows[index].Cells[4].Value = item.DiaChi;
                dtgv_NV.Rows[index].Cells[5].Value = item.Luong;
                dtgv_NV.Rows[index].Cells[6].Value = item.NgaySinh;
            }
        }

        // Thêm
        public void add(NHANVIEN n)
        {
            context.NHANVIENs.Add(n);
            context.SaveChanges();
        }

        // Kiểm tra rỗng
        public bool checkNull()
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == ""|| txtSDT.Text == "" || txtLuong.Text == "")
                return true;
            return false;
        }
        // Check cbb rỗng
        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChucVu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một chức vụ !!!");
                cbbChucVu.SelectedIndex = 0;
            }
        }

        // Nút thêm dữ liệu
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var transaction = context.Database.BeginTransaction())
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
                        NHANVIEN n = new NHANVIEN()
                        {
                            MaNV = txtMaNV.Text,
                            TenNV = txtTenNV.Text,
                            ChucVu = cbbChucVu.SelectedItem.ToString(),
                            SDT = txtSDT.Text,
                            DiaChi = txtDiaChi.Text,
                            NgaySinh = NSPicker.Value,
                            Luong = int.Parse(txtLuong.Text)
                        };
                        add(n);
                        Role newrole = new Role();
                        newrole.Username = n.MaNV.Trim();
                        newrole.Password = newrole.Username;
                        newrole.RoleName = n.ChucVu.Trim();
                        context.Roles.Add(newrole);
                    }
                    context.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show("Thêm mới dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                    Form1_Load(sender, e); 
                }
                catch
                {
                    transaction.Rollback();
                }
            }
        }

        // Nút sửa dữ liệu 
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN dpUpdate = context.NHANVIENs.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
                if (dpUpdate != null)
                {
                    dpUpdate.TenNV = txtTenNV.Text;
                    dpUpdate.ChucVu = cbbChucVu.SelectedItem.ToString();
                    dpUpdate.SDT = txtSDT.Text;
                    dpUpdate.DiaChi = txtDiaChi.Text;
                    dpUpdate.Luong = int.Parse(txtLuong.Text);
                    dpUpdate.NgaySinh = NSPicker.Value;
                    context.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    var nhanviens = context.NHANVIENs.ToList();
                    Form1_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Nút xóa dữ liệu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN dbDelete = context.NHANVIENs.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
                if (dbDelete != null)
                {
                    context.NHANVIENs.Remove(dbDelete);
                    Role deleteRole = context.Roles.FirstOrDefault(p => p.Username.Trim() == txtMaNV.Text.Trim());
                    context.Roles.Remove(deleteRole);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    var nhanviens = context.NHANVIENs.ToList();
                    Form1_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Nhấp chuột vào dtgv và hiển thị vào textbox
        private void dtgv_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = int.Parse(e.RowIndex.ToString());
            txtMaNV.Text = dtgv_NV[0, index].Value.ToString();
            txtTenNV.Text = dtgv_NV[1, index].Value.ToString();
            cbbChucVu.Text = dtgv_NV[2, index].Value.ToString();
            txtSDT.Text = dtgv_NV[3, index].Value.ToString();
            txtDiaChi.Text = dtgv_NV[4, index].Value.ToString();
            txtLuong.Text = dtgv_NV[5, index].Value.ToString();
            NSPicker.Text = dtgv_NV[6, index].Value.ToString();
        }
            
       
    }
}
