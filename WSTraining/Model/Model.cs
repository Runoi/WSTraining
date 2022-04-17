using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace WSTraining.Model
{
    internal class Model
    {
    }

    public class Order_Prod
    {
        public int Order_Id { get; set; }
        public int Product_Id { get; set; }
        public int Count { get; set; }

    }

    public class Order
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public DateTime Date { get; set; }

    }
    
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Full_Name { get; set; }
        public int age { get; set; }
        public string Phone_Number { get; set; }

    }
    
    public class MobileContext : DbContext
    {
        public MobileContext() : base("DefaultConnection")
        {
          
        }

        public DbSet<User> Users { get; set; }
        
    }
}
