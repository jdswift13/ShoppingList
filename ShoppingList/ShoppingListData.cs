using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ShoppingList
{
    public class ShoppingListData : INotifyPropertyChanged
    { 
        public event PropertyChangedEventHandler PropertyChanged;
    
        List<string> items = new List<string>();
        public IEnumerable<string> Items => items;
        public void Add(string item)
        {
            items.Add(item);
        PropertyChanged?.Invoke(this, new PropertyChangingEventArgs("Items"));
        }
        public void Remove(string item)
        {
            items.Remove(item);
        PropertyChanged?.Invoke(this, new PropertyChangingEventArgs("Items"));
    }

    }
}
