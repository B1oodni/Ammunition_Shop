using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Ammunition_Shop.Classes
{
    class Product
    {
        [Key]
        public int ID_Product { get; set; }
        private string imagePath, title;
        private decimal price;

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product() { }

        public Product(string imagePath, string title, decimal price)
        {
            this.imagePath = imagePath;
            this.title = title;
            this.price = price;
        }
    }
}
