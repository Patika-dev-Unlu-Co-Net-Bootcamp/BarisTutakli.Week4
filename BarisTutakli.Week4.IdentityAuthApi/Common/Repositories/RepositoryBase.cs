using BarisTutakli.Week4.IdentityAuthApi.Common.InMemory;
using BarisTutakli.Week4.IdentityAuthApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BarisTutakli.Week4.IdentityAuthApi.Common.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        InMemoryContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public RepositoryBase(InMemoryContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();

        }
        public async Task<int> Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
           return await _context.SaveChangesAsync();

        }

        public async Task<IList<TEntity>> Get(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbSet.Where(filter).ToListAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public Task<TEntity> GetById(int id)
        {
            return Task.FromResult(_dbSet.SingleOrDefault(e => e.Id == id));
        }

        public async Task<int> Update(TEntity entity)
        {
            _dbSet.Update(entity);
            return await _context.SaveChangesAsync();
        }
    }
}
