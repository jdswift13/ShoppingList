using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for UserControl.xaml
    /// </summary>
    public partial class AddItemControl: UserControl
    {
        public AddItemControl()
        {
            InitializeComponent();
            AddItemButton.Click += OnAddItemButtonClick;
        }
        protected void OnAddItemButtonClick(object sender, EventArgs args)
        {
           
            if (DataContext is ShoppingListData data)
            {
                data.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }
            
        }
    }
}
