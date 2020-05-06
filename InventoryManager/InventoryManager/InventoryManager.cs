using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class InventoryManager : Form
    {
        List<Order> Inventory;
        Order SelectedOrder;

        public InventoryManager()
        {
            Inventory = new List<Order>();
            InitializeComponent();
            ClearOrder();
        }

        private void UpdateInventory()
        {
            Sort();
            foreach (Order order in Inventory)
            {
                InventoryViewer.Controls.Remove(order);
                InventoryViewer.Controls.Add(order);
                order.Location = new Point(3, Inventory.IndexOf(order)*78+3);
                order.Name = order.Item.Name;
                order.MinimumSize = new Size(InventoryViewer.Width - 2 * order.Margin.Horizontal, 75);
                order.TabIndex = Inventory.IndexOf(order);
                order.BackColor = order == SelectedOrder ? SystemColors.ButtonShadow : SystemColors.ButtonFace;
                order.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        public void InventoryManager_Resize(object sender, EventArgs e)
        {
            foreach (Order order in Inventory)
            {
                order.Width = InventoryViewer.Width - 2 * order.Margin.Horizontal;
            }
            UpdateInventory();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileManagement.Save(saveFileDialog.FileName, Inventory);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Order order in Inventory) InventoryViewer.Controls.Remove(order);
                Inventory = FileManagement.ReadIn(openFileDialog.FileName);
                foreach (Order order in Inventory)
                {
                    order.Click += new EventHandler(order_Click);
                    order.Item.InfoLabel.Click += new EventHandler(order_Click);
                    order.InfoLabel.Click += new EventHandler(order_Click);
                    order.OrderLocation.InfoLabel.Click += new EventHandler(order_Click);
                }
                UpdateInventory();
            }
        }

        public void order_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Order)) SelectedOrder = (Order)sender;
            else
                foreach(Order order in Inventory)
                    if (order.Item.InfoLabel == sender || order.InfoLabel == sender || order.OrderLocation.InfoLabel == sender) SelectedOrder = order;

            foreach (Order order in Inventory)
                order.BackColor = order == SelectedOrder ? SystemColors.ButtonShadow : SystemColors.ButtonFace;

            
            OrderIDDisplay.Value = SelectedOrder.ID;
            ItemNameDisplay.Text = SelectedOrder.Item.ItemName;
            ItemIDDisplay.Value = SelectedOrder.Item.ID;
            QuantityDisplay.Value = (decimal)SelectedOrder.Quantity;
            ReceivedDateDisplay.Text = SelectedOrder.ReceiveDate.ToString();
            DueDateDisplay.Text = SelectedOrder.DueDate.ToString();

            if(SelectedOrder.OrderLocation.GetType() == typeof(Department))
            {
                Department.Checked = true;
                LocationNameDisplay.Text = ((Department)SelectedOrder.OrderLocation).DeptName;
                ShelfNumberDisplay.Value = 0;
            }
            else
            {
                Storage.Checked = true;
                LocationNameDisplay.Text = ((Storage)SelectedOrder.OrderLocation).ShelfName;
                ShelfNumberDisplay.Value = ((Storage)SelectedOrder.OrderLocation).ShelfNumber;
            }
        }

        private void DeselectButton_Click(object sender, EventArgs e)
        {
            foreach (Order order in Inventory)
                order.BackColor = SystemColors.ButtonFace;

            SelectedOrder = null;
            ClearOrder();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime buff;
            if (ItemNameDisplay.Text.Contains(",") || ItemNameDisplay.Text.Contains("\\") || QuantityUnitsDisplay.Text.Contains(",") || QuantityUnitsDisplay.Text.Contains("\\") || LocationNameDisplay.Text.Contains(",") || LocationNameDisplay.Text.Contains("\\"))
            {
                ErrorLabel.Text = "Text boxes cannot have commas or '\\' in it!";
            }
            else if (ItemNameDisplay.Text == "" || QuantityUnitsDisplay.Text == "" || LocationNameDisplay.Text == "")
            {
                ErrorLabel.Text = "Text boxes cannot be empty";
            }
            else if (!DateTime.TryParse(ReceivedDateDisplay.Text, out buff) || !DateTime.TryParse(DueDateDisplay.Text, out buff))
            {
                ErrorLabel.Text = "Dates must have a form of:\n" + new DateTime(2020, 5, 5, 6, 0, 0).ToString();
            }
            else if (SelectedOrder == null)
            {
                SelectedOrder = new Order(
                    new Item(ItemNameDisplay.Text, (int)ItemIDDisplay.Value),
                    (int)OrderIDDisplay.Value,
                    (double)QuantityDisplay.Value,
                    QuantityUnitsDisplay.Text,
                    DateTime.Parse(ReceivedDateDisplay.Text),
                    DateTime.Parse(DueDateDisplay.Text),
                    Department.Checked ? (PhysicalLocation)new Department(LocationNameDisplay.Text) : new Storage(LocationNameDisplay.Text, (int)ShelfNumberDisplay.Value)
                    );
                Inventory.Add(SelectedOrder);
                SelectedOrder.Click += new EventHandler(order_Click);
                SelectedOrder.Item.InfoLabel.Click += new EventHandler(order_Click);
                SelectedOrder.InfoLabel.Click += new EventHandler(order_Click);
                SelectedOrder.OrderLocation.InfoLabel.Click += new EventHandler(order_Click);
                ErrorLabel.Text = "";
            }
            else
            {
                SelectedOrder.Item.ItemName = ItemNameDisplay.Text;
                SelectedOrder.Item.ID = (int)ItemIDDisplay.Value;
                SelectedOrder.ID = (int)OrderIDDisplay.Value;
                SelectedOrder.Quantity = (double)QuantityDisplay.Value;
                SelectedOrder.ReceiveDate = DateTime.Parse(ReceivedDateDisplay.Text);
                SelectedOrder.DueDate = DateTime.Parse(DueDateDisplay.Text);
                SelectedOrder.OrderLocation = Department.Checked ? (PhysicalLocation)new Department(LocationNameDisplay.Text) : new Storage(LocationNameDisplay.Text, (int)ShelfNumberDisplay.Value);
                ErrorLabel.Text = "";
            }
            UpdateInventory();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(SelectedOrder != null)
            {
                Inventory.Remove(SelectedOrder);
                InventoryViewer.Controls.Remove(SelectedOrder);
                UpdateInventory();
                SelectedOrder = null;
                ClearOrder();
            }
        }

        private void Department_CheckedChanged(object sender, EventArgs e)
        {
            ShelfNumberDisplay.Enabled = Storage.Checked;
        }

        private void ClearOrder()
        {
            OrderIDDisplay.Value = 0;
            ItemNameDisplay.Text = "Item Name";
            ItemIDDisplay.Value = 0;
            QuantityDisplay.Value = 0;
            QuantityUnitsDisplay.Text = "pcs";
            ReceivedDateDisplay.Text = new DateTime().ToString();
            DueDateDisplay.Text = new DateTime().ToString();
            LocationNameDisplay.Text = "Location Name";
            ShelfNumberDisplay.Value = 0;
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            foreach (Order order in Inventory) InventoryViewer.Controls.Remove(order);
            Inventory.Clear();
            UpdateInventory();
            ClearOrder();
        }

        private void SortingChange(object sender, EventArgs e)
        {
            UpdateInventory();
        }

        private void Sort()
        {
            if(OrderIDButton.Checked)
                Inventory = (from order in Inventory orderby order.ID select order).ToList();
            else if (ItemNameButton.Checked)
                Inventory = (from order in Inventory orderby order.Item.Name select order).ToList();
            else if(ItemIDButton.Checked)
                Inventory = (from order in Inventory orderby order.Item.ID select order).ToList();
            else if(QuantityButton.Checked)
                Inventory = (from order in Inventory orderby order.Quantity select order).ToList();
            else if(ReceivedDateButton.Checked)
                Inventory = (from order in Inventory orderby order.ReceiveDate select order).ToList();
            else if(DueDateButton.Checked)
                Inventory = (from order in Inventory orderby order.DueDate select order).ToList();
            else if(LocationButton.Checked)
                Inventory = (from order in Inventory orderby order.OrderLocation.InfoLabel.Text select order).ToList();
        }
    }
}
