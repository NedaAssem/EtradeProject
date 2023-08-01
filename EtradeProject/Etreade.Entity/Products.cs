using Etreade.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Entity
{
    public class Products : BaseClass
    {
        public int CategoriId { get; set; }
        public int SupplierId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal VAT { get;set; }
        [ForeignKey("CategoriId")]
        public Categories ? Categories { get;set;}
        [ForeignKey("SupplierId")]
        public Suppliers ? Suppliers { get; set; }
    }
}
