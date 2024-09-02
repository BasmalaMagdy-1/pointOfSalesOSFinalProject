using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace pointOfSalesFinalProjectsEntities.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(150)]
        public string? CategoryDescription { get; set; } 

    }
}
