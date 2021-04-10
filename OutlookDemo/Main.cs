using Guna.UI2.WinForms;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void container(object _form)
        {

            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            container(new KhachHang());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            container(new ThanThiet());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            container(new KhachHang());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            container(new NhanVien());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            container(new VeBan());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            container(new DoanhThu());
        }
    }
}
