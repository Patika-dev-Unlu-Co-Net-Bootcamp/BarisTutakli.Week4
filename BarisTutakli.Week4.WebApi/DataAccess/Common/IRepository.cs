using BarisTutakli.Week4.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BarisTutakli.Week4.WebApi.DataAccess.Common
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<int> Add(TEntity entity);
        Task<int> Delete(TEntity entity);
        Task<int> Update(TEntity entity);
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<IList<TEntity>> Get(Expression<Func<TEntity, bool>> filter);

    }
}
