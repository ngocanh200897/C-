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
    public partial class FrmKho : Form
    {
        public FrmKho()
        {
            InitializeComponent();
        }

        BUS_Kho kho = new BUS_Kho();

        private void FrmKho_Load(object sender, EventArgs e)
        {
            load();
        }

        // 
        public void load()
        {
            dgvKho.DataSource = kho.LayDSKho();
			yutrrttewrwewe
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_Kho k = new ET_Kho(txtMaKho.Text, txtTenKho.Text, dtpNgayNhap.Text, int.Parse(txtSLNhap.Text), dtpNgayXuat.Text, int.Parse(txtSoLuongXuat.Text), int.Parse(txtSoTon.Text), txtSoPhieu.Text);
            if (kho.ThemKho(k) == true)
            {
                MessageBox.Show("Them thanh cong ");
                txtMaKho.Text = "";
                txtTenKho.Text = "";
                dtpNgayNhap.Text = "";
                dtpNgayXuat.Text = "";
                txtSLNhap.Text = "";
                txtSoLuongXuat.Text = "";
                txtSoPhieu.Text = "";
                txtSoTon.Text = "";
                txtMaKho.Focus();
            }
            else
            {
                MessageBox.Show("Them khong thanh cong ");
            }
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_Kho k = new ET_Kho(txtMaKho.Text, txtTenKho.Text, dtpNgayNhap.Text, int.Parse(txtSLNhap.Text), dtpNgayXuat.Text, int.Parse(txtSoLuongXuat.Text), int.Parse(txtSoTon.Text), txtSoPhieu.Text);
            if (kho.SuaKho(k) == true)
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
            if (kho.XoaKho(txtMaKho.Text) == true)
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

        private void dgvKho_Click(object sender, EventArgs e)
        {
            int dong = dgvKho.CurrentCell.RowIndex;
            txtMaKho.Text = dgvKho.Rows[dong].Cells[0].Value.ToString();
            txtTenKho.Text = dgvKho.Rows[dong].Cells[1].Value.ToString();
            dtpNgayNhap.Text = dgvKho.Rows[dong].Cells[2].Value.ToString();
            txtSLNhap.Text = dgvKho.Rows[dong].Cells[3].Value.ToString();
            dtpNgayXuat.Text = dgvKho.Rows[dong].Cells[4].Value.ToString();
            txtSoLuongXuat.Text = dgvKho.Rows[dong].Cells[5].Value.ToString();
            txtSoTon.Text = dgvKho.Rows[dong].Cells[6].Value.ToString();
            txtSoPhieu.Text = dgvKho.Rows[dong].Cells[7].Value.ToString();
        }




    }
}
