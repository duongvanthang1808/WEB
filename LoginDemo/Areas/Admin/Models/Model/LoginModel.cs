using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginDemo.Areas.Admin.Models.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage="Mời nhập username")]
        public String UserName { get; set; }
        [Required(ErrorMessage = "Mời nhập username")]
        public String PassWord { get; set; }
        public bool Remember { get; set; }
    }
}