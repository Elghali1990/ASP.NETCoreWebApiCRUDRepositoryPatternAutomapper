namespace FormulaOne.Entities.DbSet;

public class Archievement:EntityBase
{
    public int RaceWins {get;set;}
    public int PolePosition {get;set;}
    public int FastesLaps {get;set;}
    public int WordChampionship {get;set;}
    public Guid DriverId {get;set;}
    public virtual Driver ? Driver {get;set;}
    
}
