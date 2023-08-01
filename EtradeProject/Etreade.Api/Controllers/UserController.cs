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
    public class UserController : ControllerBase
    {
        IUow _uow;
        UserRespons _respons;
        public UserController(IUow uow,UserRespons respons)
        {
            _uow= uow;
            _respons= respons;
        }
        [HttpPost]
        public UserRespons Register(Users user)
        {
           bool value=_uow.UserRepos.Register(user);
            if (value)
            {
                user.Role = "user";
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                _uow.UserRepos.Add(user);
                _uow.Commit();
                _respons.Msg = "Başarlı bir şekilde sitemize kayıt oldunuz";
            }
            else {
                _respons.Msg = "Böyle bir kullanıcı Mevcut"; 
            }
            return _respons;
        }
        [HttpPut]
        public GeneralResponse Login(LoginDTO login)
        {
            var rep=_uow.UserRepos.Login(login);
            //if(rep.Stutas==true)
            //{
            //    RedirectToAction("CheckOrder", "BasketMaster", new { login.Email });
            //}
            return rep;
        }

        
    }
}
