using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_QLHH_LamQuen_Voi_Business_common_By_HGK.DataAccess
{
    class DataAcCess
    {
        public string connectionString { get; set; }
        public SqlConnection SQLconnection { get; set; }
        public DataAcCess()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\Form_QLHH_LamQuen_Voi_Business_common_By_HGK\\Form_QLHH_LamQuen_Voi_Business_common_By_HGK\\HangHoaSP.mdf;Integrated Security=True";
            SQLconnection = new SqlConnection(connectionString);
        }
        void OpenConnection()
        {
            SQLconnection.Open();
        }
        void CloseConnection()
        {

            if (SQLconnection.State ==  ConnectionState.Open) {
                SQLconnection.Close();
            }
        }
        public int ExecuteNonQueryCommad(string sql)
        {
            SqlCommand scmd = new SqlCommand(sql, SQLconnection);
            int ketqua = -1;
            try {
                OpenConnection();
                ketqua = scmd.ExecuteNonQuery();
            }
            catch {
            //xử lý lỗi 
            }
            finally
            {
                CloseConnection();
            }
            return ketqua;
        }
        public SqlDataReader ExecyteQuery(string sql)
        {
            SqlCommand scmd = new SqlCommand(sql, SQLconnection);
            SqlDataReader srd = null; 
            try {
                OpenConnection();
                srd = scmd.ExecuteReader();
                if(srd == null)
                {
                    CloseConnection();
                }
            }
            catch
            {

            }
            return srd;
        }
    }
}
