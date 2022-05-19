using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWBP.Application.Models.DTOs
{
    public class LoginDTO
    {


        [Required(ErrorMessage = "Must to type first name")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Must to type first name")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        public string Password { get; set; }



    }
}
