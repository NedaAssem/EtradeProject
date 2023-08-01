using Etreade.Res;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Core
{
    public interface IBaseRepos<T> where T : class
    {
        List<T> List();
        T Find(int id);
        T Find(string id);
        GeneralResponse Add(T entity);
        GeneralResponse Update(T entity);
        GeneralResponse Delete(T entity);
        DbSet<T> Set();


    }
}
