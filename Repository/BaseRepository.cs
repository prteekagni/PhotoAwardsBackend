using Microsoft.EntityFrameworkCore;
using PhotoAwards.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoAwards.Repository
{
    public class BaseRepository<T>  : IBaseRepository<T> where T:class
    {
        public BaseRepository() { }

        public AppDbContext context;
        private DbSet<T> table = null;
        public BaseRepository(AppDbContext ctx)
        {
            context = ctx;
            table = context.Set<T>();
        }     
       
        async Task<T> IBaseRepository<T>.Add(T item)
        {
            await table.AddAsync(item);
            await context.SaveChangesAsync();
            return item;
        }

        public Task<IQueryable<T>> GetAll()
        {
            return Task.FromResult(table.AsNoTracking());
        }

        public async Task<T> Find(object key)
        {
            return await table.FindAsync(key);
        }

        public async Task<T> Remove(object Id)
        {
            var row = await table.FindAsync(Id);
            table.Remove(row);
            await context.SaveChangesAsync();
            return row;
        }

        public async Task<T> Update(T item)
        {
            table.Attach(item);
            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return item;
        }
    }
}