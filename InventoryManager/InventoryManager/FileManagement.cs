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
        public static List<Order> ReadIn(string path)
        {
            StreamReader file = new StreamReader(path);
            List<Order> inventory = new List<Order>();
            string line;
            while((line = file.ReadLine()) != null)
                inventory.Add(new Order(line.Split(',')));

            file.Close();
            return inventory;
        }

        public static void Save(string path, List<Order> inventory)
        {
            File.WriteAllText(path, string.Empty);
            StreamWriter file = new StreamWriter(path);

            foreach(Order order in inventory) file.WriteLine(order);

            file.Close();
        }
    }
}
