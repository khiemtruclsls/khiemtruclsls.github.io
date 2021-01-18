using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Trac_Nghiem.DataAccess;
using System.Data.SqlClient;
using System.Data;


namespace Game_Trac_Nghiem.Common
{
    public class Question_Cm
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int scores { get; set; }
        public bool many_answer { get; set; }
        public int ketqua { get; set; }
      public Question_Cm()
        {

        }
    public Question_Cm( int _id , string _question , int _scores , bool _many_Answer)
        {
            Id = _id;
            Question = _question;
            scores = _scores;
            many_answer = _many_Answer;
        }
        SqlDataAccess da = new SqlDataAccess();
    public bool Inset()
        {
            if (string.IsNullOrWhiteSpace(Question))
            {
                throw new Exception("Chưa có Question .....");
            }
            if (many_answer == true)
            {
                ketqua = 1;
            }
            if (many_answer == false)
            {
                ketqua = 0;
            }
            string sql = string.Format("insert into Ques_tion (question , scores , Many_answers )values ('{0}','{1}','{2}')",Question,scores, ketqua);
            if(da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }    

        }
        public bool Inset(Question_Cm cm)
        {
            return cm.Inset();
        }
        public bool Inset(string _Question , int _Scores , bool _Many_Answers)
        {
            
            return Inset(new Question_Cm() { Question = _Question, scores = _Scores, many_answer = _Many_Answers });
        }
        public bool Update()
        {
            if (string.IsNullOrWhiteSpace(Question))
            {
                throw new Exception("Thiếu Question  Khi thêm vào DB");
            }
            if (many_answer == true)
            {
                ketqua = 1;
            }
            if (many_answer == false)
            {
                ketqua = 0;
            }
            string sql = string.Format("Update Ques_tion SET question = '{0}' , scores = '{1}' , Many_answer = '{2}'",Question,scores,ketqua);
            if (Id < 0)
            {
                throw new Exception("Id chưa hợp lệ ...");
            }
            if(da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update(Question_Cm cm)
        {
            return cm.Update();
        }
        public bool Update(int _ID , String _Question , int _Scores , bool _Many_Answers  )
        {
            return Update(new Question_Cm() { Id = _ID , Question = _Question , scores = _Scores ,  many_answer = _Many_Answers});
        }
        public bool Delete()
        {
            if(Id < 0)
            {
                throw new Exception("CHưa có Id để xóa ....");

            }
            string sql = string.Format("Delete From Ques_tion WHERE Id = {0}", Id);
            if (da.ExecuteNonQueryCommand(sql) > 0)
            {
                return true;
            }
            else return false;
        }

        public bool Delete(Question_Cm cm)
        {
            return cm.Delete();
        }
        public bool Delete(int _Id)
        {
            return Delete(new Question_Cm() { Id = _Id });
        }

        public List<Question_Cm> GetALL()
        {

            return SearchList("");
        }
        public List<Question_Cm> SearchList(string _Key)
        {
            string sql = "Select * from Ques_tion";
            if (!string.IsNullOrWhiteSpace(_Key))
            {
                sql = string.Format(sql + "Where question  like '{0}'");
            }
            SqlDataReader dr = da.ExecuteQuery(sql);
            List<Question_Cm> list = new List<Question_Cm>();
            
            while (dr.Read())
            {
                list.Add(new Question_Cm() { Id = (int)dr["Id"], Question = (string)dr["question"], scores = (int)dr["scores"], many_answer = dr.GetBoolean(dr.GetOrdinal("Many_answers")) });
                
            }
            return list;
        }
    }
}
