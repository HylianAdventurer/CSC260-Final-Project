using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    abstract class Location
    {
        public Location ParseLocation(string[] parseStrings)
        {
            if(int.TryParse(parseStrings[0], out int quantity))
                return new Storage(parseStrings[1], quantity);
            return new Department(parseStrings[0]);
        }

        public override abstract string ToString();
    }
}
