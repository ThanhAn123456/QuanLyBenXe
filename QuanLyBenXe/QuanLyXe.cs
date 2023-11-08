using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyBenXe
{
    public partial class QuanLyXe : Form
    {
        XULYDULIEU xuly = new XULYDULIEU();
        String sql;
        string path = Application.StartupPath + "\\data\\quanlyxe.xml";
        public QuanLyXe()
        {
            InitializeComponent();
        }

        private void QuanLyXe_Load(object sender, EventArgs e)
        {
            sql = "select * from xe";
            grvQuanLyXe.DataSource = xuly.getTable(sql);
            cbbTimKiem.Items.Clear();
            cbbTimKiem.Items.Add("maxe");
            cbbTimKiem.Items.Add("tenxe");
            cbbTimKiem.Items.Add("soghe");
        }

        private void grvQuanLyXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaXe.Text = grvQuanLyXe.Rows[e.RowIndex].Cells["maxe"].FormattedValue.ToString();
                txtTenXe.Text = grvQuanLyXe.Rows[e.RowIndex].Cells["tenxe"].FormattedValue.ToString();
                txtSoGhe.Text = grvQuanLyXe.Rows[e.RowIndex].Cells["soghe"].FormattedValue.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            sql = "select * from xe where " + cbbTimKiem.SelectedItem.ToString() + " like N'%" + txtTimKiem.Text + "%'";
            grvQuanLyXe.DataSource = xuly.getTable(sql);
        }

        public void reset()
        {
            txtMaXe.Text = "";
            txtSoGhe.Text = "";
            txtTenXe.Text = "";
            sql = "select * from xe";
            grvQuanLyXe.DataSource = xuly.getTable(sql);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO xe VALUES('" + txtMaXe.Text + "', N'" + txtTenXe.Text + "', " + txtSoGhe.Text +")";
            xuly.ExeCute(sql);
            reset();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            sql = "update xe set tenxe = N'" + txtTenXe.Text + "' ,soghe = '" + txtSoGhe.Text + "' where maxe = '" + txtMaXe.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sql = "delete from xe where maxe = '" + txtMaXe.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void btnDbToXML_Click(object sender, EventArgs e)
        {
            sql = "Select * from xe for xml auto";
            DataTable dt = new DataTable();
            dt = xuly.getTable(sql);
            string xml = "<?xml version='1.0'?><xe>";

            xml += dt.Rows[0].ItemArray[0].ToString() + "</xe>";

            XmlDocument XmlDoc = new XmlDocument();

            XmlDoc.LoadXml(xml); // nạp chuổi XML vào cây XML

            XmlDoc.Save(path);

            xuly.ViewXML(path);
        }

        private void btnXmlToDb_Click(object sender, EventArgs e)
        {
            try
            {
                xuly.ExeCute("delete from xe");

                xuly.capNhatTungBang(path, "xe");
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void showFileXml_Click(object sender, EventArgs e)
        {
            xuly.ViewXML(path);
        }
    }
}
