using Etreade.Entity;
using Etreade.Uow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Etreade.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BasketMasterController : ControllerBase
    {
        IUow _uow;
        BaskitMaster _bm;
        public BasketMasterController(IUow uow,BaskitMaster bm)
        {
          _uow= uow;
            _bm= bm;
        }
        [HttpGet]
        public void CheckOrder()
        {
            string userId = "nada@gmail.com";
            int basketId=_uow.BasketMasterRepos.CheckOrder(userId);
            if (basketId == 0)
            {
                int urunId = 3;
                _bm.Status = 2;
                _bm.Orderdate = DateTime.Now;
                _bm.UserId = userId;
                _uow.BasketMasterRepos.Add(_bm);

                _uow.Commit();
                //return RedirectToAction("Add", "BasketDetail", new { _bm.UserId, _bm.BasketId });
            }
            else
            {
               //return RedirectToAction("Add", "BasketDetail", new { _bm.UserId, _bm.BasketId });
            } 
            //sıfırdan büyük ise tamamlanmamış sipariş var
            //sıfra eşit ise yeni sipariş var
            //BasketDetail

        }
    }
}
