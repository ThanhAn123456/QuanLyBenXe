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
        }
    }
}
