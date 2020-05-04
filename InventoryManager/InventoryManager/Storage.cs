using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Storage : Location
    {
        private string p_shelfName;
        private int p_shelfNumber;

        public string ShelfName
        {
            get { return p_shelfName; }
            set { p_shelfName = value; }
        }

        public int ShelfNumber
        {
            get { return p_shelfNumber; }
            set { p_shelfNumber = value; }
        }

        public Storage(string shelfName, int shelfNumber)
        {
            p_shelfName = shelfName;
            p_shelfNumber = shelfNumber;
        }

        public override string ToString()
        {
            return p_shelfNumber + "," + p_shelfName;
        }
    }
}
