using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabber.Models
{
    public class Memorial
    {
        public string Name { get; set; }
        // TODO: check for specific datatype for spatial geocoordinates 
       public double X {get;set;}
       public double Y { get; set; }
    }
}
