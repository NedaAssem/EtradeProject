using Etreade.Dal;
using Etreade.Res;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etreade.Core
{
    public class BaseRepos<T> : IBaseRepos<T> where T : class

    {
        TreadContext _context;
        GeneralResponse _response;
        string tableName = typeof(T).Name;
        public BaseRepos(TreadContext context,GeneralResponse response)
        {
            _context= context;
            _response= response;
            
        }
        public GeneralResponse Add(T entity)
        {
            try
            {
               Set().Add(entity);
                _response.Stutas = true;
                _response.Msg = $"{tableName} tablosuna kayıt eklandi";
            }
            catch (Exception ex)
            {
                _response.Stutas= false;
                _response.Msg = $"Hata : {ex.Message}";
            }
            return _response;
        }

        public GeneralResponse Delete(T entity)
        {
            try
            {
                Set().Remove(entity);
                _response.Stutas = true;
                _response.Msg = $"{tableName} tablosundan kayıt silindi";
            }
            catch (Exception ex)
            {
                _response.Stutas = false;
                _response.Msg = $"Hata : {ex.Message}";
            }
            return _response;
        }

        public T Find(int id)
        {
            return Set().Find(id);
        }

        public T Find(string id)
        {
            return Set().Find(id);
        }

        public List<T> List()
        {
            return Set().ToList();
        }

        public DbSet<T> Set()
        {
          return _context.Set<T>();
        }

        public GeneralResponse Update(T entity)
        {
            try
            {
                Set().Update(entity);
                _response.Stutas = true;
                _response.Msg = $"{tableName} tablosunda kayıt güncelledi";
            }
            catch (Exception ex)
            {
                _response.Stutas = false;
                _response.Msg = $"Hata : {ex.Message}";
            }
            return _response;
        }
    }
}
