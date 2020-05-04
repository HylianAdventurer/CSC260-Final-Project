using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Department : Location
    {
        private string p_deptName;

        public string DeptName
        {
            get { return p_deptName; }
            set { p_deptName = value; }
        }

        public Department(string deptName)
        {
            p_deptName = deptName;
        }

        public override string ToString()
        {
            return p_deptName;
        }
    }
}
