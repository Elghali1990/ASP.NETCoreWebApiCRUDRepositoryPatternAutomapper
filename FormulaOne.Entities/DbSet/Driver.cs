namespace FormulaOne.Entities.DbSet;

public class Driver:EntityBase
{
    public Driver()
    {
        Archievements =new HashSet<Archievement>();
    }

    public string FirstName {get;set;}=string.Empty;
    public string LastName {get;set;}=string.Empty;
    public int DriverNumber {get;set;}
    public DateTime DateOfBirth {get;set;}
    public virtual ICollection<Archievement> Archievements {get;set;}
}
