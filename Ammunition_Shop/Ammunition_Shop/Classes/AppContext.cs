﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Ammunition_Shop.Classes
{
    class AppContext : DbContext
    {

        public DbSet<User>Users { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public AppContext() : base("Amunnition_ShopEntities") { }


    }
}
