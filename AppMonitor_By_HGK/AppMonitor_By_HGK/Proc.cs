using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMonitor_By_HGK
{
    class Proc
    {
        //khởi tạo đối tượng Process
        public DateTime ThoiGianChay { get; set; }
        public int MyProperty { get; set; }
        public string TenProc { get; set; }
        public int PID { get; set; }
        public string SessionName { get; set; }
        public int SesssionNo { get; set; }
        public int MemUsage { get; set; }
        public string Status { get; set; }
        public string Username { get; set; }
        public string CPUTime { get; set; }
        public string WindowTitle { get; set; }
    }
}
