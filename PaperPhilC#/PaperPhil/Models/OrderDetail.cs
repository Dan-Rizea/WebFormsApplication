﻿using System.ComponentModel.DataAnnotations;

namespace PaperPhil.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public string OrderStatus { get; set; }
    }
}