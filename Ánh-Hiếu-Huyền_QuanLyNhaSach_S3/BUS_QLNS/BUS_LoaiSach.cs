using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAL_QLNS;
using DTO_QLNS;

namespace BUS_QLNS
{
    public class BUS_LoaiSach
    {
        DAL_LoaiSach ls = new DAL_LoaiSach();
        public DataTable LayDSLoaiSach()
        {
            return ls.layDSLoaiSach();
        }
        public bool ThemLoaiSach(ET_LoaiSach s)
        {
            return ls.themLoaiSach(s);
        }
        public bool SuaLoaiSach(ET_LoaiSach s)
        {
            return ls.capNhapLoaiSach(s);
        }
        public bool XoaLoaiSach(string s)
        {
            return ls.xoaLoaiSach(s);
        }
    }
}
