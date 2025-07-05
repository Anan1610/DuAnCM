using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAL_QLVT
{
    public class DALChat
    {
        public static DataTable GetVatTuConHang()
        {
            string connectionString = @"Data Source=THE1712\SQLEXPRESS;Initial Catalog=Xuong_QuanLyVatTu;Integrated Security=True;Trust Server Certificate=True";
            string query = "SELECT * FROM VatTu WHERE TrangThaiID = 'TT001'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
