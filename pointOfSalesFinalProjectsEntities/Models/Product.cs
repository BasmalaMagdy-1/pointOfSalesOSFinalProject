using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointOfSalesFinalProjectsEntities.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        public double DefultPrice { get; set; }
        [StringLength(250)]
        public string? ProductImage { get; set; }//? to allow null forign key must accept null
        [ForeignKey (nameof(category)) ]
        public int categoryId { get; set; }//لازم الكاتجورى بقي نفس الاسم اللي عامله بيه الفورن كى وال اى دي هي هي البروبرتي اللي في الكاتجورى لازم نفس الاسم +كيس سيستيف
        public Category? category { get; set; }
        //categoryid is made by defult by entity frame work  as i made forgin key to category i only made it for my peronal usage
    }
}
