using System;
using System.Windows.Forms;
using InventoryApp.Views.Category;

namespace InventoryApp.UserControls
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void addNewCategoryMenuItem_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
            AddCategory addCategory = new AddCategory();
            addCategory.Show();
        }

        private void listCategoriesMenuItem_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
            ListCategory listCategory = new ListCategory();
            listCategory.Show();
        }
    }
}
