using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{


    public abstract class Employee
    {
        private int int_id;
        public int ID
        {
            get {
                return int_id;           
                }
        }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value.Length < 3)
                {
                    throw new Exception("invalid input ");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public Employee(int int_id)
        {
            this.int_id = int_id;
            _name = "No name ";

        }

        public Employee(int int_id, string name)
        {
            this.int_id = int_id;
            _name = name;
        }
    }
}
    