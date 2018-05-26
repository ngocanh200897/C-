using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO_QLNS;

namespace DAL_QLNS
{
    public class DAL_Kho : ConnectDB
    {
        //lay danh sach kho
        public DataTable layDSKho()
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_layDSKho", _cn);
                cmd.CommandText = "sp_layDSKho";
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                return dataTable;
            }

            finally
            {
                _cn.Close();
            }
        }

        //them kho
        public bool themKho(ET_Kho k)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_themKho", _cn);
                cmd.CommandText = "sp_themKho";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaKho", k.MaKho);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenKho", k.TenKho);
                cmd.Parameters.Add(p_ten);
                SqlParameter p_ngayNhap = new SqlParameter("@NgayNhapKho", k.NgayNhapKho);
                cmd.Parameters.Add(p_ngayNhap);
                SqlParameter p_slNhap = new SqlParameter("@SoLuongNhap", k.SoLuongNhap);
                cmd.Parameters.Add(p_slNhap);
                SqlParameter p_ngayXuat = new SqlParameter("@NgayXuat", k.NgayXuat);
                cmd.Parameters.Add(p_ngayXuat);
                SqlParameter p_slXuat = new SqlParameter("@SoLuongXuat", k.SoLuongXuat);
                cmd.Parameters.Add(p_slXuat);
                SqlParameter p_slTon = new SqlParameter("@SoLuongTon", k.SoLuongTon);
                cmd.Parameters.Add(p_slTon);
                SqlParameter p_soPhieu = new SqlParameter("@SoPhieu", k.SoPhieu);
                cmd.Parameters.Add(p_soPhieu);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                _cn.Close();
            }
        }

        //cap nhat kho
        public bool capNhapKho(ET_Kho k)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_capnhapKho", _cn);
                cmd.CommandText = "sp_capnhapKho";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaKho", k.MaKho);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenKho", k.TenKho);
                cmd.Parameters.Add(p_ten);
                SqlParameter p_ngayNhap = new SqlParameter("@NgayNhapKho", k.NgayNhapKho);
                cmd.Parameters.Add(p_ngayNhap);
                SqlParameter p_slNhap = new SqlParameter("@SoLuongNhap", k.SoLuongNhap);
                cmd.Parameters.Add(p_slNhap);
                SqlParameter p_ngayXuat = new SqlParameter("@NgayXuat", k.NgayXuat);
                cmd.Parameters.Add(p_ngayXuat);
                SqlParameter p_slXuat = new SqlParameter("@SoLuongXuat", k.SoLuongXuat);
                cmd.Parameters.Add(p_slXuat);
                SqlParameter p_slTon = new SqlParameter("@SoLuongTon", k.SoLuongTon);
                cmd.Parameters.Add(p_slTon);
                SqlParameter p_soPhieu = new SqlParameter("@SoPhieu", k.SoPhieu);
                cmd.Parameters.Add(p_soPhieu);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _cn.Close();
            }
        }


        //xoa kho
        public bool xoaKho(string Id)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_xoaKho", _cn);
                cmd.CommandText = "sp_xoaKho";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@ma", Id);
                cmd.Parameters.Add(p_ma);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _cn.Close();
            }
        }
    }
}
