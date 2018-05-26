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
    public partial class FrmTacGia : Form
    {
        public FrmTacGia()
        {
            InitializeComponent();
        }

        BUS_TacGia tg = new BUS_TacGia();
        private void FrmTacGia_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            dgvTG.DataSource = tg.LayDSTG();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_TacGia TG = new ET_TacGia(txtMaTG.Text, txtTenTG.Text, int.Parse(txtNamSinh.Text));
            if (tg.ThemTG(TG) == true)
            {
                MessageBox.Show("Them thanh cong ");
                txtMaTG.Text = "";
                txtTenTG.Text = "";
                txtNamSinh.Text = "";
                txtMaTG.Focus();
            }
            else
            {
                MessageBox.Show("Them khong thanh cong ");
            }
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_TacGia TG = new ET_TacGia(txtMaTG.Text, txtTenTG.Text, int.Parse(txtNamSinh.Text));
            if (tg.SuaTG(TG) == true)
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
            if (tg.XoaTG(txtMaTG.Text) == true)
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

        private void dgvTG_Click(object sender, EventArgs e)
        {
            int dong = dgvTG.CurrentCell.RowIndex;
            txtMaTG.Text = dgvTG.Rows[dong].Cells[0].Value.ToString();
            txtTenTG.Text = dgvTG.Rows[dong].Cells[1].Value.ToString();
            txtNamSinh.Text = dgvTG.Rows[dong].Cells[2].Value.ToString();
        }
    }
}
