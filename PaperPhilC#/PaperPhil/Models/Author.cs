using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaperPhil.Models
{
    public class Author
    {
        [ScaffoldColumn(false), Key]
        public int AuthorID { get; set; }
        [Required, StringLength(150), Display(Name = "Author Name")]
        public string AuthorName { get; set; }
        public string AuthorWebsite { get; set; }
        public string AuthorCountry { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}