namespace FormuaOne.DataService.Repositories.Interfaces ;

public interface IUnitOfWork
{
    IDriverRepository Drivers {get;}
    IArchievementRepository Archievements {get;}

    Task<bool> CompleteAsync();

}
