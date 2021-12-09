using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoApp.Services;
using System.Collections.ObjectModel;
using ToDoApp.Models;

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            ToDoManager.AddToDoItem(input_title.Text, input_desc.Text);
            input_title.Text = "";
            input_desc.Text = "";
            ItemControlRef.ItemsSource = ToDoManager.ToDoItems;
        }

        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {

        }

    }
}
