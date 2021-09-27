using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace food.Repository.Model
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? MyorderaId { get; set; }
        public bool? Type { get; set; }

        public virtual Myorders Myordera { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }
    }
}
