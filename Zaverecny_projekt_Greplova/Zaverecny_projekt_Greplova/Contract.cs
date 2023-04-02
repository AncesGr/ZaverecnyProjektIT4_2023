using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaverecny_projekt_Greplova
{
    internal class Contract
    {
        public Contract(int id, string customer, string description)
        {
            Id = id;
            Customer = customer;
            Description = description;
        }

        public int Id { get; set; }
        public string Customer { get; set; }
        public string Description { get; set; }
    }
}

