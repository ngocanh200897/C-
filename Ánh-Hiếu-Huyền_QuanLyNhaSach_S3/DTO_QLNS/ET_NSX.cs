using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DTO_QLNS
{
    public class ET_NSX
    {
        private string _ma;

        public string Ma
        {
            get { return _ma; }
            set { _ma = value; }
        }
        private string _ten;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
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
        public ET_NSX(string ma,string ten,string diachi,string sdt)
        {
            this._ma = ma;
            this._ten = ten;
            this._diachi = diachi;
            this._sdt = sdt;
        }
    }
}
