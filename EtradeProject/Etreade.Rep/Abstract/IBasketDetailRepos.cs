using Etreade.Core;
using Etreade.Dto;
using Etreade.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Rep.Abstract
{
    public interface IBasketDetailRepos : IBaseRepos<BasketDetail>
    {
        BasketDetailDTO GetAmount(int Amount);
    }
}
