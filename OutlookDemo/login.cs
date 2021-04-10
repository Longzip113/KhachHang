using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookDemo
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtUseName.Text.Equals("admin") && txtPassword.Text.Equals("1"))
            {
                Main main = new Main();
                main.Show();
            }
            else
            {
                mes.Text = "Tài khoản hoặc mật khẩu sai xin liên hệ với người yêu Xuân !!";
            }
        }
    }
}
