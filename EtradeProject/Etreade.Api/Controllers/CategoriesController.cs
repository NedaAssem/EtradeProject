using Etreade.Entity;
using Etreade.Res;
using Etreade.Uow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Etreade.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        IUow _uow;
        public CategoriesController(IUow uow)
        {
            _uow = uow;
        }
        [HttpGet]
        public List<Categories> List()
        {
            return _uow.CategoriesRepos.List();
        }
        [HttpPost]
        public GeneralResponse Create(Categories category)
        {
            var rsp = _uow.CategoriesRepos.Add(category);
            _uow.Commit();
            return rsp;
        }
        [HttpPut]
        public GeneralResponse Update(Categories category)
        {
           
            var rsp = _uow.CategoriesRepos.Update(category);
            _uow.Commit();
            return rsp;
        }
        [HttpDelete]
        public GeneralResponse Delete(Categories category)
        {

            var rsp = _uow.CategoriesRepos.Delete(category);
            _uow.Commit();
            return rsp;
        }
    }
}
