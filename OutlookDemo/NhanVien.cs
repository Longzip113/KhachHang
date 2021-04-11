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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(2);
            guna2DataGridView1.Rows[0].Cells[0].Value = Image.FromFile("photos\\businessman.png");
            guna2DataGridView1.Rows[0].Cells[1].Value = "Nguyễn Thành Long";
            guna2DataGridView1.Rows[0].Cells[2].Value = "65/17 Nguyễn Đỗ Cung TP.HCM";
            guna2DataGridView1.Rows[0].Cells[3].Value = "464579945";
            guna2DataGridView1.Rows[0].Cells[4].Value = "Nam";
            guna2DataGridView1.Rows[0].Cells[5].Value = "25-05-1999";
            guna2DataGridView1.Rows[0].Cells[6].Value = "8.000.000";

            guna2DataGridView1.Rows[1].Cells[0].Value = Image.FromFile("photos\\businessman.png");
            guna2DataGridView1.Rows[1].Cells[1].Value = "Hứa Đông Xuân";
            guna2DataGridView1.Rows[1].Cells[2].Value = "38/34 Nguyễn Văn Vịnh TP.HCM";
            guna2DataGridView1.Rows[1].Cells[3].Value = "464579945";
            guna2DataGridView1.Rows[1].Cells[4].Value = "Nữ";
            guna2DataGridView1.Rows[1].Cells[5].Value = "20-10-2000";
            guna2DataGridView1.Rows[1].Cells[6].Value = "10.000.000";
        }
    }
}
