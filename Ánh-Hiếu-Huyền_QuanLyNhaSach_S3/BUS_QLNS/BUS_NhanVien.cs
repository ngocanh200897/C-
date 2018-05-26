using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL_QLNS;
using DTO_QLNS;

namespace BUS_QLNS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien nv = new DAL_NhanVien();
        public DataTable LayDSNV()
        {
            return nv.getListNV();
        }
        public bool ThemNV(ET_NhanVien b)
        {
            return nv.themNV(b);
        }
        public bool SuaNv(ET_NhanVien b)
        {
            return nv.capNhapNV(b);
        }
        public bool XoaNv(string b)
        {
            return nv.deleteNV(b);
        }
    }
}
