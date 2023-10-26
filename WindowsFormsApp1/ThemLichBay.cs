using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class ThemLichBay : Form
    {
        static DB_BanVeMayBay db = new DB_BanVeMayBay();
        
        List<Ghe> gn = db.Ghes.ToList();
        List<Ve> ve = db.Ves.ToList();
        List<MAYBAY> mb = db.MAYBAYs.ToList();
        List<SANBAY> listSB = db.SANBAYs.ToList();

        public bool checknull()
        {
            if (txtMaCB.Text == "" || cmbNoiDen.Text == "" || cmbNoiDi.Text == "" || cmbMaMB.Text == "")
                return true;
            return false;
        }

        public bool checkdate()
        {
            if (dtpNgayKhoiHanh.Value <= DateTime.Now)
                return true;
            return false;
        }
        public ThemLichBay()
        {
            InitializeComponent();
        }

        //fill dữ liệu
        public void BindtoGridView(List<CHUYENBAY> cb)
        {
            dgvAddCB.Rows.Clear();
            foreach (var vp in cb)
            {
                int index = dgvAddCB.Rows.Add();
                dgvAddCB.Rows[index].Cells[0].Value = vp.MaCB.Trim();
                dgvAddCB.Rows[index].Cells[1].Value = vp.NoiDi;
                dgvAddCB.Rows[index].Cells[2].Value = vp.NoiDen;
                dgvAddCB.Rows[index].Cells[3].Value = vp.GioKhoiHanh;
                dgvAddCB.Rows[index].Cells[4].Value = vp.MaSBDi;
                dgvAddCB.Rows[index].Cells[5].Value = vp.MaSBDen;
                dgvAddCB.Rows[index].Cells[6].Value = vp.MaMB;
            }
        }

        public void MaMBcmb(List<MAYBAY> maybaylist)
        {
            cmbMaMB.DataSource = maybaylist;
            cmbMaMB.DisplayMember = "MaMB";
            cmbMaMB.ValueMember = "MaMB";
        }

        //load form
        private void ThemLichBay_Load(object sender, EventArgs e)
        {
            try
            {
                List<CHUYENBAY> cb = db.CHUYENBAYs.ToList();
                List<SANBAY> listnoiden = db.SANBAYs.ToList();
                MaMBcmb(mb);
                BindtoGridView(cb);
                NoiDiCMB(listSB);
                NoiDenCMB(listnoiden);
                cmbNoiDen.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NoiDenCMB(List<SANBAY> listSB)
        {
            cmbNoiDen.DataSource = listSB;
            cmbNoiDen.DisplayMember = "TenTP";
            cmbNoiDen.ValueMember = "MaSB";
        }

        private void NoiDiCMB(List<SANBAY> listSB)
        {
            cmbNoiDi.DataSource = listSB;
            cmbNoiDi.DisplayMember = "TenTP";
            cmbNoiDi.ValueMember = "MaSB";
        }

        //nút thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (checknull())
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                    return;
                }
                if (checkdate())
                {
                    MessageBox.Show("Ngày nhập không hợp lệ", "Thông báo");
                    return;
                }
                CHUYENBAY cb = new CHUYENBAY();
                cb.MaCB = txtMaCB.Text;
                
                string noiDi = cmbNoiDi.Text.Trim();
                string noiDen = cmbNoiDen.Text.Trim();

                if (noiDi == noiDen)
                {
                    MessageBox.Show("Nơi đi không được trùng với nơi đến.", "Thông báo");
                    return;
                }
                else
                {
                    cb.NoiDi = cmbNoiDi.Text.Trim();
                    if (NoiThanhMaSB.ContainsKey(cb.NoiDi))
                    {
                        cb.MaSBDi = NoiThanhMaSB[cb.NoiDi];
                    }

                    cb.NoiDen = cmbNoiDen.Text.Trim();
                    if (NoiThanhMaSB.ContainsKey(cb.NoiDen))
                    {
                        cb.MaSBDen = NoiThanhMaSB[cb.NoiDen];
                    }
                }
                
                cb.GioKhoiHanh = dtpNgayKhoiHanh.Value;
                cb.MaMB = int.Parse(cmbMaMB.Text);
                
                db.CHUYENBAYs.Add(cb);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                ThemLichBay_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        //Thư viện thành phố và sân bay

        Dictionary<string, string> NoiThanhMaSB = new Dictionary<string, string>
            {
                {"Hồ Chí Minh", "TSN"},
                {"Hà Nội", "SNB"},
                {"Cam Ranh", "SCR"},
                {"Thanh Hóa", "STH"},
                {"Hà Tĩnh", "SHT"},
                {"Đà Lạt", "SDL"},
                {"SaPa", "SSP"},
                {"Nha Trang", "SNT"},
                {"Đà Nẵng", "SDN"},
                {"Hải Phòng", "SHP"},
                {"Phú Quốc", "SPQ"}
            };

        //nút xóa
        private void btnDel_Click(object sender, EventArgs e)
        {
            
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá chuyến bay này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    int check = 0;
                    if (checknull())
                    {
                        MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                        return;
                    }
                    if (result == DialogResult.Yes)
                    {
                        CHUYENBAY Del = db.CHUYENBAYs.FirstOrDefault(p => p.MaCB == txtMaCB.Text);
                        if (Del != null)
                        {
                            List<CTHD> listCTHD = db.CTHDs.ToList();
                            
                        
                            for (int i = 0; i <  listCTHD.Count; i++)
                            {
                                if (listCTHD[i].Ve.MaCB.Trim() == Del.MaCB.Trim())
                                {
                                    check = 1;
                                    break;
                                }
                            }

                            if (check == 1)
                            {
                                MessageBox.Show("Không thể xoá chuyến bay này vì đã có người mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } 
                            else
                            {
                            
                                    List<Ve> listVe = db.Ves.Where(p => p.MaCB.Trim() == txtMaCB.Text.Trim()).ToList();
                                    foreach (Ve ve in listVe)
                                    {
                                        db.Ves.Remove(ve);
                                    }
                                    db.CHUYENBAYs.Remove(Del);
                            }
                        }
                        if (check == 0)
                        {
                            db.SaveChanges();
                            transaction.Commit();
                            MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK);
                            ThemLichBay_Load(sender, e);
                        }
                    }
                    

                }
                catch
                {
                    transaction.Rollback();
                }
            }
        }

        //cell click
        private void dgvAddCB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = int.Parse(e.RowIndex.ToString());
            txtMaCB.Text = dgvAddCB[0, index].Value.ToString();
            cmbNoiDi.Text = dgvAddCB[1, index].Value.ToString();
            cmbNoiDen.Text = dgvAddCB[2, index].Value.ToString();
            dtpNgayKhoiHanh.Text = dgvAddCB[3, index].Value.ToString();
            cmbMaMB.Text = dgvAddCB[6, index].Value.ToString();
        }

        //nút sửa chuyến bay
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int check = 0;
                if (checknull())
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                    return;
                }
                if (checkdate())
                {
                    MessageBox.Show("Ngày nhập không hợp lệ", "Thông báo");
                    return;
                }
                CHUYENBAY Upd = db.CHUYENBAYs.FirstOrDefault(p => p.MaCB == txtMaCB.Text);
                if (Upd != null)
                {
                    List<CTHD> listCTHD = db.CTHDs.ToList();
                    for (int i = 0; i < listCTHD.Count; i++)
                    {
                        if (listCTHD[i].Ve.MaCB.Trim() == Upd.MaCB.Trim())
                        {
                            check = 1;
                            break;
                        }
                    }
                    if (check == 1)
                    {
                        MessageBox.Show("Không thể sửa chuyến bay này vì đã quá có người mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string noiDi = cmbNoiDi.Text.Trim();
                        string noiDen = cmbNoiDen.Text.Trim();

                        if (noiDi == noiDen)
                        {
                            MessageBox.Show("Nơi đi không được trùng với nơi đến.", "Thông báo");
                            return;
                        }
                        Upd.NoiDi = cmbNoiDi.Text.Trim();
                        Upd.NoiDen = cmbNoiDen.SelectedItem.ToString();
                        if (NoiThanhMaSB.ContainsKey(Upd.NoiDi))
                        {
                            Upd.MaSBDi = NoiThanhMaSB[Upd.NoiDi];
                        }

                        Upd.NoiDen = cmbNoiDen.Text.Trim();
                        if (NoiThanhMaSB.ContainsKey(Upd.NoiDen))
                        {
                            Upd.MaSBDen = NoiThanhMaSB[Upd.NoiDen];
                        }
                        Upd.GioKhoiHanh = dtpNgayKhoiHanh.Value;
                        Upd.MaMB = int.Parse(cmbMaMB.Text);
                        db.SaveChanges();
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        ThemLichBay_Load(sender, e);
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ThemLichBay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}