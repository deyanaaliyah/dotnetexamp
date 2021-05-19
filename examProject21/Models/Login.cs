using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace examProject21.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please insert username")]
        public String UserName { get; set; }

        [Required(ErrorMessage = "Please insert Password")]
        public String Password { get; set; }
    }
}
