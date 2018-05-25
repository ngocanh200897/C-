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
    public class BUS_SP
    {
        DAL_SP s = new DAL_SP();
        public DataTable LayDSS()
        {
            return s.getListSach();
        }
        public DataTable LayDSHT()
        {
            return s.getListDDHT();
        }
        public DataTable LayDTT()
        {
            return s.getListDTT();
        }

        //public bool ThemLSP(ET_LoaiSP b)
        //{
        //    return loaiSP.themLoaiSP(b);
        //}
        //public bool SuaLSP(ET_LoaiSP b)
        //{
        //    return loaiSP.capNhapLoaiSP(b);
        //}
        //public bool XoaLSP(string b)
        //{
        //    return loaiSP.deleteLSP(b);
        //}
    }
}
