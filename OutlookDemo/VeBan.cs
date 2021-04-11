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
    public partial class VeBan : Form
    {
        public VeBan()
        {
            InitializeComponent();
        }

        private void VeBan_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(2);
            guna2DataGridView1.Rows[0].Cells[0].Value = Image.FromFile("photos\\ticket.png");
            guna2DataGridView1.Rows[0].Cells[1].Value = "MV001";
            guna2DataGridView1.Rows[0].Cells[2].Value = "Bố Gìa";
            guna2DataGridView1.Rows[0].Cells[3].Value = "15h - 16h30";
            guna2DataGridView1.Rows[0].Cells[4].Value = "2020-20-6";
            guna2DataGridView1.Rows[0].Cells[5].Value = "Rap CGV-07";
            guna2DataGridView1.Rows[0].Cells[6].Value = "G7";
            guna2DataGridView1.Rows[0].Cells[7].Value = "9013073004564983";
            guna2DataGridView1.Rows[0].Cells[8].Value = "Đỗ Duy Nhật";

            guna2DataGridView1.Rows[1].Cells[0].Value = Image.FromFile("photos\\ticket.png");
            guna2DataGridView1.Rows[1].Cells[1].Value = "MV001";
            guna2DataGridView1.Rows[1].Cells[2].Value = "Birds of Prey";
            guna2DataGridView1.Rows[1].Cells[3].Value = "15h - 16h30";
            guna2DataGridView1.Rows[1].Cells[4].Value = "2021-20-3";
            guna2DataGridView1.Rows[1].Cells[5].Value = "Rap CGV-05";
            guna2DataGridView1.Rows[1].Cells[6].Value = "H5";
            guna2DataGridView1.Rows[1].Cells[7].Value = "9013073004564983";
            guna2DataGridView1.Rows[1].Cells[8].Value = "Đỗ Duy Nhật";
        }
    }
}
