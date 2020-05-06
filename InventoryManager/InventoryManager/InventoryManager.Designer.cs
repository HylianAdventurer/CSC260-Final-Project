namespace InventoryManager
{
    partial class InventoryManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ActionsMenu = new System.Windows.Forms.Panel();
            this.DeleteAllButton = new System.Windows.Forms.Button();
            this.SortingBox = new System.Windows.Forms.GroupBox();
            this.LocationButton = new System.Windows.Forms.RadioButton();
            this.DueDateButton = new System.Windows.Forms.RadioButton();
            this.ReceivedDateButton = new System.Windows.Forms.RadioButton();
            this.QuantityButton = new System.Windows.Forms.RadioButton();
            this.ItemIDButton = new System.Windows.Forms.RadioButton();
            this.OrderIDButton = new System.Windows.Forms.RadioButton();
            this.QuantityUnitsDisplay = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.DeselectButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OrderLocationGroupBox = new System.Windows.Forms.GroupBox();
            this.ShelfNumberLabel = new System.Windows.Forms.Label();
            this.LocationName = new System.Windows.Forms.Label();
            this.ShelfNumberDisplay = new System.Windows.Forms.NumericUpDown();
            this.LocationNameDisplay = new System.Windows.Forms.TextBox();
            this.Storage = new System.Windows.Forms.RadioButton();
            this.Department = new System.Windows.Forms.RadioButton();
            this.DueDateDisplay = new System.Windows.Forms.TextBox();
            this.QuantityDisplay = new System.Windows.Forms.NumericUpDown();
            this.ItemIDDisplay = new System.Windows.Forms.NumericUpDown();
            this.ReceivedDateDisplay = new System.Windows.Forms.TextBox();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.ReceivedDateLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ItemIDLabel = new System.Windows.Forms.Label();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.OrderIDDisplay = new System.Windows.Forms.NumericUpDown();
            this.ItemNameDisplay = new System.Windows.Forms.TextBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.FileDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.InventoryViewer = new System.Windows.Forms.FlowLayoutPanel();
            this.ItemNameButton = new System.Windows.Forms.RadioButton();
            this.ActionsMenu.SuspendLayout();
            this.SortingBox.SuspendLayout();
            this.OrderLocationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShelfNumberDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemIDDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderIDDisplay)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionsMenu
            // 
            this.ActionsMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ActionsMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionsMenu.Controls.Add(this.DeleteAllButton);
            this.ActionsMenu.Controls.Add(this.SortingBox);
            this.ActionsMenu.Controls.Add(this.QuantityUnitsDisplay);
            this.ActionsMenu.Controls.Add(this.ErrorLabel);
            this.ActionsMenu.Controls.Add(this.DeselectButton);
            this.ActionsMenu.Controls.Add(this.DeleteButton);
            this.ActionsMenu.Controls.Add(this.SaveButton);
            this.ActionsMenu.Controls.Add(this.OrderLocationGroupBox);
            this.ActionsMenu.Controls.Add(this.DueDateDisplay);
            this.ActionsMenu.Controls.Add(this.QuantityDisplay);
            this.ActionsMenu.Controls.Add(this.ItemIDDisplay);
            this.ActionsMenu.Controls.Add(this.ReceivedDateDisplay);
            this.ActionsMenu.Controls.Add(this.DueDateLabel);
            this.ActionsMenu.Controls.Add(this.ReceivedDateLabel);
            this.ActionsMenu.Controls.Add(this.QuantityLabel);
            this.ActionsMenu.Controls.Add(this.ItemIDLabel);
            this.ActionsMenu.Controls.Add(this.OrderIDLabel);
            this.ActionsMenu.Controls.Add(this.OrderIDDisplay);
            this.ActionsMenu.Controls.Add(this.ItemNameDisplay);
            this.ActionsMenu.Controls.Add(this.ItemNameLabel);
            this.ActionsMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.ActionsMenu.Location = new System.Drawing.Point(574, 0);
            this.ActionsMenu.Name = "ActionsMenu";
            this.ActionsMenu.Size = new System.Drawing.Size(200, 455);
            this.ActionsMenu.TabIndex = 1;
            // 
            // DeleteAllButton
            // 
            this.DeleteAllButton.Location = new System.Drawing.Point(111, 304);
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteAllButton.TabIndex = 18;
            this.DeleteAllButton.Text = "Delete All";
            this.DeleteAllButton.UseVisualStyleBackColor = true;
            this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // SortingBox
            // 
            this.SortingBox.Controls.Add(this.OrderIDButton);
            this.SortingBox.Controls.Add(this.ItemNameButton);
            this.SortingBox.Controls.Add(this.LocationButton);
            this.SortingBox.Controls.Add(this.DueDateButton);
            this.SortingBox.Controls.Add(this.ReceivedDateButton);
            this.SortingBox.Controls.Add(this.QuantityButton);
            this.SortingBox.Controls.Add(this.ItemIDButton);
            this.SortingBox.Location = new System.Drawing.Point(14, 333);
            this.SortingBox.Name = "SortingBox";
            this.SortingBox.Size = new System.Drawing.Size(172, 114);
            this.SortingBox.TabIndex = 17;
            this.SortingBox.TabStop = false;
            this.SortingBox.Text = "Sort By";
            // 
            // LocationButton
            // 
            this.LocationButton.AutoSize = true;
            this.LocationButton.Location = new System.Drawing.Point(81, 68);
            this.LocationButton.Name = "LocationButton";
            this.LocationButton.Size = new System.Drawing.Size(66, 17);
            this.LocationButton.TabIndex = 5;
            this.LocationButton.Text = "Location";
            this.LocationButton.UseVisualStyleBackColor = true;
            this.LocationButton.CheckedChanged += new System.EventHandler(this.SortingChange);
            // 
            // DueDateButton
            // 
            this.DueDateButton.AutoSize = true;
            this.DueDateButton.Location = new System.Drawing.Point(81, 45);
            this.DueDateButton.Name = "DueDateButton";
            this.DueDateButton.Size = new System.Drawing.Size(71, 17);
            this.DueDateButton.TabIndex = 4;
            this.DueDateButton.Text = "Due Date";
            this.DueDateButton.UseVisualStyleBackColor = true;
            this.DueDateButton.CheckedChanged += new System.EventHandler(this.SortingChange);
            // 
            // ReceivedDateButton
            // 
            this.ReceivedDateButton.AutoSize = true;
            this.ReceivedDateButton.Location = new System.Drawing.Point(81, 22);
            this.ReceivedDateButton.Name = "ReceivedDateButton";
            this.ReceivedDateButton.Size = new System.Drawing.Size(97, 17);
            this.ReceivedDateButton.TabIndex = 3;
            this.ReceivedDateButton.Text = "Received Date";
            this.ReceivedDateButton.UseVisualStyleBackColor = true;
            this.ReceivedDateButton.CheckedChanged += new System.EventHandler(this.SortingChange);
            // 
            // QuantityButton
            // 
            this.QuantityButton.AutoSize = true;
            this.QuantityButton.Location = new System.Drawing.Point(4, 91);
            this.QuantityButton.Name = "QuantityButton";
            this.QuantityButton.Size = new System.Drawing.Size(64, 17);
            this.QuantityButton.TabIndex = 2;
            this.QuantityButton.Text = "Quantity";
            this.QuantityButton.UseVisualStyleBackColor = true;
            this.QuantityButton.CheckedChanged += new System.EventHandler(this.SortingChange);
            // 
            // ItemIDButton
            // 
            this.ItemIDButton.AutoSize = true;
            this.ItemIDButton.Location = new System.Drawing.Point(4, 68);
            this.ItemIDButton.Name = "ItemIDButton";
            this.ItemIDButton.Size = new System.Drawing.Size(59, 17);
            this.ItemIDButton.TabIndex = 1;
            this.ItemIDButton.Text = "Item ID";
            this.ItemIDButton.UseVisualStyleBackColor = true;
            this.ItemIDButton.CheckedChanged += new System.EventHandler(this.SortingChange);
            // 
            // OrderIDButton
            // 
            this.OrderIDButton.AutoSize = true;
            this.OrderIDButton.Checked = true;
            this.OrderIDButton.Location = new System.Drawing.Point(4, 22);
            this.OrderIDButton.Name = "OrderIDButton";
            this.OrderIDButton.Size = new System.Drawing.Size(65, 17);
            this.OrderIDButton.TabIndex = 0;
            this.OrderIDButton.TabStop = true;
            this.OrderIDButton.Text = "Order ID";
            this.OrderIDButton.UseVisualStyleBackColor = true;
            this.OrderIDButton.CheckedChanged += new System.EventHandler(this.SortingChange);
            // 
            // QuantityUnitsDisplay
            // 
            this.QuantityUnitsDisplay.Location = new System.Drawing.Point(111, 76);
            this.QuantityUnitsDisplay.Name = "QuantityUnitsDisplay";
            this.QuantityUnitsDisplay.Size = new System.Drawing.Size(75, 20);
            this.QuantityUnitsDisplay.TabIndex = 16;
            this.QuantityUnitsDisplay.Text = "pcs";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(11, 337);
            this.ErrorLabel.MaximumSize = new System.Drawing.Size(175, 100);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 15;
            // 
            // DeselectButton
            // 
            this.DeselectButton.Location = new System.Drawing.Point(14, 304);
            this.DeselectButton.Name = "DeselectButton";
            this.DeselectButton.Size = new System.Drawing.Size(75, 23);
            this.DeselectButton.TabIndex = 14;
            this.DeselectButton.Text = "Deselect";
            this.DeselectButton.UseVisualStyleBackColor = true;
            this.DeselectButton.Click += new System.EventHandler(this.DeselectButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(111, 275);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(14, 275);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OrderLocationGroupBox
            // 
            this.OrderLocationGroupBox.Controls.Add(this.ShelfNumberLabel);
            this.OrderLocationGroupBox.Controls.Add(this.LocationName);
            this.OrderLocationGroupBox.Controls.Add(this.ShelfNumberDisplay);
            this.OrderLocationGroupBox.Controls.Add(this.LocationNameDisplay);
            this.OrderLocationGroupBox.Controls.Add(this.Storage);
            this.OrderLocationGroupBox.Controls.Add(this.Department);
            this.OrderLocationGroupBox.Location = new System.Drawing.Point(14, 183);
            this.OrderLocationGroupBox.Name = "OrderLocationGroupBox";
            this.OrderLocationGroupBox.Size = new System.Drawing.Size(172, 86);
            this.OrderLocationGroupBox.TabIndex = 12;
            this.OrderLocationGroupBox.TabStop = false;
            this.OrderLocationGroupBox.Text = "Order Location:";
            // 
            // ShelfNumberLabel
            // 
            this.ShelfNumberLabel.AutoSize = true;
            this.ShelfNumberLabel.Location = new System.Drawing.Point(6, 60);
            this.ShelfNumberLabel.Name = "ShelfNumberLabel";
            this.ShelfNumberLabel.Size = new System.Drawing.Size(74, 13);
            this.ShelfNumberLabel.TabIndex = 5;
            this.ShelfNumberLabel.Text = "Shelf Number:";
            // 
            // LocationName
            // 
            this.LocationName.AutoSize = true;
            this.LocationName.Location = new System.Drawing.Point(6, 40);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(38, 13);
            this.LocationName.TabIndex = 4;
            this.LocationName.Text = "Name:";
            // 
            // ShelfNumberDisplay
            // 
            this.ShelfNumberDisplay.Enabled = false;
            this.ShelfNumberDisplay.Location = new System.Drawing.Point(86, 58);
            this.ShelfNumberDisplay.Name = "ShelfNumberDisplay";
            this.ShelfNumberDisplay.Size = new System.Drawing.Size(80, 20);
            this.ShelfNumberDisplay.TabIndex = 3;
            // 
            // LocationNameDisplay
            // 
            this.LocationNameDisplay.Location = new System.Drawing.Point(67, 37);
            this.LocationNameDisplay.Name = "LocationNameDisplay";
            this.LocationNameDisplay.Size = new System.Drawing.Size(99, 20);
            this.LocationNameDisplay.TabIndex = 2;
            // 
            // Storage
            // 
            this.Storage.AutoSize = true;
            this.Storage.Location = new System.Drawing.Point(104, 20);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(62, 17);
            this.Storage.TabIndex = 1;
            this.Storage.TabStop = true;
            this.Storage.Text = "Storage";
            this.Storage.UseVisualStyleBackColor = true;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Checked = true;
            this.Department.Location = new System.Drawing.Point(7, 20);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(80, 17);
            this.Department.TabIndex = 0;
            this.Department.TabStop = true;
            this.Department.Text = "Department";
            this.Department.UseVisualStyleBackColor = true;
            this.Department.CheckedChanged += new System.EventHandler(this.Department_CheckedChanged);
            // 
            // DueDateDisplay
            // 
            this.DueDateDisplay.Location = new System.Drawing.Point(14, 157);
            this.DueDateDisplay.Name = "DueDateDisplay";
            this.DueDateDisplay.Size = new System.Drawing.Size(172, 20);
            this.DueDateDisplay.TabIndex = 11;
            this.DueDateDisplay.Text = "1/1/0001 12:00:00 AM";
            // 
            // QuantityDisplay
            // 
            this.QuantityDisplay.DecimalPlaces = 2;
            this.QuantityDisplay.Location = new System.Drawing.Point(61, 77);
            this.QuantityDisplay.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.QuantityDisplay.Name = "QuantityDisplay";
            this.QuantityDisplay.Size = new System.Drawing.Size(47, 20);
            this.QuantityDisplay.TabIndex = 10;
            // 
            // ItemIDDisplay
            // 
            this.ItemIDDisplay.Location = new System.Drawing.Point(81, 53);
            this.ItemIDDisplay.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.ItemIDDisplay.Name = "ItemIDDisplay";
            this.ItemIDDisplay.Size = new System.Drawing.Size(105, 20);
            this.ItemIDDisplay.TabIndex = 9;
            // 
            // ReceivedDateDisplay
            // 
            this.ReceivedDateDisplay.Location = new System.Drawing.Point(14, 118);
            this.ReceivedDateDisplay.Name = "ReceivedDateDisplay";
            this.ReceivedDateDisplay.Size = new System.Drawing.Size(172, 20);
            this.ReceivedDateDisplay.TabIndex = 8;
            this.ReceivedDateDisplay.Text = "1/1/0001 12:00:00 AM";
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Location = new System.Drawing.Point(11, 141);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(56, 13);
            this.DueDateLabel.TabIndex = 7;
            this.DueDateLabel.Text = "Due Date:";
            // 
            // ReceivedDateLabel
            // 
            this.ReceivedDateLabel.AutoSize = true;
            this.ReceivedDateLabel.Location = new System.Drawing.Point(11, 102);
            this.ReceivedDateLabel.Name = "ReceivedDateLabel";
            this.ReceivedDateLabel.Size = new System.Drawing.Size(82, 13);
            this.ReceivedDateLabel.TabIndex = 6;
            this.ReceivedDateLabel.Text = "Received Date:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(11, 79);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(52, 13);
            this.QuantityLabel.TabIndex = 5;
            this.QuantityLabel.Text = "Quantity: ";
            // 
            // ItemIDLabel
            // 
            this.ItemIDLabel.AutoSize = true;
            this.ItemIDLabel.Location = new System.Drawing.Point(11, 55);
            this.ItemIDLabel.Name = "ItemIDLabel";
            this.ItemIDLabel.Size = new System.Drawing.Size(47, 13);
            this.ItemIDLabel.TabIndex = 4;
            this.ItemIDLabel.Text = "Item ID: ";
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Location = new System.Drawing.Point(11, 11);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(53, 13);
            this.OrderIDLabel.TabIndex = 3;
            this.OrderIDLabel.Text = "Order ID: ";
            // 
            // OrderIDDisplay
            // 
            this.OrderIDDisplay.Location = new System.Drawing.Point(81, 9);
            this.OrderIDDisplay.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.OrderIDDisplay.Name = "OrderIDDisplay";
            this.OrderIDDisplay.Size = new System.Drawing.Size(105, 20);
            this.OrderIDDisplay.TabIndex = 2;
            // 
            // ItemNameDisplay
            // 
            this.ItemNameDisplay.Location = new System.Drawing.Point(81, 30);
            this.ItemNameDisplay.Name = "ItemNameDisplay";
            this.ItemNameDisplay.Size = new System.Drawing.Size(105, 20);
            this.ItemNameDisplay.TabIndex = 1;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(11, 33);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(64, 13);
            this.ItemNameLabel.TabIndex = 0;
            this.ItemNameLabel.Text = "Item Name: ";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileDropdown});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(574, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // FileDropdown
            // 
            this.FileDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.FileDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileDropdown.Name = "FileDropdown";
            this.FileDropdown.Size = new System.Drawing.Size(38, 22);
            this.FileDropdown.Text = "File";
            this.FileDropdown.ToolTipText = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Tag = ".csv";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "inventory.csv";
            // 
            // InventoryViewer
            // 
            this.InventoryViewer.AutoScroll = true;
            this.InventoryViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InventoryViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryViewer.Location = new System.Drawing.Point(0, 25);
            this.InventoryViewer.Name = "InventoryViewer";
            this.InventoryViewer.Size = new System.Drawing.Size(574, 430);
            this.InventoryViewer.TabIndex = 3;
            // 
            // ItemNameButton
            // 
            this.ItemNameButton.AutoSize = true;
            this.ItemNameButton.Location = new System.Drawing.Point(4, 45);
            this.ItemNameButton.Name = "ItemNameButton";
            this.ItemNameButton.Size = new System.Drawing.Size(76, 17);
            this.ItemNameButton.TabIndex = 7;
            this.ItemNameButton.Text = "Item Name";
            this.ItemNameButton.UseVisualStyleBackColor = true;
            this.ItemNameButton.CheckedChanged += new System.EventHandler(this.SortingChange);
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 455);
            this.Controls.Add(this.InventoryViewer);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.ActionsMenu);
            this.Name = "InventoryManager";
            this.Text = "Inventory Manager";
            this.Resize += new System.EventHandler(this.InventoryManager_Resize);
            this.ActionsMenu.ResumeLayout(false);
            this.ActionsMenu.PerformLayout();
            this.SortingBox.ResumeLayout(false);
            this.SortingBox.PerformLayout();
            this.OrderLocationGroupBox.ResumeLayout(false);
            this.OrderLocationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShelfNumberDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemIDDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderIDDisplay)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ActionsMenu;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton FileDropdown;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FlowLayoutPanel InventoryViewer;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Label ReceivedDateLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label ItemIDLabel;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.NumericUpDown OrderIDDisplay;
        private System.Windows.Forms.TextBox ItemNameDisplay;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.TextBox ReceivedDateDisplay;
        private System.Windows.Forms.TextBox DueDateDisplay;
        private System.Windows.Forms.NumericUpDown QuantityDisplay;
        private System.Windows.Forms.NumericUpDown ItemIDDisplay;
        private System.Windows.Forms.GroupBox OrderLocationGroupBox;
        private System.Windows.Forms.NumericUpDown ShelfNumberDisplay;
        private System.Windows.Forms.TextBox LocationNameDisplay;
        private System.Windows.Forms.RadioButton Storage;
        private System.Windows.Forms.RadioButton Department;
        private System.Windows.Forms.Label LocationName;
        private System.Windows.Forms.Label ShelfNumberLabel;
        private System.Windows.Forms.Button DeselectButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox QuantityUnitsDisplay;
        private System.Windows.Forms.Button DeleteAllButton;
        private System.Windows.Forms.GroupBox SortingBox;
        private System.Windows.Forms.RadioButton LocationButton;
        private System.Windows.Forms.RadioButton DueDateButton;
        private System.Windows.Forms.RadioButton ReceivedDateButton;
        private System.Windows.Forms.RadioButton QuantityButton;
        private System.Windows.Forms.RadioButton ItemIDButton;
        private System.Windows.Forms.RadioButton OrderIDButton;
        private System.Windows.Forms.RadioButton ItemNameButton;
    }
}

