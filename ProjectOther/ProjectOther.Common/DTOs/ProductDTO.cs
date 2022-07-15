using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectOther.Common.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]
        public string Name { get; set; }
        [Range(0.0, 1999.99, ErrorMessage = "Price should be in range of 0.0 to 1999.99")]
        public float Price { get; set; }
        [StringLength(2000, ErrorMessage = "Ingredients length can't be more than 2000.")]
        public string Ingredients { get; set; }
    }
}
