using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Core.Models
{
    public class Group
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
