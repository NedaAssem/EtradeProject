using Etreade.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Entity
{
    public class Categories :BaseClass
    {
        public ICollection<Products> ? Products  { get; set; }
    }
}
