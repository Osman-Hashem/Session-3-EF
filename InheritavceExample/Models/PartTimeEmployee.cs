using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritavceExample.Models
{
    internal class PartTimeEmployee : Employees 
    {
        public double HourRate { get; set; }    
        public int NumberOfHours { get; set; }
    }
}
