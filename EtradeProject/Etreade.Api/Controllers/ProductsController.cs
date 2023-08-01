using Etreade.Dto;
using Etreade.Entity;
using Etreade.Res;
using Etreade.Uow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Etreade.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IUow _uow;
        public ProductsController(IUow uow)
        {
            _uow= uow;
        }
        [HttpGet]
        public List<ProductsDto> List()
        {
            return _uow.ProductsRpos.GetProducts();
        }
        [HttpPost]
        public GeneralResponse Create(Products products)
        {
            var rsp = _uow.ProductsRpos.Add(products);
            _uow.Commit();
            return rsp;
        }
        [HttpPut]
        public GeneralResponse Update(Products products)
        {

            var rsp = _uow.ProductsRpos.Update(products);
            _uow.Commit();
            return rsp;
        }
        [HttpDelete]
        public GeneralResponse Delete(Products products)
        {

            var rsp = _uow.ProductsRpos.Delete(products);
            _uow.Commit();
            return rsp;
        }
    }
}
