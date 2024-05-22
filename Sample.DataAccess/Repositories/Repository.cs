using Microsoft.EntityFrameworkCore;
using Sample.DataAccess.Context;
using Sample.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sample.DataAccess.Repositories
{
    internal class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly SampleDbContext _context;     

        public Repository(SampleDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _context.Set<T>().AddAsync(entity, cancellationToken);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
        {
           return await _context.Set<T>().AnyAsync(expression, cancellationToken);
        }

        public IQueryable<T> GetAll()
        {
          return _context.Set<T>().AsNoTracking().AsQueryable();  //toList de olabilir bu daha iyiymiş
        }

        public async Task<T?> GetByIDAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression, CancellationToken cancellationToken)
        {
           return await _context.Set<T>().Where(expression).FirstOrDefaultAsync(cancellationToken);
        }

        public IQueryable<T> GetWhere(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking().AsQueryable();
        }

        public void Remove(T entity)
        {
             _context.Remove(entity);
        }

        public void Update(T entity)
        {
          _context.Update(entity);
        }
    }
}
