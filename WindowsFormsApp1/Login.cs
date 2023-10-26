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
    public partial class Login : Form
    {
        DB_BanVeMayBay db = new DB_BanVeMayBay();
        public Login()
        {
            InitializeComponent();
        }
        public static int role;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            int flag = 0;
            List<Role> listRole = db.Roles.ToList();
            Role checkQL = new Role();
            foreach (var item in listRole)
            {
                if (item.Username.Trim() == txt_Username.Text.Trim() && item.Password.Trim() == txt_Password.Text.Trim())
                {
                    flag = 1;
                    checkQL = item;
                    break;
                }
            }
            if (flag == 1)
            {
                if (checkQL.Username.Trim().Contains("QL"))
                {
                    role = 1;
                }
                else
                    role = 0;
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK);
                Login_Load(sender, e);
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Username.Select();
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }
    }
}
