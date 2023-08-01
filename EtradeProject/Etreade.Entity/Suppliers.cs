using Etreade.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Entity
{
    public class Suppliers :BaseClass
    {
        public Suppliers()
        {
            Products = new HashSet<Products>();
        }
        public string Street { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public int No { get; set; }
        public string TaxNo { get; set; }
        public ICollection<Products> ? Products { get; set; }
    }
}
