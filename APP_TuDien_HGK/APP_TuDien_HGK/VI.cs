using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_TuDien_HGK
{



    public class VI
    {
        public string language { get; set; }
        public Sentence[] sentences { get; set; }
        public object[] suggestions { get; set; }
        public Tratu[] tratu { get; set; }
    }

    public class Sentence
    {
        public string _id { get; set; }
        public FieldsVI fields { get; set; }
    }

    public class FieldsVI
    {
        public string en { get; set; }
        public string vi { get; set; }
    }

    public class Tratu
    {
        public Fields fields { get; set; }
    }

    public class Fields
    {
        public string fulltext { get; set; }
        public string kinds { get; set; }
        public string word { get; set; }
    }

}
