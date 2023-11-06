using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class QuanLyLichTrinh : Form
    {
        XULYDULIEU xuly = new XULYDULIEU();
        String sql;

        public QuanLyLichTrinh()
        {
            InitializeComponent();
        }

        private void QuanLyLichTrinh_Load(object sender, EventArgs e)
        {
            sql = "select * from lichtrinh";
            dvgQuanLyLichTrinh.DataSource = xuly.getTable(sql);
        }

        private void DBTOXML_Click(object sender, EventArgs e)
        {

        }

        private void XMLTODB_Click(object sender, EventArgs e)
        {

        }

        private void dvgQuanLyLichTrinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("ok");
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dvgQuanLyLichTrinh.Rows[e.RowIndex];
                txtMaLichTrinh.Text = row.Cells[0].Value.ToString();
                txtMaBenXe.Text = row.Cells[1].Value.ToString();
                txtMaTuyenXe.Text = row.Cells[2].Value.ToString();
                txtMaXe.Text = row.Cells[3].Value.ToString();
                txtMaKhachHang.Text = row.Cells[4].Value.ToString();
                txtNgayDi.Text = row.Cells[5].Value.ToString();
                txtGioDi.Text = row.Cells[6].Value.ToString();
                txtGiaVe.Text = row.Cells[7].Value.ToString();
            }
        }

        private void dgvQuanLyLichTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
