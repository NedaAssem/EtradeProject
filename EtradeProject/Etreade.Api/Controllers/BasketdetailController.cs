using Etreade.Dto;
using Etreade.Entity;
using Etreade.Uow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Etreade.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BasketdetailController : ControllerBase
    {
        IUow _uow;
        BasketDetail _bd;
       
        public BasketdetailController(IUow uow,BasketDetail bd)
        {
            _uow= uow;
            _bd= bd;
        
        }
        [HttpPost]
        public void Add(int basketId, int productId, BasketDetailDTO dto)
        {
            _bd.Amount = dto.Amount;

            _bd.BasketId = basketId;
            _bd.ProductId = productId;
            
            _bd.UintPrice = _uow.ProductsRpos.Find(productId).UnitPrice;
            _uow.BasketDetailRepos.Add(_bd);
            _uow.Commit();
        }
    }
}
