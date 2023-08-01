using Etreade.Core;
using Etreade.Dal;
using Etreade.Dto;
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
    public class BasketDetailRepos : BaseRepos<BasketDetail>, IBasketDetailRepos
    {
        BasketDetailDTO _bd;
        public BasketDetailRepos(TreadContext context, GeneralResponse response,BasketDetailDTO bd) : base(context, response)
        {
            _bd = bd;
        }

        public BasketDetailDTO GetAmount(int Amount)
        {
            _bd.Amount = Amount;
            return _bd;
        }
    }
}
