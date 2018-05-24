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
    public class BUS_LoaiSP
    {
        DAL_LoaiSP loaiSP = new DAL_LoaiSP();
        public DataTable LayDS()
        {
            return loaiSP.getListLoaiSP();
        }
        public bool ThemLSP(ET_LoaiSP b)
        {
            return loaiSP.themLoaiSP(b);
        }
        public bool SuaLSP(ET_LoaiSP b)
        {
            return loaiSP.capNhapLoaiSP(b);
        }
        public bool XoaLSP(string b)
        {
            return loaiSP.deleteLSP(b);
        }
    }
}
