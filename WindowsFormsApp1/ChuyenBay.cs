using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class ChuyenBay : Form
    {
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        public ChuyenBay()
        {
            InitializeComponent();
        }
        
        private void ChuyenBay_Load(object sender, EventArgs e)
        {
            List<CHUYENBAY> listCB = db.CHUYENBAYs.ToList();
            FillDGV(listCB);
        }

        private void FillDGV(List<CHUYENBAY> listCB)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listCB.Count; i++)
            {
                int newRow = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = listCB[i].MaCB;
                dataGridView1.Rows[i].Cells[1].Value = listCB[i].NoiDi;
                dataGridView1.Rows[i].Cells[2].Value = listCB[i].NoiDen;
                dataGridView1.Rows[i].Cells[3].Value = listCB[i].GioKhoiHanh;
                dataGridView1.Rows[i].Cells[4].Value = listCB[i].MaMB;
            }
        }

        private void cmb_NoiDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CHUYENBAY> listNoiDi = db.CHUYENBAYs.Where(p => p.NoiDi == cmb_NoiDi.Text).ToList();
            FillCMB(listNoiDi);
        }

        private void FillCMB(List<CHUYENBAY> listNoiDen)
        {
            cmb_NoiDen.Text = " ";
            cmb_NoiDen.DataSource = listNoiDen;
            cmb_NoiDen.DisplayMember = "NoiDen";
            cmb_NoiDen.ValueMember = "MaCB";
        }

        public static string mscb;
        public string mcb;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mscb = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                mcb = mscb;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_NoiDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CHUYENBAY> listNoiDi = db.CHUYENBAYs.Where(p => p.NoiDi == cmb_NoiDi.Text).ToList();
            List<CHUYENBAY> listNoiDen =listNoiDi.Where(p => p.NoiDen == cmb_NoiDen.Text).ToList();
            FillDGV(listNoiDen);
        }
    }
}
