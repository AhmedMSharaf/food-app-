using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace food4.Repository.Models
{
    [Table("product")]
    public partial class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("image")]
        public string Image { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("price")]
        public int? Price { get; set; }
        [Column("categoryId")]
        public int? CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Product")]
        public virtual Category Category { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
