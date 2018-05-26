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
    public partial class NSX : Form
    {
        public NSX()
        {
            InitializeComponent();
        }
        BUS_NSX bLSP = new BUS_NSX();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtDiaChi.Text != "" && txtMa.Text != "" && mtbSDT.Text != "")
            {
                ET_NSX lsp = new ET_NSX(txtMa.Text, txtTen.Text, txtDiaChi.Text, mtbSDT.Text);
                if (bLSP.ThemNSX(lsp) == true)
                {
                    MessageBox.Show("Them thanh cong ");
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtDiaChi.Text = "";
                    mtbSDT.Text = "";
                }
                else
                {
                    MessageBox.Show("Them khong thanh cong ");
                }
            }
            else
            {
                MessageBox.Show("Xem lại thông tin nhập");
            }
            load();
        }

        private void NSX_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            dgvnsx.DataSource = bLSP.LayDSNSX();
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
            DialogResult dr = MessageBox.Show("Bạn Có Muốn Thoát Không", "Thông Báo", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                if (bLSP.XoaNSX(txtMa.Text) == true)
                {
                    MessageBox.Show("Xoa thanh cong ");
                }
                else
                {
                    MessageBox.Show("khong thanh cong ");
                }
                load();
            }
          
        }

        private void dgvnsx_Click(object sender, EventArgs e)
        {
            int dong = dgvnsx.CurrentCell.RowIndex;
            txtMa.Text = dgvnsx.Rows[dong].Cells[0].Value.ToString();
            txtTen.Text = dgvnsx.Rows[dong].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvnsx.Rows[dong].Cells[2].Value.ToString();
            mtbSDT.Text = dgvnsx.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtDiaChi.Text != "" && txtMa.Text != "" && mtbSDT.Text != "")
            {
                ET_NSX lsp = new ET_NSX(txtMa.Text, txtTen.Text, txtDiaChi.Text, mtbSDT.Text);
                if (bLSP.SuaNSX(lsp) == true)
                {
                    MessageBox.Show("Cập Nhập Thành Công");
                }
                else
                {
                    MessageBox.Show("khong thanh cong ");
                }
            }
            else
            {
                MessageBox.Show("Xem lại thông tin nhập");
            }
            load();
        }

       

     
    }
}
