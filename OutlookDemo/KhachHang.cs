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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(2);
            guna2DataGridView1.Rows[0].Cells[0].Value = Image.FromFile("photos\\user.png");
            guna2DataGridView1.Rows[0].Cells[1].Value = "Nguyễn Thành Long";
            guna2DataGridView1.Rows[0].Cells[2].Value = "65/17 Nguyễn Đỗ Cung TP.HCM";
            guna2DataGridView1.Rows[0].Cells[3].Value = "0465214645";
            guna2DataGridView1.Rows[0].Cells[4].Value = "Nam";
            guna2DataGridView1.Rows[0].Cells[5].Value = "21";

            guna2DataGridView1.Rows[1].Cells[0].Value = Image.FromFile("photos\\user.png");
            guna2DataGridView1.Rows[1].Cells[1].Value = "Hứa Đông Xuân";
            guna2DataGridView1.Rows[1].Cells[2].Value = "38/34 Nguyễn Văn Vịnh TP.HCM";
            guna2DataGridView1.Rows[1].Cells[3].Value = "0216541524";
            guna2DataGridView1.Rows[1].Cells[4].Value = "Nữ";
            guna2DataGridView1.Rows[1].Cells[5].Value = "20";

            
        }
    }
}
