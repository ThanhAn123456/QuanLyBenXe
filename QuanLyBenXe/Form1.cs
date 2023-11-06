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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyXe quanLyXe = new QuanLyXe();
            quanLyXe.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            quanLyKhachHang.Show();
        }

        private void quảnLýTuyếnXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTuyenXe quanLyTuyenXe = new QuanLyTuyenXe();
            quanLyTuyenXe.Show();
        }

        private void quảnLýBếnXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyBenXe quanLyBenXe = new QuanLyBenXe();
            quanLyBenXe.Show();
        }

        private void quảnLýLịchTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLichTrinh quanLyLichTrinh = new QuanLyLichTrinh();
            quanLyLichTrinh.Show();
        }
    }
}
