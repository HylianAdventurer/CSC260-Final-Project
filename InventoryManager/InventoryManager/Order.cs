using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    class Order : Displayable
    {
        private Item p_item;
        private int p_id;
        private double p_quantity;
        private string p_quantityUnits;
        private DateTime p_receiveDate, p_dueDate;
        private PhysicalLocation p_orderLocation;

        public Item Item
        {
            get { return p_item; }
            set
            {
                Controls.Remove(p_item);
                p_item = value;
                Controls.Add(p_item);
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

        public double Quantity
        {
            get { return p_quantity; }
            set
            {
                p_quantity = value;
                FormatLabel();
            }
        }

        public string QuantityUnits
        {
            get { return p_quantityUnits; }
            set
            {
                p_quantityUnits = value;
                FormatLabel();
            }
        }

        public DateTime ReceiveDate
        {
            get { return p_receiveDate; }
            set
            {
                p_receiveDate = value;
                FormatLabel();
            }
        }

        public DateTime DueDate
        {
            get { return p_dueDate; }
            set
            {
                p_dueDate = value;
                FormatLabel();
            }
        }

        public PhysicalLocation OrderLocation
        {
            get { return p_orderLocation; }
            set
            {
                Controls.Remove(p_orderLocation);
                p_orderLocation = value;
                Controls.Add(p_orderLocation);
            }
        }

        public Order(Item item, int id, double quantity, string quantityUnits, DateTime receiveDate, DateTime dueDate, PhysicalLocation orderLocation) : base()
        {
            Item = item;
            ID = id;
            Quantity = quantity;
            QuantityUnits = quantityUnits;
            ReceiveDate = receiveDate;
            DueDate = dueDate;
            OrderLocation = orderLocation;

            p_item.TabIndex = 0;
            InfoLabel.TabIndex = 1;
            p_orderLocation.TabIndex = 5;

            Controls.Add(p_item);
            Controls.Add(p_orderLocation);
        }

        public Order(string[] parseStrings) :
            this(
                new Item(ref parseStrings),
                int.Parse(parseStrings[0]),
                double.Parse(parseStrings[1]),
                parseStrings[2],
                DateTime.Parse(parseStrings[3]),
                DateTime.Parse(parseStrings[4]),
                PhysicalLocation.ParseLocation(parseStrings.Skip(5).ToArray())
                ) {}

        protected override void FormatLabel()
        {
            InfoLabel.Text = "Order ID: " + p_id + "\nQuantity: " + p_quantity + " " + p_quantityUnits + "\nReceive Date: " + p_receiveDate + "\nDue Date: " + p_dueDate;
        }

        public override string ToString()
        {
            return p_item + "," + p_id + "," + p_quantity + "," + p_quantityUnits + "," + p_receiveDate + "," + p_dueDate + "," + p_orderLocation;
        }
    }
}
