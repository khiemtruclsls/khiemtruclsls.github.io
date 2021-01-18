using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace COmmoN_By_HGK
{
interface CRUD<L>
    {
        bool Insert();
        bool Insert(L m);

        bool Update();
        bool Update(L m);

        bool Delete();
        bool Delete(L m);

        List<L> GetAll();
        DataTable GetAllTable();

        DataTable SearchTable(string _key);
        List<L> SearchList(string _key);
    }
}
