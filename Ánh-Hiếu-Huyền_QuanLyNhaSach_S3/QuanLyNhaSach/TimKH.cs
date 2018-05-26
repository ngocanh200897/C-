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
    public partial class TimKH : Form
    {
        public TimKH()
        {
            InitializeComponent();
        }
        BUS_KH kh = new BUS_KH();
        private void TimKH_Load(object sender, EventArgs e)
        {
            lay();
        }
        public void lay()
        {
            dgvDsTim.DataSource = kh.LayDSKH();
        }
        private void btntim_Click(object sender, EventArgs e)
        {

            if (rbma.Checked == true)
            {
                if (txtnhap.Text != "")
                {
                    MessageBox.Show("Ban tim thanh cong", "thong bao");
                    dgvDsTim.DataSource = kh.timdstheoma(txtnhap.Text);
                }
                else
                {
                    MessageBox.Show("Ban Chua nhap du lieu", "thong bao");
                }
            }
            else if (rbten.Checked == true)
            {
                if (txtnhap.Text != "")
                {
                    MessageBox.Show("Ban tim thanh cong", "thong bao");
                    dgvDsTim.DataSource = kh.timdstheoten(txtnhap.Text);
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn Có Muốn Thoát Không", "Thông Báo", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
