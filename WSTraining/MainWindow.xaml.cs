using System.Windows;
using System.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

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
            order.ItemsSource = db.Users.Local.ToBindingList();
            

        }

        public User user;
        public int now_cb = 0;
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedItem != null)
            {
                

                if (comboBox.SelectedIndex == 0)
                {
                    now_cb = 0;
                    db.Users.Load();
                    order.ItemsSource = db.Users.Local.ToBindingList();
                   
                    //selectedItem = (ComboBoxItem)comboBox.SelectedItem;
                    //now_db = selectedItem.Content.ToString();
                    //now_db = selectedItem.Content.ToString();
                }      
                
                
                if(comboBox.SelectedIndex == 1)                    
                {
                    now_cb = 1;
                    db.Orders.Load();
                    order.ItemsSource = db.Orders.Local.ToBindingList();
                    
          

                }
                        
                if(comboBox.SelectedIndex == 2)                       
                {
                    now_cb = 2;
                    db.Products.Load();
                    order.ItemsSource = db.Products.Local.ToBindingList();
                    
                    //selectedItem = (ComboBoxItem)comboBox.SelectedItem;
                    //now_db = selectedItem.Content.ToString();
                    
                }
                if (comboBox.SelectedIndex == 3)
                {
                    now_cb = 3;
                    db.Categorys.Load();
                    order.ItemsSource = db.Categorys.Local.ToBindingList();

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add add = new Add();
            if (add.ShowDialog() == true)
            {

            }
        }

        private void Redact(object sender, RoutedEventArgs e)
        {


            //MessageBox.Show(Convert.ToString(now_cb));
            if (now_cb == 0)
            {
                user = (User)order.SelectedItem;
                int user_id = user.User_Id;
                user = db.Users.FirstOrDefault(x => x.User_Id == user_id);
                
                if (user != null)
                {
                    
                    
                    UserRed userRed = new UserRed();
                    userRed.Owner = this;
                    userRed.id= user_id;
                    userRed.nam.Text = user.Full_Name;
                    userRed.pass.Text = user.Password;
                    userRed.email.Text = user.Email;
                    userRed.age.Text = Convert.ToString(user.age);
                    userRed.phone.Text = user.Phone_Number;
                    userRed.ShowDialog();
                    db.Users.Load();
                    
                }
                
            }
            if(now_cb == 1)
            {

            }
            if(now_cb == 2)
            {

            }
            if(now_cb == 3)
            {

            }

        }
    }
}
