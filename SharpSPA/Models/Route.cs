using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SharpSPA.Models
{
    public class Route
    {
        public string Path { get; set; }

        public Type Page { get; set; }

        public Dictionary<string, object> Data { get; set; }

    }
}