using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSPA.Models
{
    public class SpaOptions
    {
        public List<Route> Routes { get; set; }

        public string RouterOutletName { get; set; }
    }
}
