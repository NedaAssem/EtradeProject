using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Entity
{
    public class BasketDetail
    {
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public decimal UintPrice { get; set; }
        [ForeignKey("BasketId")]
        public BaskitMaster BaskitMaster { get; set; }

    }
}
