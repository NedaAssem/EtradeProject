using Etreade.Dal;
using Etreade.Entity;
using Etreade.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Uow
{
    public class Uow : IUow
    {
        private readonly TreadContext _context;

        public IBasketMasterRepos BasketMasterRepos { get;  }
        public IBasketDetailRepos BasketDetailRepos { get; }
        public ICategoriesRepos CategoriesRepos { get; }

        public IProductsRpos ProductsRpos { get; }

        public ISuppliersRepos SuppliersRepos { get; }
        public IUserRepos UserRepos { get;}
        public void Commit()
        {
            _context.SaveChanges();

        }
        public Uow(TreadContext context, IBasketMasterRepos basketMasterRepos, IBasketDetailRepos basketDetailRepos, ICategoriesRepos categoriesRepos, IProductsRpos productsRpos, ISuppliersRepos suppliersRepos, IUserRepos userRepos)
        {
            _context = context;
            BasketMasterRepos = basketMasterRepos;
            BasketDetailRepos = basketDetailRepos;
            CategoriesRepos = categoriesRepos;
            ProductsRpos = productsRpos;
            SuppliersRepos = suppliersRepos;
            UserRepos = userRepos;
        }
    }
}
