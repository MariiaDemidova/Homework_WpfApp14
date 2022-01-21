using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_WpfApp14
{
    public enum ProductTypes
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Picture { get; set; }
        public ProductTypes ProductType { get; set; }
    }
}
