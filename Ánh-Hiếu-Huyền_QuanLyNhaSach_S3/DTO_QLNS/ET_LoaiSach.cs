using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QLNS
{
    public class ET_LoaiSach
    {
        private string _maLoaiSach;

        public string MaLoaiSach
        {
            get { return _maLoaiSach; }
            set { _maLoaiSach = value; }
        }

        private string _tenLoaiSach;

        public string TenLoaiSach
        {
            get { return _tenLoaiSach; }
            set { _tenLoaiSach = value; }
        }

        public ET_LoaiSach(string maLoaiSach, string tenLoaiSach)
        {
            this._maLoaiSach = maLoaiSach;
            this._tenLoaiSach = tenLoaiSach;
        }
    }
}
