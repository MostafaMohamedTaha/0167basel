using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basel.infra.Generic
{
    public interface IGenericRepo<T> where T : class
    {
        //read
        IQueryable<T> GetNoTracking();
        IQueryable<T> GetAsTracking();
        Task<T> GetByIdAsync(int id);
        //add
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(ICollection<T> entities);
        //update
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(ICollection<T> entities);
        //delete
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(ICollection<T> entities);
        //transaction
        void Rollback();
        void Commit();
        IDbContextTransaction BeginTransaction();
        //save
        Task SaveChangesAsync();
    }
}
