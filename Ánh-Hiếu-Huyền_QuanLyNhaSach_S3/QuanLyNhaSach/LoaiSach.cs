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
    public partial class FrmLoaiSach : Form
    {
        public FrmLoaiSach()
        {
            InitializeComponent();
        }
        BUS_LoaiSach loaiSach = new BUS_LoaiSach();
        private void FrmLoaiSach_Load(object sender, EventArgs e)
        {
            load();
        }

        // 
        public void load()
        {
            dgvLoaiSach.DataSource = loaiSach.LayDSLoaiSach();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ET_LoaiSach lSach = new ET_LoaiSach(txtMaLoai.Text, txtTenLoai.Text);
            if (loaiSach.ThemLoaiSach(lSach) == true)
            {
                MessageBox.Show("Them thanh cong ");
                txtMaLoai.Text = "";
                txtTenLoai.Text = "";
                txtMaLoai.Focus();
            }
            else
            {
                MessageBox.Show("Them khong thanh cong ");
            }
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_LoaiSach lSach = new ET_LoaiSach(txtMaLoai.Text, txtTenLoai.Text);
            if (loaiSach.SuaLoaiSach(lSach) == true)
            {
                MessageBox.Show("Sửa thành công ");

            }
            else
            {
                MessageBox.Show("Sua khong thanh cong ");
            }
            load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (loaiSach.XoaLoaiSach(txtMaLoai.Text) == true)
            {
                MessageBox.Show("Xoa thanh cong ");

            }
            else
            {
                MessageBox.Show("xoa khong thanh cong ");
            }
            load();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLoaiSach_Click(object sender, EventArgs e)
        {
            int dong = dgvLoaiSach.CurrentCell.RowIndex;
            txtMaLoai.Text = dgvLoaiSach.Rows[dong].Cells[0].Value.ToString();
            txtTenLoai.Text = dgvLoaiSach.Rows[dong].Cells[1].Value.ToString();
        }


    }
}
