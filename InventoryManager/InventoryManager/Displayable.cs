using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    abstract class Displayable : System.Windows.Forms.FlowLayoutPanel
    {
        private System.Windows.Forms.Label p_infoLabel;

        public System.Windows.Forms.Label InfoLabel
        {
            get { return p_infoLabel; }
            set { p_infoLabel = value; }
        }

        public Displayable()
        {
            p_infoLabel = new System.Windows.Forms.Label();
            Controls.Add(InfoLabel);
            InfoLabel.AutoSize = true;
            AutoSize = true;

        }

        protected abstract void FormatLabel();
    }
}
