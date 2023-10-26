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
    public partial class Tim_HUY : Form
    {
        public Tim_HUY()
        {
            InitializeComponent();
        }
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        private void Tim_HUY_Load(object sender, EventArgs e)
        {
            List<CTHD> listcthd = db.CTHDs.ToList();
            filldata(listcthd);
        }

        private void filldata(List<CTHD> listcthd)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listcthd.Count; i++)
            {
                int newRow = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = listcthd[i].MaVe;
                dataGridView1.Rows[i].Cells[1].Value = listcthd[i].Ve.Ghe.LoaiGhe;
                dataGridView1.Rows[i].Cells[2].Value = listcthd[i].Ve.Ghe.MaGhe;
                dataGridView1.Rows[i].Cells[3].Value = listcthd[i].GiaTien;
                dataGridView1.Rows[i].Cells[4].Value = listcthd[i].Ve.MaCB;
            }
        }
        public string mave;
        public static string MaVE;

        private void txt_mv_TextChanged(object sender, EventArgs e)
        {
            if (txt_mv.Text != "")
            {
                List<CTHD> listmave = db.CTHDs.Where(p => p.MaVe.Contains(txt_mv.Text)).ToList();
                filldata(listmave);
            }
            else
                Tim_HUY_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    Ve v = db.Ves.FirstOrDefault(p => p.MaVe == txt_mv.Text);
                    if(v != null)
                    {
                        v.TrangThai = 0;
                        CTHD ct = db.CTHDs.FirstOrDefault(p => p.MaVe.Trim() == v.MaVe.Trim());
                        HOADON hd = db.HOADONs.FirstOrDefault(p => p.MaHD == ct.MaHD);
                        hd.TongTien -= ct.GiaTien;
                        if (hd.TongTien <= 0)
                        {
                            db.HOADONs.Remove(hd);
                        }
                        db.CTHDs.Remove(ct);            
                    }
                    db.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show("Huỷ vé thành công", "Thông báo", MessageBoxButtons.OK);  
                    dataGridView1.Rows.Clear();
                }
                catch
                {
                    transaction.Rollback();
                }
            }
            
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mv.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
        }
    }
}
