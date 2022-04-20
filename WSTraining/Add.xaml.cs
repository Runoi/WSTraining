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
using System.Windows.Shapes;

namespace WSTraining
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Cat_Click(object sender, RoutedEventArgs e)
        {
            AddCat addCat = new AddCat();
            if (addCat.ShowDialog() == true)
            {
                MessageBox.Show("Вы добавили категорию!");
                DialogResult = true;
            }
        }

        private void Prod_Click(object sender, RoutedEventArgs e)
        {
            AddProduct addProd = new AddProduct();
            if (addProd.ShowDialog() == true)
            {
                MessageBox.Show("Вы добавили продукт!");
                DialogResult = true;
            }
        }

        private void Ord_Click(object sender, RoutedEventArgs e)
        {
            AddOrd addOrd = new AddOrd();
            if (addOrd.ShowDialog() == true)
            {
                MessageBox.Show("Вы добавили заказ!");
                DialogResult = true;
            }
        }
    }
}
