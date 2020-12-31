using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrintShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }
    }
}