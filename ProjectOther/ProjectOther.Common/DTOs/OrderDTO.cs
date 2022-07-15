using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjectOther.Common.Models;

namespace ProjectOther.Common.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public int IdDeliverer { get; set; }
        [StringLength(500, ErrorMessage = "Address length can't be more than 500.")]
        public string Address { get; set; }
        [StringLength(10000)]
        public string Comment { get; set; }
        [Range(0.0, 99999.99, ErrorMessage = "Total should be in range of 0.0 to 999999.99")]
        public float Total { get; set; }
        public DateTime DateTimeOfDelivery { get; set; }
        public Enums.OrderStatus OrderStatus { get; set; }
        public IEnumerable<ProductDTO> Products { get; set; }
    }
}
