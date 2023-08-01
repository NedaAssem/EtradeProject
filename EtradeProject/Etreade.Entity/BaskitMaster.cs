using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Entity
{
    public class BaskitMaster
        
    {
        public BaskitMaster()
        {
            BasketDetails = new HashSet<BasketDetail>();
        }
        [Key]
        public int BasketId { get; set; }
        public DateTime Orderdate { get;set; }
        public string UserId { get; set; }
        public int Status { get; set; } //1 Tamamlanmış 2 Tamamlanmamış
        public ICollection<BasketDetail> BasketDetails { get; set; }
    }
}
