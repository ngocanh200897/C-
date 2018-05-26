using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QLNS
{
    public class ET_Kho
    {
        private string _maKho;

        public string MaKho
        {
            get { return _maKho; }
            set { _maKho = value; }
        }

        private string _tenKho;

        public string TenKho
        {
            get { return _tenKho; }
            set { _tenKho = value; }
        }


        private string _ngayNhapKho;

        public string NgayNhapKho
        {
            get { return _ngayNhapKho; }
            set { _ngayNhapKho = value; }
        }



        private int _soLuongNhap;

        public int SoLuongNhap
        {
            get { return _soLuongNhap; }
            set { _soLuongNhap = value; }
        }



        private string _ngayXuat;

        public string NgayXuat
        {
            get { return _ngayXuat; }
            set { _ngayXuat = value; }
        }

        private int _soLuongXuat;

        public int SoLuongXuat
        {
            get { return _soLuongXuat; }
            set { _soLuongXuat = value; }
        }

        private int _soLuongTon;

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set { _soLuongTon = value; }
        }

        private string _soPhieu;

        public string SoPhieu
        {
            get { return _soPhieu; }
            set { _soPhieu = value; }
        }

        public ET_Kho(string maKho, string tenKho, string ngayNhapKho, int soLuongNhap, string ngayXuat, int soLuongXuat, int soLuongTon, string soPhieu)
        {
            this._maKho = maKho;
            this._tenKho = tenKho;
            this._ngayNhapKho = ngayNhapKho;
            this._soLuongNhap = soLuongNhap;
            this._ngayXuat = ngayXuat;
            this._soLuongXuat = soLuongXuat;
            this._soLuongTon = soLuongTon;
            this._soPhieu = soPhieu;
        }
    
    }
}
