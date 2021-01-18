using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    interface Ipreson
    {
        string Skills { get; set; };
        DateTime dataObrith { get; private set; }
        int age { get; private set; }
    }
}
