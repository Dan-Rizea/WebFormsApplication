using System.ComponentModel.DataAnnotations;

namespace PaperPhil.Models
{
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }
        public string CartId { get; set; }
        public int Quantity { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int BookID { get; set; }
        public virtual Product Product { get; set; }
    }
}