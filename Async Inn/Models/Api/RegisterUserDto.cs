using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Api
{
    public class RegisterUserDto
    {
       
            [Required]
            [MinLength(3)]
            public string Username { get; set; }

            [Required]
            public string Password { get; set; }

            [Required]
            public string Email { get; set; }

            public string PhoneNumber { get; set; }
       
    }
}
