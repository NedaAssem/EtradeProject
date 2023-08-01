using Etreade.Core;
using Etreade.Dal;
using Etreade.Entity;
using Etreade.Rep.Abstract;
using Etreade.Res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Rep.Concretes
{
    public class BasketMasterRepos : BaseRepos<BaskitMaster> , IBasketMasterRepos

    {
        public BasketMasterRepos(TreadContext context, GeneralResponse response) : base(context, response)
        {
        }

        public int CheckOrder(string userId)
        {
            BaskitMaster bm = Set().Where(x=> x.UserId == userId && x.Status==2).FirstOrDefault();
            if(bm !=null)
            {
                return bm.BasketId;
            }
            else { return 0; }
        }
    }
}
