using FormuaOne.DataService.Data;
using FormuaOne.DataService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FormuaOne.DataService.Repositories ;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public readonly ILogger _logger;
    public readonly AppDbContext _db;
    internal DbSet<T> _dbSet;

    public GenericRepository(ILogger logger,AppDbContext db ){
             _logger=logger;
             _db=db;
             _dbSet=_db.Set<T>();
    }
    public async Task<bool> Add(T entity)
    {
        await _dbSet.AddAsync(entity);
        return true;
    }

    public virtual async Task<IEnumerable<T>> All()
    {
        return await _dbSet.ToListAsync();
    }

    public virtual  Task<bool> Delete(Guid Id)
    {
      throw new NotImplementedException();
    }

    public async Task<T?> GetById(Guid Id)
    {
       return await _dbSet.FindAsync(Id);
    }

    public virtual Task<bool> Update(T entity)
    {
        throw new NotImplementedException();
    }
}
