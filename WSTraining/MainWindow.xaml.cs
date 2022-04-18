using System.Windows;
using System.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;

namespace WSTraining
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OrderContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new OrderContext();
            db.Orders.Load();
            Order.ItemsSource = db.Orders.Local.ToBindingList();


        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
