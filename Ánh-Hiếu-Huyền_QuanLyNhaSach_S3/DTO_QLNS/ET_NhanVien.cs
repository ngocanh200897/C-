using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QLNS
{
    public class ET_NhanVien
    {
        private string _manv;

        public string Manv
        {
            get { return _manv; }
            set { _manv = value; }
        }
        private string _tennv;

        public string Tennv
        {
            get { return _tennv; }
            set { _tennv = value; }
        }
        private string _diachi;

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        private string _gioitinh;

        public string Gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        private string _sdt;

        public string Sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        private int _tienluong;

        public int Tienluong
        {
            get { return _tienluong; }
            set { _tienluong = value; }
        }
        public ET_NhanVien()
        {
        }
        public ET_NhanVien(string manv, string tennv, string diachi, string gioitinh, string sdt, int tienluong )
        {
            this._manv = manv;
            this._tennv = tennv;
            this._diachi = diachi;
            this._gioitinh = gioitinh;
            this._sdt = sdt;
            this._tienluong = tienluong;
        }
    }
}
