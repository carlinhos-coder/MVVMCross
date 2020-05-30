using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Practica.Core.Models
{
    public class UserRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Solution { get; set; }

    }
}
