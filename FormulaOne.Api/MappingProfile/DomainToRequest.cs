using AutoMapper;
using FormulaOne.Entities.DbSet;
using FormulaOne.Entities.Dtos.Request;

namespace FormuaOne.Api.MappingProfile;

public class DomainToRequest:Profile
{
    public DomainToRequest()
    {
         CreateMap<UpdateArchievementDriverRequest, Archievement>()
        .ForMember(dest => dest.RaceWins, opt =>  opt.MapFrom(src => src.Wins))
        .ForMember(dest=>dest.UpdatedDate,opt=>opt.MapFrom(src=>DateTime.UtcNow));
    }
}
