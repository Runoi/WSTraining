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
    /// Логика взаимодействия для Aut.xaml
    /// </summary>
    public partial class Aut : Window
    {
        OrderContext db;
        public Aut()
        {
            InitializeComponent();
            db = new OrderContext();
            db.Orders.Load();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            
             var user_name = db.Users.FirstOrDefault(x => x.Full_Name == Name.Text);
             var user_pass = db.Users.FirstOrDefault(x => x.Password == Passowrd.Text);
             if(user_name != null & user_pass != null)
             {
                MessageBox.Show("Вы вошли!");
                db.Dispose();
                Close();
                
             }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
