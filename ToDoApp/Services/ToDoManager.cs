using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;
using ToDoApp.Core;

namespace ToDoApp.Services
{
    static class ToDoManager
    {
        public static ObservableCollection<ToDoItem> ToDoItems = new ObservableCollection<ToDoItem>();

        public static void AddToDoItem(string title, string description)
        {
            if(Utils.isValidInput(title) && (Utils.isValidInput(description)))
            {
                var newItem = new ToDoItem(title, description);
                ToDoItems.Add(newItem);
            }
        }
    }
}
