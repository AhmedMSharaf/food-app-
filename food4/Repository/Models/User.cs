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
    public partial class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("image")]
        public string Image { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("myorderaId")]
        public int? MyorderaId { get; set; }
        [Column("type")]
        public bool? Type { get; set; }

        [ForeignKey(nameof(MyorderaId))]
        [InverseProperty(nameof(Myorders.User))]
        public virtual Myorders Myordera { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
