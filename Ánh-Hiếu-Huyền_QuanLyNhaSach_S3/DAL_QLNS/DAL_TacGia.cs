using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO_QLNS;
namespace DAL_QLNS
{
    public class DAL_TacGia : ConnectDB
    {
        //lay danh sach tác giả
        public DataTable layDSTG()
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_layDSTG", _cn);
                cmd.CommandText = "sp_layDSTG";
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


        //them tác giả
        public bool themTG(ET_TacGia tg)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_themTacGia", _cn);
                cmd.CommandText = "sp_themTacGia";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaTG", tg.MaTG);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenTG", tg.TenTG);
                cmd.Parameters.Add(p_ten);
                SqlParameter p_namSinh = new SqlParameter("@NamSinh", tg.NamSinh);
                cmd.Parameters.Add(p_namSinh);
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

        //cap nhat tác giả
        public bool capNhapTacGia(ET_TacGia tg)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_capnhapTacGia", _cn);
                cmd.CommandText = "sp_capnhapTacGia";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaTG", tg.MaTG);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenTG", tg.TenTG);
                cmd.Parameters.Add(p_ten);
                SqlParameter p_namSinh = new SqlParameter("@NamSinh", tg.NamSinh);
                cmd.Parameters.Add(p_namSinh);
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

        //xóa tác giả
        public bool xoaTG(string Id)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_xoaTacGia", _cn);
                cmd.CommandText = "sp_xoaTacGia";
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
