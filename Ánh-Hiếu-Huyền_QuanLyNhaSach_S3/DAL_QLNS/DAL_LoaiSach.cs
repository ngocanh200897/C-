using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO_QLNS;

namespace DAL_QLNS
{
    public class DAL_LoaiSach : ConnectDB
    {
        //lay danh sach loai sách
        public DataTable layDSLoaiSach()
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_layDSLoaiSach", _cn);
                cmd.CommandText = "sp_layDSLoaiSach";
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
        public bool themLoaiSach(ET_LoaiSach ls)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_themLS", _cn);
                cmd.CommandText = "sp_themLS";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaLoaiSach", ls.MaLoaiSach);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenLoaiSach", ls.TenLoaiSach);
                cmd.Parameters.Add(p_ten);
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


        //cap nhat loai sách
        public bool capNhapLoaiSach(ET_LoaiSach ls)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_capnhapLS", _cn);
                cmd.CommandText = "sp_capnhapLS";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaLoaiSach", ls.MaLoaiSach);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenLoaiSach", ls.TenLoaiSach);
                cmd.Parameters.Add(p_ten);
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

        //xoa loai sach
        public bool xoaLoaiSach(string Id)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_xoaLS", _cn);
                cmd.CommandText = "sp_xoaLS";
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

        // tra cứu loại sách theo mã 
        public DataTable timKiemTheoMa(string Id)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_timKiemLoaiSachTheoMa", _cn);
                cmd.CommandText = "sp_timKiemLoaiSachTheoMa";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@maLoaiSach", Id);
                cmd.Parameters.Add(p_ma);
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

        // tra cứu loai sách theo tên
        public DataTable timTheoLoaiSach(string name)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_timKiemLoaiSachTheoTen", _cn);
                cmd.CommandText = "sp_timKiemLoaiSachTheoTen";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ten = new SqlParameter("@tenLoaiSach", name);
                cmd.Parameters.Add(p_ten);
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
    }
}
