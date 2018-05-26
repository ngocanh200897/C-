using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace DAL_QLNS
{
    public class ConnectDB
    {
        protected SqlConnection _cn = new SqlConnection(@"Data Source=N8FQTC197ECO4RS\SQL;Initial Catalog=Proj_QuanLyNhaSach;Integrated Security=True");
    }
}
