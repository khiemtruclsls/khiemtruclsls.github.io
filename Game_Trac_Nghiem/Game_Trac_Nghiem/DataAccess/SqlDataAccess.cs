using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Game_Trac_Nghiem.DataAccess
{
    public class SqlDataAccess
    {
        public string ConnectionString { get; set; }
        public SqlConnection Sqlconnection { get; set; }
        public SqlDataAccess()
        {
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Game_Trac_Nghiem\Game_Trac_Nghiem\Kiem_Tra_tracnghiem_DB.mdf;Integrated Security=True";
            Sqlconnection = new SqlConnection(ConnectionString);
        }
        public SqlDataAccess(string _sqlConnectionString)
        {
            ConnectionString = _sqlConnectionString;
            Sqlconnection = new SqlConnection(ConnectionString);
        }
        public void OpenConnection()
        {
            Sqlconnection.Open();
        }
        public void CloseConnection()
        {
            if(Sqlconnection.State == ConnectionState.Open)
            {
                Sqlconnection.Close();
            }
        }
        public int ExecuteNonQueryCommand(string sql)
        {
            SqlCommand scmd = new SqlCommand(sql, Sqlconnection);
            int ketqua = -1;
            try
            {
                OpenConnection();
                ketqua = scmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                CloseConnection();
            }
            return ketqua;
        }
        public SqlDataReader ExecuteQuery(string sql)
        {
            SqlCommand scmd = new SqlCommand(sql, Sqlconnection);
            SqlDataReader sdr = null;
            try {
                OpenConnection();
                sdr = scmd.ExecuteReader();
                if (sdr == null) CloseConnection();
                
            } catch
            {

            }
            return sdr;
        }
        public SqlDataAdapter ExecuteQueryAdapter(string sql)
        {
            SqlCommand scmd = new SqlCommand(sql, Sqlconnection);
            SqlDataAdapter sda = null;
            try
            {
                OpenConnection();
                sda = new SqlDataAdapter(scmd);
                if (sda == null) CloseConnection();
            }
            catch
            {

            }
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
            if(sda == null)
            {
                return null;
            }
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
