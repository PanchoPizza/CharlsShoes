using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiCharlsShoes.Data
{
    public class RegisterModel
    {

        [Required(ErrorMessage ="User name is requeried")]

        public string userName { get; set; }


        [Required(ErrorMessage = "email name is requeried")]

        public string email { get; set; }


        [Required(ErrorMessage = "password is requeried")]
        public string password { get; set; }
    }
}
