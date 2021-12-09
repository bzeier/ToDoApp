using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    internal class ToDoItem
    {
        public string title = "";
        public string description = "";
        public DateTime created = new DateTime();
        public Guid id = Guid.Empty;

        public ToDoItem(string _title, string _desc)
        {
            id = Guid.NewGuid();
            created = DateTime.Now;
            title = _title;
            description = _desc;
        }

    }
}
