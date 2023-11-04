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
    public partial class QuanLyXe : Form
    {
        XULYDULIEU xuly = new XULYDULIEU();
        String sql;
        public QuanLyXe()
        {
            InitializeComponent();
        }

        private void QuanLyXe_Load(object sender, EventArgs e)
        {
            sql = "select * from xe";
            grvQuanLyXe.DataSource = xuly.getTable(sql);
        }
    }
}
