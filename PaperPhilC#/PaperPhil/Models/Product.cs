using System.ComponentModel.DataAnnotations;
namespace PaperPhil.Models
{
    public class Product
    {
        [ScaffoldColumn(false), Key]
        public int BookID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string BookTitle { get; set; }
        [Display(Name = "ReleaseDate")]
        public int BookRelease { get; set; }
        [Required, StringLength(13), Display(Name = "ISBN")]
        public string ISBN { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }
        public int? CategoryID { get; set; }
        public int? AuthorID { get; set; }
        public int? PublisherID { get; set; }
    }
}