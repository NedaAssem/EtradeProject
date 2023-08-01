using Etreade.Core;
using Etreade.Dal;
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
    public class CategoriesRepos : BaseRepos<Categories>, ICategoriesRepos
    {
        public CategoriesRepos(TreadContext context, GeneralResponse response) : base(context, response)
        {
        }
    }
}
