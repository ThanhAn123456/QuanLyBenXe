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
    public partial class QuanLyKhachHang : Form
    {
        XULYDULIEU xuly = new XULYDULIEU();
        String sql;
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            sql = "select * from khach_hang";
            grvQuanLyKhachHang.DataSource = xuly.getTable(sql);
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        private void grvQuanLyKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhachHang.Text = grvQuanLyKhachHang.Rows[e.RowIndex].Cells["ma_khach_hang"].FormattedValue.ToString();
            txtHoVaTen.Text = grvQuanLyKhachHang.Rows[e.RowIndex].Cells["ho_ten"].FormattedValue.ToString();
            if (grvQuanLyKhachHang.Rows[e.RowIndex].Cells["gioi_tinh"].FormattedValue.ToString()=="Nam")
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
       
            dateTimePickerNgaySinh.Value = DateTime.Parse(grvQuanLyKhachHang.Rows[e.RowIndex].Cells["ngay_sinh"].FormattedValue.ToString());
            txtDiaChi.Text = grvQuanLyKhachHang.Rows[e.RowIndex].Cells["dia_chi"].FormattedValue.ToString();
            txtSoDienThoai.Text = grvQuanLyKhachHang.Rows[e.RowIndex].Cells["so_dien_thoai"].FormattedValue.ToString();
        }
    }
}
