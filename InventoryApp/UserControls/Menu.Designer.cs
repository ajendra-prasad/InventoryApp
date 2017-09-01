namespace InventoryApp.UserControls
{
    partial class Menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryMenuItem,
            this.vendorToolStripMenuItem,
            this.brandToolStripMenuItem,
            this.taxCategoryToolStripMenuItem,
            this.productToolStripMenuItem,
            this.updateInventoryToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoryMenuItem
            // 
            this.categoryMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.listCategoriesToolStripMenuItem});
            this.categoryMenuItem.Name = "categoryMenuItem";
            this.categoryMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryMenuItem.Text = "Category";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewCategoryMenuItem_Click);
            // 
            // listCategoriesToolStripMenuItem
            // 
            this.listCategoriesToolStripMenuItem.Name = "listCategoriesToolStripMenuItem";
            this.listCategoriesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listCategoriesToolStripMenuItem.Text = "List Categories";
            this.listCategoriesToolStripMenuItem.Click += new System.EventHandler(this.listCategoriesMenuItem_Click);
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vendorToolStripMenuItem.Text = "Vendor";
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.brandToolStripMenuItem.Text = "Brand";
            // 
            // taxCategoryToolStripMenuItem
            // 
            this.taxCategoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem2,
            this.listToolStripMenuItem,
            this.addTaxToolStripMenuItem,
            this.taxRatesToolStripMenuItem});
            this.taxCategoryToolStripMenuItem.Name = "taxCategoryToolStripMenuItem";
            this.taxCategoryToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.taxCategoryToolStripMenuItem.Text = "Tax Category";
            // 
            // addNewToolStripMenuItem2
            // 
            this.addNewToolStripMenuItem2.Name = "addNewToolStripMenuItem2";
            this.addNewToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.addNewToolStripMenuItem2.Text = "Add New";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.listToolStripMenuItem.Text = "List Taxes";
            // 
            // addTaxToolStripMenuItem
            // 
            this.addTaxToolStripMenuItem.Name = "addTaxToolStripMenuItem";
            this.addTaxToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addTaxToolStripMenuItem.Text = "Add Tax Rates";
            // 
            // taxRatesToolStripMenuItem
            // 
            this.taxRatesToolStripMenuItem.Name = "taxRatesToolStripMenuItem";
            this.taxRatesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.taxRatesToolStripMenuItem.Text = "Tax Rates";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.productListToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.addNewToolStripMenuItem1.Text = "Add New";
            // 
            // productListToolStripMenuItem
            // 
            this.productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            this.productListToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.productListToolStripMenuItem.Text = "Product List";
            // 
            // updateInventoryToolStripMenuItem
            // 
            this.updateInventoryToolStripMenuItem.Name = "updateInventoryToolStripMenuItem";
            this.updateInventoryToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.updateInventoryToolStripMenuItem.Text = "Update Inventory";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(743, 41);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxRatesToolStripMenuItem;
    }
}
