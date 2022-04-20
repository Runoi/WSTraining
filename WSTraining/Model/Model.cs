using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WSTraining
{
    internal class Model
    {
    }

    public class Order_Prod
    {
        [Key]
        public int Order_Id { get; set; }
        public int Product_Id { get; set; }
        public int Count { get; set; }

        public Order_Prod OrderProd { get; set; }

    }

    public class Order
    {
        [Key]
        public int Order_Id { get; set; }
        
        public int User_Id { get; set; }
        public DateTime Date { get; set; }

        virtual public ICollection<Order_Prod> Orders { get; set; }

        public Order()
        {
            Orders = new List<Order_Prod>();
        }


    }
    
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        
        
        public string Email { get; set; }
        public string Password { get; set; }
        public string Full_Name { get; set; }
        public int age { get; set; }
        public string Phone_Number { get; set; }

        virtual public ICollection<Order> Orders { get; set; }

        public User()
        {
            Orders = new List<Order>();
        }


    }

    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        public string Name { get; set; }
        
        public int Catrgory_Id { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; }

        virtual public ICollection<Order_Prod> Products { get; set; }

        public Product()
        {
            Products = new List<Order_Prod>();
        }


    }

    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }

        virtual public ICollection<Product> Categorys { get; set; }

        public Category()
        {
            Categorys = new List<Product>();
        }

    }
    
    public class OrderContext : DbContext
    {
        public OrderContext() : base("DefaultConnection")
        {
          
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order_Prod> Order_Prods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }

    }
}
