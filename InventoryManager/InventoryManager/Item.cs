using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Item : Displayable
    {
        private string p_itemName;
        private int p_id;

        public string ItemName
        {
            get { return p_itemName; }
            set
            {
                p_itemName = value;
                FormatLabel();
            }
        }

        public int ID
        {
            get { return p_id; }
            set
            {
                p_id = value;
                FormatLabel();
            }
        }

        public Item(string itemName, int id) : base()
        {
            ItemName = itemName;
            ID = id;
        }

        public Item(ref string[] parseStrings) : this(parseStrings[0], int.Parse(parseStrings[1]))
        {
            parseStrings = parseStrings.Skip(2).ToArray();
        }

        protected override void FormatLabel()
        {
            InfoLabel.Text = "Item Name: " + p_itemName + "\nItem ID: " + p_id;
        }

        public override string ToString()
        {
            return p_itemName + "," + p_id;
        }
    }
}
