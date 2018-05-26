using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using DTO_QLNS;

namespace DAL_QLNS
{
    public class DAL_LoaiSP:ConnectDB
    {
        //lay danh sach loai san phams
        public DataTable getListLoaiSP()
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_layDSLSP", _cn);
                cmd.CommandText = "sp_layDSLSP";
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
        public bool themLoaiSP(ET_LoaiSP sp)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_themLoaiSP", _cn);
                cmd.CommandText = "sp_themLoaiSP";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaLoaiSP", sp.MaTL);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenLoaiSP", sp.TenTL);
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
        //tim kiem theo ma
        public DataTable getListMa(string Id)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_timKiemLSPMa", _cn);
                cmd.CommandText = "sp_timKiemLSPMa";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@ma", Id);
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
        //tim kiem theo ten
        public DataTable timTheoTen(string name)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_timKiemLSP", _cn);
                cmd.CommandText = "sp_timKiemLSP";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@ten", name);
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
        //chap nhat loai san pham
        public bool capNhapLoaiSP(ET_LoaiSP sp)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_capnhapLSP", _cn);
                cmd.CommandText = "sp_capnhapLSP";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p_ma = new SqlParameter("@MaLoaiSP", sp.MaTL);
                cmd.Parameters.Add(p_ma);
                SqlParameter p_ten = new SqlParameter("@TenLoaiSP", sp.TenTL);
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
        ////xoa loai san pham
        public bool deleteLSP(string Id)
        {
            try
            {
                _cn.Open();
                SqlCommand cmd = new SqlCommand("sp_xoaLSP", _cn);
                cmd.CommandText = "sp_xoaLSP";
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
