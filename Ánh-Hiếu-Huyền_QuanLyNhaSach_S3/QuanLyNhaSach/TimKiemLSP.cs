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

namespace QuanLyNhaSach
{
    public partial class TimKiemLSP : Form
    {
        public TimKiemLSP()
        {
            InitializeComponent();
        }

        BUS_LoaiSP l = new BUS_LoaiSP();
        private void tntim_Click(object sender, EventArgs e)
        {
            if (rbma.Checked == true)
            {
                if (txtnhap.Text != "")
                {
                    MessageBox.Show("Ban tim thanh cong", "thong bao");
                    dgvdstimkiem.DataSource = l.timtheoMa(txtnhap.Text);
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
                    dgvdstimkiem.DataSource = l.timtheoten(txtnhap.Text);
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

        private void TimKiemLSP_Load(object sender, EventArgs e)
        {
            dgvdstimkiem.DataSource = l.LayDS();
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
