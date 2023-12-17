using AutoMapper;
using FormuaOne.DataService.Repositories.Interfaces;
using FormulaOne.Entities.Dtos.Response;
using Microsoft.AspNetCore.Mvc;

namespace FormuaOne.Api.Controllers;

public class ArchievementController : BaseController
{
    public ArchievementController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
    }

    [HttpGet]
    [Route("{driverId:guid}")]
    public async Task<IActionResult> GetDriverArchievements(Guid driverId){
        var driverArchievements =await _unitOfWork.Archievements.GetDriverArchievementAsync(driverId);
        if(driverArchievements is null) return NotFound("Archievement not found");
        var result =_mapper.Map<DriverArchievementResponse>(driverArchievements);
        return Ok(result);
    }
}
