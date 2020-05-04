using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryManager
{
    class FileManagement
    {
        public List<Order> ReadIn(string path)
        {
            StreamReader file = new StreamReader(path);
            List<Order> inventory = new List<Order>();
            string line;
            while((line = file.ReadLine()) != null)
                inventory.Add(new Order(line));

            file.Close();
            return inventory;
        }

        public void Save(string path, List<Order> inventory)
        {
            StreamWriter file = new StreamWriter(path);

            foreach(Order order in inventory) file.WriteLine(order);

            file.Close();
        }
    }
}
