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
    public partial class ThanThiet : Form
    {
        public ThanThiet()
        {
            InitializeComponent();
        }

        private void ThanThiet_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(1);
            guna2DataGridView1.Rows[0].Cells[0].Value = Image.FromFile("photos\\user.png");
            guna2DataGridView1.Rows[0].Cells[1].Value = "Nguyễn Thành Long";
            guna2DataGridView1.Rows[0].Cells[2].Value = "2019-10-23";
            guna2DataGridView1.Rows[0].Cells[3].Value = "Đồng";
            guna2DataGridView1.Rows[0].Cells[4].Value = "100";
            guna2DataGridView1.Rows[0].Cells[5].Value = "20";
            guna2DataGridView1.Rows[0].Cells[6].Value = "The001";
            guna2DataGridView1.Rows[0].Cells[7].Value = "500000";
       
        }
    }
}
