using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QLNS;

namespace DAL_QLNS
{
    public class DAL_SP:ConnectDB //ke thua connectDB ket noi csdl
    {
        //lop lay csdl lên
        //lay danh sach sp
        //lay danh sach sach
        public DataTable getListSach()
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_layDSSPS", _cn);
                cmd.CommandText = "sp_layDSSPS";
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
        //them loai san pham
        public bool themKH(ET_KH sp)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_themKH", _cn);
                cmd.CommandText = "sp_themKH";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaKH", sp.Makh);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenKH", sp.Tenkh);
                cmd.Parameters.Add(p_ten);
                SqlParameter p_diachi = new SqlParameter("@DiaChi", sp.Diachi);
                cmd.Parameters.Add(p_diachi);
                SqlParameter p_sdt = new SqlParameter("@SDT", sp.Sdt);
                cmd.Parameters.Add(p_sdt);
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
        //chap nhat loai san pham
        public bool capNhapKH(ET_KH sp)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_capnhapKH", _cn);
                cmd.CommandText = "sp_capnhapKH";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaKH", sp.Makh);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenKH", sp.Tenkh);
                cmd.Parameters.Add(p_ten);
                SqlParameter p_diachi = new SqlParameter("@DiaChi", sp.Diachi);
                cmd.Parameters.Add(p_diachi);
                SqlParameter p_sdt = new SqlParameter("@SDT", sp.Sdt);
                cmd.Parameters.Add(p_sdt);
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
        ////xoa loai san pham
        public bool deleteKH(string Id)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_xoaKH", _cn);
                cmd.CommandText = "sp_xoaKH";
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
