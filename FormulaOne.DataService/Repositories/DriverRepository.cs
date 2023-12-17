using FormuaOne.DataService.Data;
using FormuaOne.DataService.Repositories.Interfaces;
using FormulaOne.Entities.DbSet;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FormuaOne.DataService.Repositories;

public class DriverRepository : GenericRepository<Driver>, IDriverRepository
{
    public DriverRepository(ILogger logger, AppDbContext db) : base(logger, db)
    {
    }

    public override async Task<IEnumerable<Driver>> All()
    {
        try
        {

            return await _dbSet.Where(x => x.Statu.Equals(1)).AsNoTracking().AsSplitQuery().OrderBy(d => d.AddedDate).ToListAsync();

        }
        catch (Exception e)
        {
            _logger.LogError(e, $"{e.Message} All function errors", nameof(DriverRepository));
            throw;
        }
    }


    public override async Task<bool> Delete(Guid Id)
    {
        try
        {
            var result = await _dbSet.FirstOrDefaultAsync(d => d.Id == Id);
            if (result is null)
                return false;
            result.Statu = 0;
            result.UpdatedDate = DateTime.UtcNow;
            return true;

        }
        catch (Exception e)
        {
            _logger.LogError(e, $"{e.Message} All function errors", nameof(DriverRepository));
            throw;
        }
    }

    public override  async Task<bool> Update(Driver driver)
    {
        try
        {
            var result = await _dbSet.FirstOrDefaultAsync(d => d.Id == driver.Id);
            if (result is null)
                return false;
            result.FirstName=driver.LastName;
            result.LastName=driver.LastName;
            result.DateOfBirth=driver.DateOfBirth;
            result.DriverNumber=driver.DriverNumber;
            result.UpdatedDate = DateTime.UtcNow;
            return true;

        }
        catch (Exception e)
        {
            _logger.LogError(e, $"{e.Message} All function errors", nameof(DriverRepository));
            throw;
        }
    }


}










