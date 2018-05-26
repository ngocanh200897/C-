using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QLNS
{
    public class ET_TacGia
    {
        private string _maTG;

        public string MaTG
        {
            get { return _maTG; }
            set { _maTG = value; }
        }

        private string _tenTG;

        public string TenTG
        {
            get { return _tenTG; }
            set { _tenTG = value; }
        }

        private int _namSinh;

        public int NamSinh
        {
            get { return _namSinh; }
            set { _namSinh = value; }
        }

        public ET_TacGia(string maTG, string tenTG, int namSinh)
        {
            this._maTG = maTG;
            this._tenTG = tenTG;
            this._namSinh = namSinh;
        }

    }
}
