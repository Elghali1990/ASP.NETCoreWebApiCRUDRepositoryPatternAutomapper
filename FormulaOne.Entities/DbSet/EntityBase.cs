namespace FormulaOne.Entities.DbSet;

public class EntityBase
{
    public Guid Id {get;set;}=Guid.NewGuid();
    public DateTime AddedDate {get;set;}=DateTime.UtcNow;
    public DateTime UpdatedDate {get;set;}=DateTime.UtcNow;
    public int Statu {get;set;}
}
