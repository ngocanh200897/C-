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
    public class BUS_TacGia
    {
        DAL_TacGia TG = new DAL_TacGia();
        public DataTable LayDSTG()
        {
            return TG.layDSTG();
        }
        public bool ThemTG(ET_TacGia tg)
        {
            return TG.themTG(tg);
        }
        public bool SuaTG(ET_TacGia tg)
        {
            return TG.capNhapTacGia(tg);
        }
        public bool XoaTG(string tg)
        {
            return TG.xoaTG(tg);
        }
        public DataTable TimTGTheoMa(string tg)
        {
            return TG.timKiemTheoMa(tg);
        }
        public DataTable TimTGTheoTen(string tg)
        {
            return TG.timTheoTenTG(tg);
        }

    }
}
