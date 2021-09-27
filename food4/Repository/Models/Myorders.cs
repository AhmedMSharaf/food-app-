using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace food4.Repository.Models
{
    [Table("myorders")]
    public partial class Myorders
    {
        public Myorders()
        {
            User = new HashSet<User>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("price")]
        public int? Price { get; set; }
        [Column("productid")]
        public int? Productid { get; set; }

        [InverseProperty("Myordera")]
        public virtual ICollection<User> User { get; set; }
    }
}
