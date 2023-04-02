using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaverecny_projekt_Greplova
{
    internal class WorkHours
    {
        public WorkHours(int idWorkHours, int idEmployee, int idContact, int hours)
        {
            IdWorkHours = idWorkHours;
            IdEmployee = idEmployee;
            IdContact = idContact;
            Hours = hours;
        }

        public int IdWorkHours { get; set; }
        public int IdEmployee { get; set; }
        public int IdContact { get; set; }
        public int Hours { get; set; }
        
    }
}
