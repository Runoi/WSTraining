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
    /// Логика взаимодействия для UserRed.xaml
    /// </summary>
    public partial class UserRed : Window
    {
        OrderContext db;
        public int id;
        public UserRed() 
        {
            InitializeComponent();
                     
            db = new OrderContext();
            db.Users.Load();
        }

        private void red_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user = db.Users.FirstOrDefault(x => x.User_Id == id);
            user.Full_Name = nam.Text;
            user.Password = pass.Text;
            user.Email = email.Text;
            user.age = Convert.ToInt32(age.Text);
            user.Phone_Number = phone.Text;
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            
            DialogResult = true;

        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user = db.Users.FirstOrDefault(x => x.User_Id == id);
            db.Users.Remove(user);
            db.SaveChanges();
            DialogResult = true;
        }
    }
}
