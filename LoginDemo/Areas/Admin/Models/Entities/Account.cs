namespace LoginDemo.Areas.Admin.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string PassWord { get; set; }
    }
}
