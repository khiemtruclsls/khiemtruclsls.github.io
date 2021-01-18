using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Trac_Nghiem.Common;

namespace Game_Trac_Nghiem.BN
{
    class Question_Bn
    {
        public bool ThemDulieu(string _Question , int _Scores , bool _Many_Anwser)
        {
            Question_Cm cm = new Question_Cm() { Question = _Question, scores = _Scores, many_answer = _Many_Anwser };
            return cm.Inset();
        }
        public bool SuaDulieu(int _Id, string _question, int _scores, bool _Many_awser)
        {
            Question_Cm cm = new Question_Cm() { Id = _Id, Question = _question, scores = _scores, many_answer =_Many_awser };
            return cm.Update();
        }
        public bool XoaDuLieu(int _Id)
        {
            Question_Cm cm = new Question_Cm() { Id = _Id };
            return cm.Delete();
        }
        public List<Question_Cm> laytatcacauhoi()
        {
            return new Question_Cm().GetALL();
        }
    }
}
