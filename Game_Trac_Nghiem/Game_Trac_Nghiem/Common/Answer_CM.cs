using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Game_Trac_Nghiem.DataAccess;

namespace Game_Trac_Nghiem.Common
{
    class Answer_CM
    { 
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool Result { get; set; }
        public int ID_qt { get; set; }
        public int ketqua { get; set; }
        SqlDataAccess da = new SqlDataAccess();
        public Answer_CM()
        {

        }
        public Answer_CM(int _id , string _Answwe , bool _Result , int _id_qt)
        {
            Id = _id;
            Answer = _Answwe;
            Result = _Result;
            ID_qt = _id_qt;
        }
        public bool InSert()
        {
            if (string.IsNullOrWhiteSpace(Answer))
            {
                throw new Exception("Chua co Cau hoi...");

            }
            if(Result == true )
            {
                ketqua = 1;
            }else
            {
                ketqua = 0;
            }
            
            string sql = string.Format("Insert into Ans_Wer (answer,Result,Id_qt) values ('{0}') , '{1}' , '{2}' ",Answer, ketqua, ID_qt);
            if (da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true ;
            }
            else
            {
                return false;
            }
        }
        public bool InSert(Answer_CM An)
        {
            return An.InSert();
        }
        public bool InSert(string _Answwe, bool _Result, int _id_qt)
        {
           
            return InSert(new Answer_CM() { Answer = _Answwe, Result = _Result, ID_qt = _id_qt }); 
        }
        public bool Update 
    }
}
