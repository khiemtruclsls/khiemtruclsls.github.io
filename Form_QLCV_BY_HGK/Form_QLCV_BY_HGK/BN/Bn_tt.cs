using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_QLCV_BY_HGK
{
    class Bn_tt
    {
        public List<trangthaiCM> LayTatCaSanPham()
        {
            trangthaiCM tt = new trangthaiCM();
            return tt.GetALL();
        }

    }
}
