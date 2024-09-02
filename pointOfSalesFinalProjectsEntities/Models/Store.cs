using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointOfSalesFinalProjectsEntities.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string StoreName { get; set; }
        [StringLength(50)]
        public  string? Address { get; set; }
        [StringLength(50)]
        public string? PhoneNumber { get; set; }
        
    }

}
