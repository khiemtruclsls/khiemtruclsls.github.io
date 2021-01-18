using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_GAMe_SOLO.Common;

namespace App_GAMe_SOLO.BN
{
   public class BN_Question
    {
        public void ThemDuLieu(Common.CmQuestion q) {
            if (!q.Inset())
            {
                throw new Exception("Loi khi them du lieu ");
            }
        }
        public void ThemDuLieu(string _cauhoi , int _diem , bool _nhieu_dap_an)
        {
            CmQuestion q = new CmQuestion() { Cau_Hoi = _cauhoi , diem = _diem , nhieudapan = _nhieu_dap_an};
            ThemDuLieu(q);

        }
    }
}
