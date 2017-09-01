namespace InventoryApp.Views.Category
{
    partial class AddCategory
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
            this.menu1 = new InventoryApp.UserControls.Menu();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(0, -1);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(796, 49);
            this.menu1.TabIndex = 0;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 476);
            this.Controls.Add(this.menu1);
            this.Name = "AddCategory";
            this.Text = "Add Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Menu menu1;
    }
}