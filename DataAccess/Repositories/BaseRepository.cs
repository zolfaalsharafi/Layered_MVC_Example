using Microsoft.EntityFrameworkCore;
using MVC_Example.DataAccessLayer.Data;
using MVC_Example.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Example.DataAccessLayer.Repositories
{
    public class BaseRepository<TModel> : IRepository<TModel> where TModel : BaseEntity
    {
        private readonly ApplicationContext context;
        DbSet<TModel> dbSet;
        public BaseRepository(ApplicationContext context)
        {
            this.context = context;
            dbSet = context.Set<TModel>();

        }

        public async Task CreateAsync(TModel entity)
        {
            dbSet.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TModel entity)
        {
            dbSet.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task RemoveAsync(TModel entity)
        {
            dbSet.Remove(entity);
            await context.SaveChangesAsync();
        }

        public Task<TModel> GetById(int id)
        {
            // Assuming that the models have an 'Id' property
            return dbSet.FirstOrDefaultAsync(e => e.Id == id);
        }

        public Task<List<TModel>> GetAll()
        {
            return dbSet.ToListAsync();
        }
    }
}
