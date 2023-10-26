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
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class QLVe : Form
    {
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        public QLVe()
        {
            InitializeComponent();
        }

        private void QLVe_Load(object sender, EventArgs e)
        {
            List<CHUYENBAY> listchuyenbay = db.CHUYENBAYs.ToList();
            FillCMB(listchuyenbay);
        }

        private void FillCMB(List<CHUYENBAY> listCB)
        {
            comboBox1.DataSource = listCB;
            comboBox1.DisplayMember = "MaCB";
            comboBox1.ValueMember = "MaCB";
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            List<Ve> listve = new List<Ve>();
            List<Ghe> listghe = db.Ghes.ToList();

            for (int i = 0; i < listghe.Count; i++)
            {
                Ve ve = new Ve();
                ve.MaVe = listghe[i].MaGhe.Trim() + comboBox1.Text;
                ve.MaCB = comboBox1.Text;
                ve.MaGhe = listghe[i].MaGhe;
                ve.TrangThai = 0;
                if (listghe[i].LoaiGhe == "Vip")
                    ve.GiaTien = 1890000;
                else
                    ve.GiaTien = 1350000;
                listve.Add(ve);
            }
            FillGDV(listve);
        }

        private void FillGDV(List<Ve> listve)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listve.Count; i++)
            {
                int newRow = dataGridView1.Rows.Add();
                dataGridView1.Rows[newRow].Cells[0].Value = listve[i].MaVe;
                dataGridView1.Rows[newRow].Cells[1].Value = listve[i].GiaTien;
                dataGridView1.Rows[newRow].Cells[2].Value = listve[i].TrangThai;
                dataGridView1.Rows[newRow].Cells[3].Value = listve[i].MaGhe;
                dataGridView1.Rows[newRow].Cells[4].Value = listve[i].MaCB;
            }

        }
        private string mave;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_GiaTien.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                txt_Trangthai.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                mave = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {
                
            }
        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            int row = -1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString().Trim() == mave.Trim())
                {
                    row = i;
                    break;
                }
            }
            dataGridView1.Rows[row].Cells[1].Value = txt_GiaTien.Text.Trim();
            dataGridView1.Rows[row].Cells[2].Value = txt_Trangthai.Text.Trim();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    Ve ve = db.Ves.FirstOrDefault(p => p.MaVe.Trim() == mave.Trim());
                    if (ve != null) 
                    {
                        ve.GiaTien = int.Parse(txt_GiaTien.Text.Trim());
                        ve.TrangThai = int.Parse(txt_Trangthai.Text.Trim());
                    }
                    else
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            Ve newVe = new Ve();
                            newVe.MaVe = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
                            newVe.GiaTien = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString().Trim());
                            newVe.TrangThai = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString().Trim());
                            newVe.MaGhe = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
                            newVe.MaCB = dataGridView1.Rows[i].Cells[4].Value.ToString().Trim();
                            db.Ves.Add(newVe);
                        }
                    }

                    db.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show("Đã lưu vào CSDL!!!", "Thông báo", MessageBoxButtons.OK);
                    dataGridView1.Rows.Clear();
                    txt_Trangthai.Text = string.Empty;
                    txt_GiaTien.Text = string.Empty;
                }
                catch
                {
                    transaction.Rollback();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Ve> listve = db.Ves.Where(p => p.MaCB.Trim() == comboBox1.Text.Trim()).ToList();
            FillGDV(listve);
            if (dataGridView1.Rows.Count <= 0)
            {
                btn_Thêm.Enabled = true;
            }
            else
            {
                btn_Thêm.Enabled = false;
            }
        }
    }
}
