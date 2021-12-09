using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    internal class ToDoItem : INotifyPropertyChanged
    {
        private string title = "Finish To-Do Application";
        public string Title
        {
            get { return this.title; }
            set { title = value; }
        }

        private string description = "Implement UI" +
            "Implement saving/loading to database";
        public string Description
        {
            get { return this.description; }
            set { description = value; }
        }

        public DateTime created = new DateTime();
        public Guid id = Guid.Empty;

        public ToDoItem(string _title, string _desc)
        {
            id = Guid.NewGuid();
            created = DateTime.Now;
            title = _title;
            description = _desc;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
}
