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
    public partial class ChonVe : Form
    {
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        public ChonVe()
        {
            InitializeComponent();
        }
        private void ChonVe_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            string macb = ChuyenBay.mscb;
            List<Ve> listVe = db.Ves.Where(p => p.MaCB.Trim() == macb.Trim() && p.TrangThai == 0).ToList();
            FillDgv(listVe);
        }
        public int giatien;
        public static int Tien;
        private void FillDgv(List<Ve> listVe)
        {
            dgv_VeTrong.Rows.Clear();
            for (int i = 0; i < listVe.Count; i++)
            {
                int newRow = dgv_VeTrong.Rows.Add();
                dgv_VeTrong.Rows[i].Cells[0].Value = listVe[i].MaVe;
                dgv_VeTrong.Rows[i].Cells[1].Value = listVe[i].MaGhe;
                dgv_VeTrong.Rows[i].Cells[2].Value = listVe[i].Ghe.LoaiGhe;
                dgv_VeTrong.Rows[i].Cells[3].Value = listVe[i].GiaTien;
                dgv_VeTrong.Rows[i].Cells[4].Value = listVe[i].MaCB;
            }
        }
        public string mave;
        public static string MaVE;
        private void dgv_VeTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                giatien = int.Parse(dgv_VeTrong.Rows[e.RowIndex].Cells[3].Value.ToString());
                Tien = giatien;
                mave = dgv_VeTrong.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                MaVE = mave;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
