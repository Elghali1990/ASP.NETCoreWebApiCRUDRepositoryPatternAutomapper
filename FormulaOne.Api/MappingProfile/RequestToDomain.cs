using AutoMapper;
using FormulaOne.Entities.DbSet;
using FormulaOne.Entities.Dtos.Request;

namespace FormuaOne.Api.MappingProfile;

public class RequestToDomain : Profile
{
    public RequestToDomain()
    {
        CreateMap<CreateArchievementDriverRequest, Archievement>()
        .ForMember(dest => dest.RaceWins, opt =>  opt.MapFrom(src => src.Wins))
        .ForMember(dest =>dest.Statu,opt=>opt.MapFrom(src=>1))
        .ForMember(dest=>dest.AddedDate,opt=>opt.MapFrom(src=>DateTime.UtcNow))
        .ForMember(dest=>dest.UpdatedDate,opt=>opt.MapFrom(src=>DateTime.UtcNow));
    }
}
