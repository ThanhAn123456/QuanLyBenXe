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
    public partial class QuanLyKhachHang : Form
    {
        XULYDULIEU xuly = new XULYDULIEU();
        String sql;
        string path = Application.StartupPath + "\\data\\quanlykhachhang.xml";
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            grvQuanLyKhachHang.DefaultCellStyle.Format = "dd/MM/yyyy";
            sql = "select * from khachhang";
            grvQuanLyKhachHang.DataSource = xuly.getTable(sql);
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            cbbTimKiem.Items.Clear();
            cbbTimKiem.Items.Add("makhachhang");
            cbbTimKiem.Items.Add("hoten");
            cbbTimKiem.Items.Add("gioitinh");
            cbbTimKiem.Items.Add("ngaysinh");
            cbbTimKiem.Items.Add("diachi");
            cbbTimKiem.Items.Add("sodienthoai");
        }

        private void grvQuanLyKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaKhachHang.Text = grvQuanLyKhachHang.Rows[e.RowIndex].Cells["makhachhang"].FormattedValue.ToString();
                txtHoVaTen.Text = grvQuanLyKhachHang.Rows[e.RowIndex].Cells["hoten"].FormattedValue.ToString();
                if (grvQuanLyKhachHang.Rows[e.RowIndex].Cells["gioitinh"].FormattedValue.ToString() == "Nam")
                {
                    radioButtonNam.Checked = true;
                }
                else
                {
                    radioButtonNu.Checked = true;
                }
                dateTimePickerNgaySinh.Value = DateTime.Parse(grvQuanLyKhachHang.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString());
                txtDiaChi.Text = grvQuanLyKhachHang.Rows[e.RowIndex].Cells["diachi"].FormattedValue.ToString();
                txtSoDienThoai.Text = grvQuanLyKhachHang.Rows[e.RowIndex].Cells["sodienthoai"].FormattedValue.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            sql = "select * from khachhang where " + cbbTimKiem.SelectedItem.ToString() + " like N'%" + txtTimKiem.Text + "%'";
            grvQuanLyKhachHang.DataSource = xuly.getTable(sql);
        }

        public void reset()
        {
            txtMaKhachHang.Text = "";
            txtHoVaTen.Text = "";
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            dateTimePickerNgaySinh.Value = DateTime.Today;
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            sql = "select * from khachhang";
            grvQuanLyKhachHang.DataSource = xuly.getTable(sql);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String gioitinh = "Nam";
            if(radioButtonNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            if (radioButtonNu.Checked == true)
            {
                gioitinh = "Nữ";
            }
            sql = "set dateformat dmy; INSERT INTO khachhang VALUES('" + txtMaKhachHang.Text + "', N'" + txtHoVaTen.Text + "', N'" + gioitinh + "', '" + dateTimePickerNgaySinh.Text + "', N'" + txtDiaChi.Text + "', '" + txtSoDienThoai.Text + "')";
            MessageBox.Show(sql);
            xuly.ExeCute(sql);
            reset();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            String gioitinh = "Nam";
            if (radioButtonNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            if (radioButtonNu.Checked == true)
            {
                gioitinh = "Nữ";
            }
            sql = "set dateformat dmy; update khachhang set hoten = N'" + txtHoVaTen.Text + "' ,gioitinh = N'" + gioitinh + "' ,ngaysinh = '" + dateTimePickerNgaySinh.Text + "' ,diachi = N'" + txtDiaChi.Text + "' ,sodienthoai = '" + txtSoDienThoai.Text + "' where makhachhang = '" + txtMaKhachHang.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sql = "delete from khachhang where makhachhang = '" + txtMaKhachHang.Text + "'";
            xuly.ExeCute(sql);
            reset();
        }

        private void btnDbToXML_Click(object sender, EventArgs e)
        {
            sql = "Select * from khachhang for xml auto";
            DataTable dt = new DataTable();
            dt = xuly.getTable(sql);
            string xml = "<?xml version='1.0'?><khachhang>";

            xml += dt.Rows[0].ItemArray[0].ToString() + "</khachhang>";

            XmlDocument XmlDoc = new XmlDocument();

            XmlDoc.LoadXml(xml); // nạp chuổi XML vào cây XML

            XmlDoc.Save(path);

            xuly.ViewXML(path);
        }

        private void btnXmlToDb_Click(object sender, EventArgs e)
        {
            try
            {
                xuly.ExeCute("delete from khachhang");

                xuly.capNhatTungBang(path, "khachhang");
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
