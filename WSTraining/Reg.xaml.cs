using System.Windows;
using System.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;

namespace WSTraining
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        OrderContext db;
        public Window1()
        {
            InitializeComponent();
            db = new OrderContext();
            db.Orders.Load();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            User user = new User { Full_Name = Name.Text, Password = Password.Text, age = Convert.ToInt32(Age.Text), Email = Email.Text, Phone_Number = Phone.Text };
            db.Users.Add(user);
            db.SaveChanges();
            db.Dispose();
            this.DialogResult = true;
        }

        private void Ex_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
