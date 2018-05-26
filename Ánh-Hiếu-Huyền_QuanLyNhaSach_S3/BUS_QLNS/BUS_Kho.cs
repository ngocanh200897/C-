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
    public class BUS_Kho
    {
         DAL_Kho kho = new DAL_Kho();
        public DataTable LayDSKho()
        {
            return kho.layDSKho();
        }
        public bool ThemKho(ET_Kho k)
        {
            return kho.themKho(k);
        }
        public bool SuaKho(ET_Kho k)
        {
            return kho.capNhapKho(k);
        }
        public bool XoaKho(string k)
        {
            return kho.xoaKho(k);
        }
    }
}
