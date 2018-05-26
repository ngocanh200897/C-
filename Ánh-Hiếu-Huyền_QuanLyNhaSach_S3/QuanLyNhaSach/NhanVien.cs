using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS_QLNS;
using DTO_QLNS;

namespace QuanLyNhaSach
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien nv = new BUS_NhanVien();
        ET_NhanVien lnv = new ET_NhanVien();
        private void NhanVien_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            dgvNhanVien.DataSource = nv.LayDSNV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (rbtNam.Checked == true)
            {
                lnv = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text, txtDiaChi.Text, rbtNam.Text, txtSDT.Text, int.Parse(txtTienLuong.Text));
            }
            else if (rbtNu.Checked == true)
            {
                lnv = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text, txtDiaChi.Text, rbtNu.Text, txtSDT.Text, int.Parse(txtTienLuong.Text));
            }
            if (nv.ThemNV(lnv) == true)
            {
                MessageBox.Show("Them thanh cong ");
                txtMaNV.Text = "";
                txtTenNV.Text = "";
                rbtNam.Text = "";
                rbtNu.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtTienLuong.Text = "";

            }
            else
            {
                MessageBox.Show("Them khong thanh cong ");
            }
            load();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn Có Muốn Thoát Không", "Thông Báo", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (nv.XoaNv(txtMaNV.Text) == true)
            {
                MessageBox.Show("Xoa thanh cong ");

            }
            else
            {
                MessageBox.Show("xoa khong thanh cong ");
            }
            load();
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            int dong = dgvNhanVien.CurrentCell.RowIndex;
            txtMaNV.Text = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[dong].Cells[1].Value.ToString();
            
            txtDiaChi.Text = dgvNhanVien.Rows[dong].Cells[2].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[dong].Cells[4].Value.ToString();
            txtTienLuong.Text = dgvNhanVien.Rows[dong].Cells[5].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (rbtNam.Checked == true)
            {
                lnv = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text, txtDiaChi.Text, rbtNam.Text, txtSDT.Text, int.Parse(txtTienLuong.Text));
            }
            else if (rbtNu.Checked == true)
            {
                lnv = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text, txtDiaChi.Text, rbtNu.Text, txtSDT.Text, int.Parse(txtTienLuong.Text));
            }
            if (nv.SuaNv(lnv) == true)
            {
                MessageBox.Show("Them thanh cong ");
                txtMaNV.Text = "";
                txtTenNV.Text = "";
                rbtNam.Text = "";
                rbtNu.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtTienLuong.Text = "";

            }
            else
            {
                MessageBox.Show("Them khong thanh cong ");
            }
            load();
        }
    }
}
