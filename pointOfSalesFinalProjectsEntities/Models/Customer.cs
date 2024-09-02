using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointOfSalesFinalProjectsEntities.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        [StringLength(120)]
        public string? Address { get; set; }
        [StringLength(150)]

        public string? PhoneNumber { get; set; }
        [StringLength(100)]

        public string? CustomerEmail { get; set; }
        [StringLength(150)]

        public string? WebSite { get; set; }
    }
}
