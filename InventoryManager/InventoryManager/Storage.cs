using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Storage : PhysicalLocation
    {
        private string p_shelfName;
        private int p_shelfNumber;

        public string ShelfName
        {
            get { return p_shelfName; }
            set
            {
                p_shelfName = value;
                FormatLabel();
            }
        }

        public int ShelfNumber
        {
            get { return p_shelfNumber; }
            set
            {
                p_shelfNumber = value;
                FormatLabel();
            }
        }

        public Storage(string shelfName, int shelfNumber) : base()
        {
            InfoLabel = new System.Windows.Forms.Label();
            p_shelfName = shelfName;
            p_shelfNumber = shelfNumber;
            FormatLabel();
            Controls.Add(InfoLabel);
            InfoLabel.AutoSize = true;
            AutoSize = true;
        }

        protected override void FormatLabel()
        {
            InfoLabel.Text = "Shelf: " + p_shelfName + " " + p_shelfNumber;
        }

        public override string ToString()
        {
            return p_shelfNumber + "," + p_shelfName;
        }
    }
}
