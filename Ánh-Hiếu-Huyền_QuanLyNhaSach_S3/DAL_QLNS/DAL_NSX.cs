using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO_QLNS;

namespace DAL_QLNS
{
    public class DAL_NSX:ConnectDB
    {
        public DataTable getListNSX()
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_layDSNSX", _cn);
                cmd.CommandText = "sp_layDSNSX";
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
        public bool themNSX(ET_NSX sp)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_themNSX", _cn);
                cmd.CommandText = "sp_themNSX";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaNSX", sp.Ma);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenNSX", sp.Ten);
                cmd.Parameters.Add(p_ten);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public bool capNhapNSX(ET_NSX sp)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_capnhapNSX", _cn);
                cmd.CommandText = "sp_capnhapNSX";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaNSX", sp.Ma);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenNSX", sp.Ten);
                cmd.Parameters.Add(p_ten);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public bool deletNSX(string Id)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_xoaNSX", _cn);
                cmd.CommandText = "sp_xoaNSX";
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
