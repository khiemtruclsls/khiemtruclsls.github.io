using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Pro_Owin_API.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProName { get; set; }
        public Nullable<int> ProPrice { get; set; }
        public int ProCateId { get; set; }
    }
}