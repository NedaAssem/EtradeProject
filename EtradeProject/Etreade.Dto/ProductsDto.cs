using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Dto
{
    public class ProductsDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }
        public decimal Price { get; set; }
    }
}
