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
    public class ProductsRepos : BaseRepos<Products>, IProductsRpos
    {
       
        public ProductsRepos(TreadContext context, GeneralResponse response) : base(context, response)
        {
           
        }

        public List<ProductsDto> GetProducts()
        {
           return Set().Select(x=> new ProductsDto
           {
               Id= x.Id,
               Description= x.Description,
               CategoryName=x.Categories.Description,
               SupplierName=x.Suppliers.Description,
               Price=x.UnitPrice
           }).ToList();
        }
    }
}
