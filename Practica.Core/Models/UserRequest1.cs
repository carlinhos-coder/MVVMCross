using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Practica.Core.Models
{
    public class UserRequest1
    {
        [Required]
        public string Document { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }


        [Required]
        public string Username { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public int Group { get; set; }
    }
}
