using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Order
    {
        private Item p_item;
        private double p_quantity;
        private DateTime p_receiveDate, p_dueDate;
        private Location p_location;

        public Item Item
        {
            get { return p_item; }
            set { p_item = value; }
        }

        public double Quantity
        {
            get { return p_quantity; }
            set { p_quantity = value; }
        }

        public DateTime ReceiveDate
        {
            get { return p_receiveDate; }
            set { p_receiveDate = value; }
        }

        public DateTime DueDate
        {
            get { return p_dueDate; }
            set { p_dueDate = value; }
        }

        public Location Location
        {
            get { return p_location; }
            set { p_location = value; }
        }

        public Order(Item item, double quantity, DateTime receiveDate, DateTime dueDate, Location location)
        {
            p_item = item;
            p_quantity = quantity;
            p_receiveDate = receiveDate;
            p_dueDate = dueDate;
            p_location = location;
        }

        public Order(string parseString)
        {
            string[] arr = parseString.Split(',');
            p_item = new Item(ref arr);
            p_quantity = double.Parse(arr[0]);
            p_receiveDate = DateTime.Parse(arr[1]);
            p_dueDate = DateTime.Parse(arr[2]);
            arr = arr.Skip(3).ToArray();
            p_location = Location.ParseLocation(arr);
        }

        public override string ToString()
        {
            return p_item + "," + p_quantity + "," + p_receiveDate + "," + p_dueDate + "," + p_location;
        }
    }
}
