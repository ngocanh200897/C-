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
    public partial class TimNSX : Form
    {
        public TimNSX()
        {
            InitializeComponent();
        }
        BUS_NSX sx = new BUS_NSX();
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (rbma.Checked == true)
            {
                if (txtnhap.Text != "")
                {
                    MessageBox.Show("Ban tim thanh cong", "thong bao");
                    dgvNSX.DataSource = sx.layma(txtnhap.Text);
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
                    dgvNSX.DataSource = sx.timten(txtnhap.Text);
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
        public void lay()
        {
            dgvNSX.DataSource = sx.LayDSNSX();
        }

        private void TimNSX_Load(object sender, EventArgs e)
        {
            lay();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn Có Muốn Thoát Không", "Thông Báo", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
