using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QLNS
{
    public class ET_LoaiSP
    {
        private string _maTL;

        public string MaTL
        {
            get { return _maTL; }
            set { _maTL = value; }
        }
        private string _tenTL;

        public string TenTL
        {
            get { return _tenTL; }
            set { _tenTL = value; }
        }
        public ET_LoaiSP(string maTL, string tenTL)
        {
            this._maTL = maTL;
            this._tenTL = tenTL;
        }
    }
}
