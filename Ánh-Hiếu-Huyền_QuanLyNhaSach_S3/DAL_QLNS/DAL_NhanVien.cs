using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO_QLNS;

namespace DAL_QLNS
{
    public class DAL_NhanVien : ConnectDB
    {
        //lay danh sach loai san phams
        public DataTable getListNV()
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_layDSNV", _cn);
                cmd.CommandText = "sp_layDSNV";
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
        public bool themNV(ET_NhanVien nv)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_themNV", _cn);
                cmd.CommandText = "sp_themNV";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaNV", nv.Manv);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenNV", nv.Tennv);
                cmd.Parameters.Add(p_ten);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_diachi = new SqlParameter("@DiaChi", nv.Diachi);
                cmd.Parameters.Add(p_diachi);
                SqlParameter p_gioitinh = new SqlParameter("@GioiTinh", nv.Gioitinh);
                cmd.Parameters.Add(p_gioitinh);
                SqlParameter p_sdt = new SqlParameter("@SDT", nv.Sdt);
                cmd.Parameters.Add(p_sdt);
                SqlParameter p_tienluong = new SqlParameter("@TienLuong", nv.Tienluong);
                cmd.Parameters.Add(p_tienluong);
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
        //cap nhat nhan vien

        public bool capNhapNV(ET_NhanVien nv)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_capnhapNV", _cn);
                cmd.CommandText = "sp_capnhapNV";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaNV", nv.Manv);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenNV", nv.Tennv);
                cmd.Parameters.Add(p_ten);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_diachi = new SqlParameter("@DiaChi", nv.Diachi);
                cmd.Parameters.Add(p_diachi);
                SqlParameter p_gioitinh = new SqlParameter("@GioiTinh", nv.Gioitinh);
                cmd.Parameters.Add(p_gioitinh);
                SqlParameter p_sdt = new SqlParameter("@SDT", nv.Sdt);
                cmd.Parameters.Add(p_sdt);
                SqlParameter p_tienluong = new SqlParameter("@TienLuong", nv.Tienluong);
                cmd.Parameters.Add(p_tienluong);
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
        ////xoa nhan vien
        public bool deleteNV(string Id)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_xoaNV", _cn);
                cmd.CommandText = "sp_xoaNV";
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
