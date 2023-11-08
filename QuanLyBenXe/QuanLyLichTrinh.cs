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
    public partial class QuanLyLichTrinh : Form
    {
        XULYDULIEU xuly = new XULYDULIEU();
        String sql;
        string path = Application.StartupPath + "\\data\\quanlylichtrinh.xml";

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
            sql = "Select * from lichtrinh for xml auto";
            DataTable dt = new DataTable();
            dt = xuly.getTable(sql);
            string xml = "<?xml version='1.0'?><lichtrinh>";

            xml += dt.Rows[0].ItemArray[0].ToString() + "</lichtrinh>";

            XmlDocument XmlDoc = new XmlDocument();

            XmlDoc.LoadXml(xml); // nạp chuổi XML vào cây XML

            XmlDoc.Save(path);

            xuly.ViewXML(path);

            reset();
        }

        private void XMLTODB_Click(object sender, EventArgs e)
        {
            try
            {
                xuly.ExeCute("delete from lichtrinh");

                xuly.capNhatTungBang(path, "lichtrinh");
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        public void reset()
        {
            txtMaLichTrinh.Text = "";
            txtMaBenXe.Text = "";
            txtMaTuyenXe.Text = "";
            txtMaXe.Text = "";
            txtMaKhachHang.Text = "";
            txtNgayDi.Text = "";
            txtGioDi.Text = "";
            txtGiaVe.Text = "";
            String newsql = "select * from lichtrinh";
            dvgQuanLyLichTrinh.DataSource = xuly.getTable(newsql);
        }

        private void btnThemLichTrinh_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO lichtrinh VALUES ('" + txtMaLichTrinh.Text + "', '" + txtMaBenXe.Text + "', '" + txtMaTuyenXe.Text + "', '" + txtMaXe.Text + "', '" + txtMaKhachHang.Text + "', '" + txtNgayDi.Text + "', '" + txtGioDi.Text + "', " + txtGiaVe.Text + ")";
            xuly.ExeCute(sql);
             reset();
        }

        private void btnSuaLichTrinh_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "UPDATE lichtrinh SET mabenxe = '" + txtMaBenXe.Text + "', matuyenxe = '" + txtMaTuyenXe.Text + "', maxe = '" + txtMaXe.Text + "', makhachhang = '" + txtMaKhachHang.Text + "', ngaydi = '" + txtNgayDi.Text + "', giodi = '" + txtGioDi.Text + "', giave = " + txtGiaVe.Text + " WHERE malichtrinh = '" + txtMaLichTrinh.Text + "'";

            xuly.ExeCute(sqlUpdate);
            reset();
        }

        private void btnXoaLichTrinh_Click(object sender, EventArgs e)
        {
            string maLichTrinhCanXoa = txtMaLichTrinh.Text; // Điền mã lịch trình cần xóa ở đây
            string sqlDelete = "DELETE FROM lichtrinh WHERE malichtrinh = '" + txtMaLichTrinh.Text + "'";
            xuly.ExeCute(sqlDelete);
            reset();

        }
    }
}
