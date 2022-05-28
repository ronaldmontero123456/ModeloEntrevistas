using Microsoft.EntityFrameworkCore;
using ModeloEntrevistas.Core.Interfaces;
using ModeloEntrevistas.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeloEntrevistas.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ModeloEntrevistasContext _Context;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(ModeloEntrevistasContext Context)
        {
            _Context = Context;
            dbSet = Context.Set<T>();
        }
        public async Task Add(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            T entity = await GetById(id);
            dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.AsEnumerable();
        }

        public async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
