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
    public class BUS_NSX
    {
        DAL_NSX kh = new DAL_NSX();
        public DataTable LayDSNSX()
        {
            return kh.getListNSX();
        }
        public bool ThemNSX(ET_NSX b)
        {
            return kh.themNSX(b);
        }
        public bool SuaNSX(ET_NSX b)
        {
            return kh.capNhapNSX(b);
        }
        public bool XoaNSX(string b)
        {
            return kh.deletNSX(b);
        }
        public DataTable layma(string b)
        {
            return kh.getListMa(b);
        }
        public DataTable timten(string b)
        {
            return kh.timTheoTen(b);
        }
    }
}
