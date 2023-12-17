namespace FormulaOne.Entities.Dtos.Request;

public class UpdateArchievementDriverRequest
{
     public Guid DriverId {get;set;}
    public int WordChampionShips {get;set;}
    public int FastestLap {get;set;}
    public int PolPosition {get;set;}
    public int Wins {get;set;}
}
