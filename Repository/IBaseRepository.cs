using PhotoAwards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoAwards.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Add(T item);
        Task<IQueryable<T>> GetAll();
        Task<T> Find(object key);
        Task<T> Remove(object Id);
        Task<T> Update(T item);
    }
}