using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Item
    {
        private string p_name;
        private int p_id;

        public string Name
        {
            get { return p_name; }
            set { p_name = value; }
        }

        public int ID
        {
            get { return p_id; }
            set { p_id = value; }
        }

        public Item(string name, int ID)
        {
            p_name = name;
            p_id = ID;
        }

        public Item(ref string[] parseStrings) : this(parseStrings[0], int.Parse(parseStrings[1]))
        {
            parseStrings = parseStrings.Skip<string>(2).ToArray();
        }

        public override string ToString()
        {
            return p_name + "," + p_id;
        }
    }
}
