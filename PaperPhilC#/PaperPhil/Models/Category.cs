using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaperPhil.Models
{
    public class Category
    {
        [ScaffoldColumn(false), Key]
        public int CategoryID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}