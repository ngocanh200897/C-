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
    public partial class KH : Form
    {
        public KH()
        {
            InitializeComponent();
        }
        BUS_KH bLSP = new BUS_KH();
        private void KH_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ET_KH lsp = new ET_KH(txtma.Text, txtten.Text, txtdiachi.Text, mtbSDT.Text);
            if (bLSP.ThemKH(lsp) == true)
            {
                MessageBox.Show("Them thanh cong ");
                txtma.Text = "";
                txtdiachi.Text = "";
                txtten.Text = "";
                mtbSDT.Text = "";
            }
            else
            {
                MessageBox.Show("Them khong thanh cong ");
            }
            load();
        }
        public void load()
        {
            dgvkh.DataSource = bLSP.LayDSKH();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn Có Muốn Thoát Không", "Thông Báo", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (bLSP.XoaKh(txtma.Text) == true)
            {
                MessageBox.Show("Xoa thanh cong ");

            }
            else
            {
                MessageBox.Show("xoa khong thanh cong ");
            }
            load();
        }

        private void dgvkh_Click(object sender, EventArgs e)
        {
            int dong = dgvkh.CurrentCell.RowIndex;
            txtma.Text = dgvkh.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = dgvkh.Rows[dong].Cells[1].Value.ToString();
            txtdiachi.Text = dgvkh.Rows[dong].Cells[2].Value.ToString();
            mtbSDT.Text = dgvkh.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            ET_KH lsp = new ET_KH(txtma.Text, txtten.Text, txtdiachi.Text, mtbSDT.Text);
            if (bLSP.SuaKh(lsp) == true)
            {
                MessageBox.Show("Sua thanh cong ");

            }
            else
            {
                MessageBox.Show("Sua khong thanh cong ");
            }
            load();
        }
    }
}
