using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyBenXe
{
    public partial class QuanLyTuyenXe : Form
    {
        XULYDULIEU xuly = new XULYDULIEU();
        String sql;
        String path = "../../quanlytuyenxe.xml";
        public QuanLyTuyenXe()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyTuyenXe_Load(object sender, EventArgs e)
        {
            sql = "select * from tuyenxe";
            dgvQuanLyTuyenXe.DataSource = xuly.getTable(sql);
            sql = "select matuyenxe from tuyenxe ";
            cbQuanLyTuyenXe.Items.Clear();
            DataTable dt = xuly.getTable(sql);
            int index = 0;
            foreach (DataRow row in dt.Rows)
            {
                object item = row[index];
                cbQuanLyTuyenXe.Items.Add(item);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            sql = "select * from tuyenxe where diemdi like N'"+txtTimKiem.Text+"' or diemden like N'"+txtTimKiem.Text+"'";
            dgvQuanLyTuyenXe.DataSource=xuly.getTable(sql);
        }

        private void btnDbToXml_Click(object sender, EventArgs e)
        {
            sql = "Select * from tuyenxe for xml auto";
            DataTable dt = new DataTable();
            dt = xuly.getTable(sql);
            string xml = "<?xml version='1.0'?><tuyenxe>";

            xml += dt.Rows[0].ItemArray[0].ToString() + "</tuyenxe>";

            XmlDocument XmlDoc = new XmlDocument();

            XmlDoc.LoadXml(xml); // nạp chuổi XML vào cây XML

            XmlDoc.Save(path);

            xuly.ViewXML(path);
        }

        private void dgvQuanLyTuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvQuanLyTuyenXe.Rows[e.RowIndex];
                txtMaTuyenXe.Text = row.Cells[0].Value.ToString();
                txtDiemDi.Text = row.Cells[1].Value.ToString();
                txtDiemDen.Text = row.Cells[2].Value.ToString();
                txtMaTuyenXe.Enabled = false;
            }
        }

        public void reset()
        {
            txtMaTuyenXe.Text = "";
            txtDiemDi.Text = "";
            txtDiemDen.Text = "";
            txtMaTuyenXe.Enabled = true;
            sql = "select * from tuyenxe";
            dgvQuanLyTuyenXe.DataSource = xuly.getTable(sql);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sql = "insert into tuyenxe values('" + txtMaTuyenXe.Text + "',N'" + txtDiemDi.Text + "',N'" + txtDiemDen.Text + "')";
            xuly.ExeCute(sql);
            reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sql = "update tuyenxe set diemdi = N'" + txtDiemDi.Text + "',diemden = N'" + txtDiemDen.Text +"' where matuyenxe = '" + txtMaTuyenXe.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sql = "delete from tuyenxe where matuyenxe = '" + txtMaTuyenXe.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void cbQuanLyTuyenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbQuanLyTuyenXe.Text.Trim();
            string sql2 = "SELECT * FROM tuyenxe WHERE matuyenxe = '" + selectedItem + "'";
            dgvQuanLyTuyenXe.DataSource = xuly.getTable(sql2);
        }

        private void btnXmlToDb_Click(object sender, EventArgs e)
        {
            try
            {
                xuly.ExeCute("delete from tuyenxe");

                xuly.capNhatTungBang(path, "tuyenxe");
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
