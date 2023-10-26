using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using static Sunny.UI.UIDataGridView;

namespace WindowsFormsApp1
{
    public partial class ThongKeHoaDon : Form
    {
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        public ThongKeHoaDon()
        {
            InitializeComponent();
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            List<HOADON> listhd = db.HOADONs.ToList();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listhd.Count; i++)
            {
                if (listhd[i].NgayLap.ToShortDateString() == dateTimePicker1.Value.ToShortDateString())
                {
                    int newRow = dataGridView1.Rows.Add();
                    dataGridView1.Rows[newRow].Cells[0].Value = listhd[i].MaHD;
                    dataGridView1.Rows[newRow].Cells[1].Value = listhd[i].NgayLap;
                    dataGridView1.Rows[newRow].Cells[2].Value = listhd[i].MaKM;
                    dataGridView1.Rows[newRow].Cells[3].Value = listhd[i].TongTien;
                }
            }
        }

        private int Tongtien()
        {
            int tong = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                tong += int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            return tong;
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(saveFileDialog.FileName);
            }
        }

        private void ToExcel(string fileName)
        {
            // khởi tạo wb rỗng
            XSSFWorkbook wb = new XSSFWorkbook();

            // Tạo ra 1 sheet
            ISheet sheet = wb.CreateSheet();
            try
            {


                // Bắt đầu ghi lên sheet

                // Tạo row
                var row0 = sheet.CreateRow(0);
                // Merge lại row đầu 3 cột
                row0.CreateCell(0); // tạo ra cell trc khi merge
                CellRangeAddress cellMerge = new CellRangeAddress(0, 0, 0, 3);
                sheet.AddMergedRegion(cellMerge);
                row0.GetCell(0).SetCellValue("Thống kê doanh thu trong ngày");

                var row1 = sheet.CreateRow(1);

                row1.CreateCell(0).SetCellValue("Tổng số hoá đơn:");
                row1.CreateCell(1).SetCellValue(Tongtien().ToString());
                row1.CreateCell(2).SetCellValue("Doanh thu:");
                row1.CreateCell(3).SetCellValue(dataGridView1.Rows.Count.ToString());

                var row2 = sheet.CreateRow(2);
                row2.CreateCell(0).SetCellValue("Mã hoá đơn");
                row2.CreateCell(1).SetCellValue("Ngày lập");
                row2.CreateCell(2).SetCellValue("Mã khuyến mãi");
                row2.CreateCell(3).SetCellValue("Tổng tiền");


                int rowIndex = 3;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    var newRow = sheet.CreateRow(rowIndex);
                    newRow.CreateCell(0).SetCellValue(item.Cells[0].Value + "");
                    newRow.CreateCell(1).SetCellValue(item.Cells[1].Value + "");
                    newRow.CreateCell(2).SetCellValue(item.Cells[2].Value + "");
                    newRow.CreateCell(3).SetCellValue(item.Cells[3].Value + "");
                    rowIndex++;
                }

                FileStream fs = new FileStream(fileName, FileMode.CreateNew);
                wb.Write(fs);
                MessageBox.Show("Lưu thành công !!!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                wb = null;
                sheet = null;
            }

        }
    }
}
