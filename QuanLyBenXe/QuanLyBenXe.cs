using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBenXe
{
    public partial class QuanLyBenXe : Form
    {
        XULYDULIEU xuly = new XULYDULIEU();
        String sql;
        string path = Application.StartupPath + "\\data\\quanlybenxe.xml";
        public QuanLyBenXe()
        {
            InitializeComponent();
            
        }
        private void QuanLyBenXe_Load(object sender, EventArgs e)
        {
            sql = "select * from benxe";
            dgvQuanLyBenXe.DataSource = xuly.getTable(sql);
            sql = "select mabenxe from benxe ";
            cbQuanLyBenXe.Items.Clear();
            DataTable dt = xuly.getTable(sql);
            int index = 0;
            foreach(DataRow row in dt.Rows)
            {
                object item = row[index];
                cbQuanLyBenXe.Items.Add(item);
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            sql = "select * from benxe where tenbenxe like N'%" + txtTimKiem.Text+"%'";
            dgvQuanLyBenXe.DataSource = xuly.getTable(sql);
        }
        private void showFileXml_Click(object sender, EventArgs e)
        {
            xuly.ViewXML(path);
        }
        private void btnDbToXML_Click(object sender, EventArgs e)
        {
            sql = "Select * from benxe for xml auto";
            DataTable dt = new DataTable();
            dt = xuly.getTable(sql);
            string xml = "<?xml version='1.0'?><benxe>";

            xml += dt.Rows[0].ItemArray[0].ToString() + "</benxe>";

            XmlDocument XmlDoc = new XmlDocument();

            XmlDoc.LoadXml(xml); // nạp chuổi XML vào cây XML

            XmlDoc.Save(path);

            xuly.ViewXML(path);
        }
        private void dgvQuanLyBenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("ok");
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvQuanLyBenXe.Rows[e.RowIndex];
                txtMaBenXe.Text = row.Cells[0].Value.ToString();
                txtTenBenXe.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtMaBenXe.Enabled = false;
            }
        }

        public void reset()
        {
            txtMaBenXe.Text = "";
            txtTenBenXe.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtMaBenXe.Enabled = true;
            sql = "select * from benxe";
            dgvQuanLyBenXe.DataSource = xuly.getTable(sql);
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
           reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sql = "insert into benxe values('" + txtMaBenXe.Text + "',N'" + txtTenBenXe.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "')";
            xuly.ExeCute(sql);
            reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sql = "update benxe set tenbenxe = N'" + txtTenBenXe.Text + "',diachi = N'" + txtDiaChi.Text + "',sodienthoai = '" + txtSDT.Text + "' where mabenxe = '" + txtMaBenXe.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sql = "delete from benxe where mabenxe = '"+ txtMaBenXe.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void cbQuanLyBenXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy ID của mục đã chọn
                string selectedItem = cbQuanLyBenXe.Text.Trim();
                string sql2 = "SELECT * FROM benxe WHERE mabenxe = '" + selectedItem + "'";
                dgvQuanLyBenXe.DataSource = xuly.getTable(sql2); 
        }

        private void cbQuanLyBenXe_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXmlToDb_Click(object sender, EventArgs e)
        {
            try
            {
                xuly.ExeCute("delete from benxe");

                xuly.capNhatTungBang(path,"benxe");
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
