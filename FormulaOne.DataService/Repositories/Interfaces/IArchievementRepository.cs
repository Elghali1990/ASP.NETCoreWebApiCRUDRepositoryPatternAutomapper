using FormulaOne.Entities.DbSet;

namespace FormuaOne.DataService.Repositories.Interfaces ;

public interface IArchievementRepository:IGenericRepository<Archievement>
{
    Task<Archievement> GetDriverArchievementAsync(Guid DriverId);
}
