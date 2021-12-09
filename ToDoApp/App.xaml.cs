using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ToDoApp.Services;

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ToDoManager.AddToDoItem("Finish TO-DO Application","Lorem ipsum implement UI/UX ");
        }
    }
}
