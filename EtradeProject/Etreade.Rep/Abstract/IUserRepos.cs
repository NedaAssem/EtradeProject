using Etreade.Core;
using Etreade.Dto;
using Etreade.Entity;
using Etreade.Res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Rep.Abstract
{
    public interface IUserRepos : IBaseRepos<Users>
    {
        public bool Register(Users registerUser);
        public GeneralResponse Login(LoginDTO login);
    }
}
