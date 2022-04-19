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
            db.Users.Load();
            Order.ItemsSource = db.Users.Local.ToBindingList();


        }


        string now_db;
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedItem != null)
            {
                //ComboBoxItem selectedItem; 

                if (comboBox.SelectedIndex == 0)
                {
                    db.Users.Load();
                    Order.ItemsSource = db.Users.Local.ToBindingList();
                   
                    //selectedItem = (ComboBoxItem)comboBox.SelectedItem;
                    //now_db = selectedItem.Content.ToString();
                    //now_db = selectedItem.Content.ToString();
                }      
                
                
                if(comboBox.SelectedIndex == 1)                    
                {

                    db.Orders.Load();
                    Order.ItemsSource = db.Orders.Local.ToBindingList();
                    
                    //selectedItem = (ComboBoxItem)comboBox.SelectedItem;
                    //now_db = selectedItem.Content.ToString();
                    //now_db = selectedItem.Content.ToString();

                }
                        
                if(comboBox.SelectedIndex == 2)                       
                {
                            
                    db.Products.Load();                           
                    Order.ItemsSource = db.Products.Local.ToBindingList();
                    
                    //selectedItem = (ComboBoxItem)comboBox.SelectedItem;
                    //now_db = selectedItem.Content.ToString();
                    
                }

                
                   
                
            }
            

            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RegAut regAndAutWin = new RegAut();


            if (regAndAutWin.ShowDialog() == true)
            {

            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            db.Dispose();
        }
    }
}
