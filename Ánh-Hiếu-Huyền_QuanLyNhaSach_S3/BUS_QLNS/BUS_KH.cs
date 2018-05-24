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
    public class BUS_KH
    {
        DAL_KH kh = new DAL_KH();
        public DataTable LayDSKH()
        {
            return kh.getListKH();
        }
        public bool ThemKH(ET_KH b)
        {
            return kh.themKH(b);
        }
        public bool SuaKh(ET_KH b)
        {
            return kh.capNhapKH(b);
        }
        public bool XoaKh(string b)
        {
            return kh.deleteKH(b);
        }
    }
}
