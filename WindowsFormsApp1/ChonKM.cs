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
    public partial class ChonKM : Form
    {
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        public ChonKM()
        {
            InitializeComponent();
        }

        private void ChonKM_Load(object sender, EventArgs e)
        {
            List<KHUYENMAI> listKM = db.KHUYENMAIs.ToList();
            FillDgv(listKM);
        }

        private void FillDgv(List<KHUYENMAI> listKM)
        {
            dataGridView1.Rows.Clear();
            
            foreach (var item in listKM)
            {
                int newRow = dataGridView1.Rows.Add();
                dataGridView1.Rows[newRow].Cells[0].Value = item.MaKM;
                dataGridView1.Rows[newRow].Cells[1].Value = item.NgayBatDau;
                dataGridView1.Rows[newRow].Cells[2].Value = item.NgayKetThuc;
                dataGridView1.Rows[newRow].Cells[3].Value = item.DieuKienSD;
                dataGridView1.Rows[newRow].Cells[4].Value = item.GiaTriKhuyenMai;
            }
        }
        public int GTKM;
        public static string MaKM;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult = DialogResult.OK;
            GTKM = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            MaKM = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }
    }
}
