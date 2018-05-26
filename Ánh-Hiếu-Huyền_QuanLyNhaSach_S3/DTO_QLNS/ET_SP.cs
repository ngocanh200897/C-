using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QLNS
{
    //để pulic truoc class moi goi duoc
    public class ET_SP
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
        private int _sl;

        public int Sl
        {
            get { return _sl; }
            set { _sl = value; }
        }
        private int _gia;

        public int Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }
        private string _mansx;

        public string Mansx
        {
            get { return _mansx; }
            set { _mansx = value; }
        }
        private string _malsp;

        public string Malsp
        {
            get { return _malsp; }
            set { _malsp = value; }
        }
        private string _mals;

        public string Mals
        {
            get { return _mals; }
            set { _mals = value; }
        }
        private string _matg;

        public string Matg
        {
            get { return _matg; }
            set { _matg = value; }
        }
        private string _makho;

        public string Makho
        {
            get { return _makho; }
            set { _makho = value; }
        }
        //contruction
        public ET_SP(string ma, string ten, int sl, int gia, string mansx, string mlsp, string mals, string matg, string makho)
        {
            this._ma = ma;
            this._ten = ten;
            this._sl = sl;
            this._gia = gia;
            this._mansx = mansx;
            this._malsp = Malsp;
            this._mals = mals;
            this._matg = matg;
            this._makho = makho;
        }

    }
}
