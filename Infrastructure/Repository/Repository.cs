using Domain.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    /// <summary>
    /// 泛型仓储，实现泛型仓储接口
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Repository<TEntity, TDbContext> : IRepository<TEntity> 
        where TEntity : class 
        where TDbContext : IDbContext
    {
        protected readonly TDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(TDbContext dbContext)
        {
            Db = dbContext;
            DbSet = Db.Set<TEntity>();
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await DbSet.AddAsync(entity);
            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            DbSet.Remove(await DbSet.FindAsync(id));
            return true;
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<TEntity> Get(int id)
        {
            var entity = await DbSet.FindAsync(id);
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            DbSet.Update(entity);
            return await Task.FromResult(entity);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public async Task<IList<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }
    }
}
