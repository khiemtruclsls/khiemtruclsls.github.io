using Form_QLCV_BY_HGK.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_QLCV_BY_HGK.BN
{
    class Bn_CV
    {
        public void ThemDuLieu(Common.CMcongviec cv)
        {
            if (string.IsNullOrWhiteSpace(cv.Noidung))
            {
                throw new Exception("Cần pải có nội dung !");
            }

            if (!cv.Insert())
                throw new Exception("Lỗi khi thêm dữ liệu ...!");
        }
        public void ThemDuLieu(DateTime _ngaytao, int _ID_TT, DateTime _ngayhoanthanh, String _Noidung)
        {
            Common.CMcongviec CV = new Common.CMcongviec() { ngaytao = _ngaytao, ID_TT = _ID_TT, ngayhoanthanh = _ngayhoanthanh , Noidung = _Noidung};
            //p.Insert();
            ThemDuLieu(CV);
        }
        public void capnhatdl(CMcongviec cv)
        {
            if(cv.ID_Cv <= 0)
            {
                MessageBox.Show("Lỗi ID công việc khi sửa ");
            }
            if (!cv.Update())
            {
                throw new Exception("Lỗi khi thêm dữ Liệu");
            }

        }
        public void capnhatdl(int _ID_Cv , DateTime _ngaytao, int _ID_TT, DateTime _ngayhoanthanh, String _Noidung) {
            CMcongviec CV = new CMcongviec() {ID_Cv = _ID_Cv, ngaytao = _ngaytao, ID_TT = _ID_TT, ngayhoanthanh = _ngayhoanthanh, Noidung = _Noidung };
            capnhatdl(CV);
        }
        public void xoadulieu(CMcongviec cv )
        {
            if(cv.ID_Cv <= 0)
            {
                throw new Exception("Chưa có ai ID cần cập nhật ... ");
            }
            if (!cv.delete())
            {
                throw new Exception("Lỗi khi xóa dữ liệu ");
            }
        }
        public void xoadulieu(int _id)
        {
            CMcongviec cv = new CMcongviec { ID_Cv = _id };
            xoadulieu(cv);
        }

        public List<CMcongviec> laytatca()
        {
            CMcongviec cm = new CMcongviec();
            return cm.GetALL();
        }
    }
}
