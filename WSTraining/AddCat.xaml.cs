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
    /// Логика взаимодействия для AddCat.xaml
    /// </summary>
    public partial class AddCat : Window
    {
        OrderContext db;
        public AddCat()
        {
            InitializeComponent();
            db = new OrderContext();
            db.Categorys.Load();
        }

        private void AdCat_Click(object sender, RoutedEventArgs e)
        {
            Category category = new Category { Category_Name = CatName.Text};
            db.Categorys.Add(category);
            db.SaveChanges();
            db.Dispose();
            this.DialogResult = true;

        }
    }
}
