    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess_By_HGK
{
    public class SQLdateaccess
    {

        public string ConnectionString { get; set; }
        public SqlConnection SQLConnection { get; set; }
        public SQLdateaccess()
        {
            ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\Quan_Ly_SV_From_By_HGK\\Quan_Ly_SV_From_By_HGK\\QuanLySVDB.mdf;Integrated Security=True";
            SQLConnection = new SqlConnection(ConnectionString);
        }

        public SQLdateaccess(string _sqlConnectionString)
        {
            ConnectionString = _sqlConnectionString;
            SQLConnection = new SqlConnection(ConnectionString);
        }

        public void OpenConnection()
        {
            SQLConnection.Open();
        }

        public void CloseConnection()
        {
            if (SQLConnection.State == ConnectionState.Open)
                SQLConnection.Close();
        }

        public int ExecuteNonQueryCommand(string sql)
        {
            SqlCommand scmd = new SqlCommand(sql, SQLConnection);
            int ketqua = -1;
            try
            {
                OpenConnection();
                ketqua = scmd.ExecuteNonQuery();
            }
            catch
            {
                // Xu ly loi?
            }
            finally
            {
                CloseConnection();
            }
            return ketqua;
        }

        public SqlDataReader ExecuteQuery(string sql)
        {
            SqlCommand scmd = new SqlCommand(sql, SQLConnection);
            SqlDataReader sdr = null;
            try
            {
                OpenConnection();
                sdr = scmd.ExecuteReader();
                if (sdr == null)
                    CloseConnection();
            }
            catch { }
            return sdr;
        }

        public SqlDataAdapter ExecuteQueryAdapter(string sql)
        {
            SqlCommand scmd = new SqlCommand(sql, SQLConnection);
            SqlDataAdapter sda = null;
            try
            {
                OpenConnection();
                sda = new SqlDataAdapter(scmd);
                if (sda == null)
                    CloseConnection();
            }
            catch { }
            return sda;
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            SqlDataAdapter sda = ExecuteQueryAdapter(sql);
            if (sda == null) return null;
            DataTable tbl = new DataTable();
            sda.Fill(tbl);
            return tbl;
        }

        public DataSet ExecuteQueryDataSet(string sql)
        {
            SqlDataAdapter sda = ExecuteQueryAdapter(sql);
            if (sda == null) return null;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
