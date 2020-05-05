using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Department : PhysicalLocation
    {
        private string p_deptName;

        public string DeptName
        {
            get { return p_deptName; }
            set
            {
                p_deptName = value;
                FormatLabel();
            }
        }

        public Department(string deptName) : base()
        {
            InfoLabel = new System.Windows.Forms.Label();
            DeptName = deptName;
            Controls.Add(InfoLabel);
            InfoLabel.AutoSize = true;
            AutoSize = true;
        }

        protected override void FormatLabel()
        {
            InfoLabel.Text = "Department: " + p_deptName;
        }

        public override string ToString()
        {
            return p_deptName;
        }
    }
}
