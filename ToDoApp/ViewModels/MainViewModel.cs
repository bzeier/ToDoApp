using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Services;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    class MainViewModel
    {

        public static ObservableCollection<ToDoItem> ToDoItems
        {
            get { return ToDoManager.ToDoItems; }
        }
        
    }
}
