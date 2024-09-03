using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointOfSalesFinalProjectsEntities.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int orderid { get; set; }
        public OrderHeader? order { get; set; }
        public int productId { get; set; }
        public Product? product { get; set; }
        public int QTY { get; set; } = 1;
        public double Price { get; set; } 
        public double Discount { get; set; }
    }
}
