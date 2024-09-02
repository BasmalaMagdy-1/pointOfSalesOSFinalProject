using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointOfSalesFinalProjectsEntities.Models
{
    public class OrderHeader
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;//don't accept null but set defult value for eay insert for user
        public int? customerId { get; set; }
        public Customer? customer { get; set; }
        public int? storeId {  get; set; }
        public Store? store { get; set; }

    }
}
