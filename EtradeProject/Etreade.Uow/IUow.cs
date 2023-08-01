using Etreade.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Uow
{
    public interface IUow
    {
      IBasketMasterRepos BasketMasterRepos { get; }
      IBasketDetailRepos BasketDetailRepos { get; }
      ICategoriesRepos CategoriesRepos { get; }
      IProductsRpos ProductsRpos { get; }
      ISuppliersRepos SuppliersRepos { get; }
      IUserRepos UserRepos { get; }
        void Commit();
    }
}
