using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QLNS
{
    public class ET_KH
    {
        private string _makh;

        public string Makh
        {
            get { return _makh; }
            set { _makh = value; }
        }
        private string _tenkh;

        public string Tenkh
        {
            get { return _tenkh; }
            set { _tenkh = value; }
        }
        private string _diachi;

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        private string _sdt;

        public string Sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        public ET_KH(string makh, string tenkh, string diachi, string sdt)
        {
            this._makh = makh;
            this._tenkh = tenkh;
            this._diachi = diachi;
            this._sdt = sdt;
        }
    }
}
