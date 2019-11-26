using Microsoft.EntityFrameworkCore;
using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffHubApi.Repositories
{
    public abstract class BaseRepository<TEntity> where TEntity : EntityWithId
    {
        protected readonly StaffHubContext _context;

        public BaseRepository(StaffHubContext context)
        {
            this._context = context;
        }

        public IQueryable<TEntity> All => _context.Set<TEntity>().AsQueryable();

        private DbSet<TEntity> DbSet => _context.Set<TEntity>();

        public TEntity Find(params object[] keyValues)
        {
            return DbSet.Find(keyValues);
        }

        public TEntity Insert(TEntity entity)
        {
            //entity.Id = Guid.NewGuid();
            DbSet.Add(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            DbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public int Delete(TEntity entity)
        {
            DbSet.Attach(entity);
            DbSet.Remove(entity);
            return _context.SaveChanges();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
