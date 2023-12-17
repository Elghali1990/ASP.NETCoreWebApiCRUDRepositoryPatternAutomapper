using AutoMapper;
using FormuaOne.DataService.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FormuaOne.Api.Controllers;
[Route("Api/controller")]
[ApiController]
public class BaseController:ControllerBase
{
 protected readonly IUnitOfWork _unitOfWork;   
 protected readonly IMapper _mapper;

    public BaseController(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _unitOfWork=unitOfWork;
        _mapper=mapper;
    }
}
