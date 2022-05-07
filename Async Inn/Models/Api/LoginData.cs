using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Api
{
    public class LoginData
    {
        [Required(ErrorMessage = "The Username is correct!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The password is correct!")]
        public string Password { get; set; }
    }
}