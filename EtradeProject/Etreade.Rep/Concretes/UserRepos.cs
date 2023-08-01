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
    public class UserRepos : BaseRepos<Users>, IUserRepos
    {
        UserRespons _userRespons;
        GeneralResponse _response;
        public UserRepos(TreadContext context, GeneralResponse response
            ,UserRespons userRespons) : base(context, response)
        {
            _userRespons = userRespons;
            _response= response;
        }

        public GeneralResponse Login(LoginDTO login)
        {
            var user = Find(login.Email);
            if (user == null)
            {
                _response.Stutas = false;
                _response.Msg = "Kullanıcı E.mail yada Şifresi hatalı ";
            }
            else
            {
                bool v = BCrypt.Net.BCrypt.Verify(login.Password, user.Password);
                if (v)
                {
                    _response.Stutas = true;
                    _response.Msg = "Login Başarılı";
                }
                else
                {
                    _response.Stutas = false;
                    _response.Msg = "Kullanıcı E.mail yada Şifresi hatalı ";
                }
            }
            return _response;
        }

        public bool Register(Users registerUser)
        {
            Users users = Find(registerUser.Email);
            if (users == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
