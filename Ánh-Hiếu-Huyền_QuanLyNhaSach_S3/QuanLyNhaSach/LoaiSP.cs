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
    public partial class LoaiSP : Form
    {
        public LoaiSP()
        {
            InitializeComponent();
        }
        BUS_LoaiSP bLSP = new BUS_LoaiSP();
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtTen.Text != "")
            {
                ET_LoaiSP lsp = new ET_LoaiSP(txtMa.Text, txtTen.Text);
                if (bLSP.ThemLSP(lsp) == true)
                {
                    MessageBox.Show("Them thanh cong ");
                    txtMa.Text = "";
                    txtTen.Text = "";
                }
                else
                {
                    MessageBox.Show("Them khong thanh cong ");
                }
                load();
            }
            else
            {
                MessageBox.Show("Kiểm tra thông tin nhập");
            }
        }

        private void LoaiSP_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            dgvLSP.DataSource = bLSP.LayDS();
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
            if (bLSP.XoaLSP(txtMa.Text) == true)
            {
                MessageBox.Show("Xoa thanh cong ");

                txtTen.Text = "";
                txtMa.Text = "";

            }
            else
            {
                MessageBox.Show("khong thanh cong ");
            }
            load();
        }

        private void dgvLSP_Click(object sender, EventArgs e)
        {
            int dong = dgvLSP.CurrentCell.RowIndex;
            txtMa.Text = dgvLSP.Rows[dong].Cells[0].Value.ToString();
            txtTen.Text = dgvLSP.Rows[dong].Cells[1].Value.ToString();
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtTen.Text != "")
            {
                ET_LoaiSP lsp = new ET_LoaiSP(txtMa.Text, txtTen.Text);
                if (bLSP.SuaLSP(lsp) == true)
                {
                    MessageBox.Show("Sua thanh cong ");

                }
                else
                {
                    MessageBox.Show("Sua khong thanh cong ");
                }
                load();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin nhập");
            }
        }

       
    }
}
