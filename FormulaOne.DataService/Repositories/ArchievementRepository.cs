using FormuaOne.DataService.Data;
using FormuaOne.DataService.Repositories.Interfaces;
using FormulaOne.Entities.DbSet;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FormuaOne.DataService.Repositories;

public class ArchievementRepository : GenericRepository<Archievement>, IArchievementRepository
{
    public ArchievementRepository(ILogger logger, AppDbContext db) : base(logger, db)
    {
    }

    public async Task<Archievement> GetDriverArchievementAsync(Guid DriverId)
    {
        try
        {

                  return await _dbSet.FirstOrDefaultAsync(a=>a.DriverId ==DriverId);
        }
        catch (Exception e)
        {
            _logger.LogError(e, $"{e.Message} GetDriverArchievementAsync function errors", nameof(ArchievementRepository));
            throw;
        }
    }

       public override async Task<IEnumerable<Archievement>> All()
    {
        try
        {

            return await _dbSet.Where(x => x.Statu.Equals(1)).AsNoTracking().AsSplitQuery().OrderBy(d => d.AddedDate).ToListAsync();

        }
        catch (Exception e)
        {
            _logger.LogError(e, $"{e.Message} All function errors", nameof(ArchievementRepository));
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
            _logger.LogError(e, $"{e.Message} Delete function errors", nameof(ArchievementRepository));
            throw;
        }
    }

    public override  async Task<bool> Update(Archievement archievement)
    {
        try
        {
            var result = await _dbSet.FirstOrDefaultAsync(d => d.Id == archievement.Id);
            if (result is null)
                return false;
            result.FastesLaps=archievement.FastesLaps;
            result.PolePosition=archievement.PolePosition;
            result.RaceWins=archievement.RaceWins;
            result.WordChampionship=archievement.WordChampionship;
            result.UpdatedDate = DateTime.UtcNow;
            return true;

        }
        catch (Exception e)
        {
            _logger.LogError(e, $"{e.Message} Update function errors", nameof(DriverRepository));
            throw;
        }
    }
}
