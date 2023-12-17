using AutoMapper;
using FormuaOne.DataService.Repositories.Interfaces;

namespace FormuaOne.Api.Controllers;
public class DriverController : BaseController
{
    public DriverController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
    }
}
