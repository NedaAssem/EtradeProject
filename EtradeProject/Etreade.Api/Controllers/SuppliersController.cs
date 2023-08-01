using Etreade.Entity;
using Etreade.Res;
using Etreade.Uow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Etreade.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        IUow _uow;
        public SuppliersController(IUow uow)
        {
            _uow = uow;
        }
        [HttpGet]
        public List<Suppliers> List()
        {
            return _uow.SuppliersRepos.List();
        }
        [HttpPost]
        public GeneralResponse Create(Suppliers supplier)
        {
            var rsp = _uow.SuppliersRepos.Add(supplier);
            _uow.Commit();
            return rsp;
        }
        [HttpPut]
        public GeneralResponse Update(Suppliers supplier)
        {

            var rsp = _uow.SuppliersRepos.Update(supplier);
            _uow.Commit();
            return rsp;
        }
        [HttpDelete]
        public GeneralResponse Delete(Suppliers supplier)
        {

            var rsp = _uow.SuppliersRepos.Delete(supplier);
            _uow.Commit();
            return rsp;
        }
    }
}
