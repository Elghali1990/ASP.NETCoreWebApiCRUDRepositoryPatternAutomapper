using FormuaOne.DataService.Data;
using FormuaOne.DataService.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace FormuaOne.DataService.Repositories;
public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _db;
    public IDriverRepository Drivers { get; private set; }

    public IArchievementRepository Archievements { get; private set; }

    public UnitOfWork(AppDbContext db, ILoggerFactory loggerFactory)
    {
        _db = db;
        var logger = loggerFactory.CreateLogger("logs");
        Drivers = new DriverRepository(logger, db);
        Archievements = new ArchievementRepository(logger, db);
    }
    public async Task<bool> CompleteAsync()
    {
        return await _db.SaveChangesAsync() > 0;
    }

    private void Dispose(){
        _db.Dispose();
    }
}
