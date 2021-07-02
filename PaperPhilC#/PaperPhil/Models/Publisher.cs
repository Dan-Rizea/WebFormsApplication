using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaperPhil.Models
{
    public class Publisher
    {
        [ScaffoldColumn(false), Key]
        public int publisherID { get; set; }
        public string publisherName { get; set; }
        public string publisherWebsite { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}