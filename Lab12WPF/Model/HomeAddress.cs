using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12WPF.Model
{
    public class HomeAddress
    {
        public int PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? Area { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public int Home { get; set; }
        public int Department { get; set; }
    }
}
