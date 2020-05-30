using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Core.Models
{
    public class UserResponse
    {
        public string Token { get; set; }

        public string Expiration { get; set; }

        public string Problem { get; set; }

    }
}
