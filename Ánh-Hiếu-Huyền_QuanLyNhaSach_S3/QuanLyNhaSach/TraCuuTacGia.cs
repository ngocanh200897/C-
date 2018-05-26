using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO_QLNS;
using BUS_QLNS;

namespace QuanLyNhaSach
{
    public partial class FrmTraCuuTacGia : Form
    {
        public FrmTraCuuTacGia()
        {
            InitializeComponent();
        }

        BUS_TacGia tg = new BUS_TacGia();
        private void FrmTraCuuTacGia_Load(object sender, EventArgs e)
        {
            lay();
        }
        public void lay()
        {
            dgvTG.DataSource = tg.LayDSTG();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radMa.Checked == true)
            {
                if (txtTimKiem.Text != "")
                {
                    MessageBox.Show("Ban tim thanh cong", "thong bao");
                    dgvTG.DataSource = tg.TimTGTheoMa(txtTimKiem.Text);
                }
                else
                {
                    MessageBox.Show("Ban Chua nhap du lieu", "thong bao");
                }
            }
            else if (radTen.Checked == true)
            {
                if (txtTimKiem.Text != "")
                {
                    MessageBox.Show("Ban tim thanh cong", "thong bao");
                    dgvTG.DataSource = tg.TimTGTheoTen(txtTimKiem.Text);
                }
                else
                {
                    MessageBox.Show("Ban Chua nhap du lieu", "thong bao");
                }
            }
            else
            {
                MessageBox.Show("Ban chua chon chuc nang", "thong bao");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


    }
}
