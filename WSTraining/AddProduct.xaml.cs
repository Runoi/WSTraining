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
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        OrderContext db;
        public AddProduct()
        {
            InitializeComponent();
            db = new OrderContext();
            db.Products.Load();
        }

        private void AddButt_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product { Name = name.Text, Catrgory_Id = Convert.ToInt32(CatId.Text), Price = Convert.ToInt32(price.Text), Available = Convert.ToBoolean(ava.Text)};
            db.Products.Add(product);
            db.SaveChanges();
            db.Dispose();
            this.DialogResult = true;

            
        }
    }
}
