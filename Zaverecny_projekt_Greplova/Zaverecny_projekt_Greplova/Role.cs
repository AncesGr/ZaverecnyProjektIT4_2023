using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaverecny_projekt_Greplova
{
    public class Role
    {
        public Role(string name)
        {
            Name = name;
        }

        public Role(int id)
        {
            Id = id;
        }

        public string Name { get; set; }
        public int Id { get; set; } 
    }
}
