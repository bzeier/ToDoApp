using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    internal class ToDoManager
    {
        public List<ToDoItem> ToDoList = new List<ToDoItem>();

        public void AddToDoItem(string title, string description)
        {
            var newItem = new ToDoItem(title, description);
            ToDoList.Add(newItem);
        }
    }
}
