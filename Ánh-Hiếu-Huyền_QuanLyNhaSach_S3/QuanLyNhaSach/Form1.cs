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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BUS_SP s = new BUS_SP();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = s.LayDSS();
        }
    }
}
