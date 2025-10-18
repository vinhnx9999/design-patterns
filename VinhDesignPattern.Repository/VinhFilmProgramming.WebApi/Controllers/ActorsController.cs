using Microsoft.AspNetCore.Mvc;
using VinhFilmProgramming.Domain.Repositories;

namespace VinhFilmProgramming.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActorsController(IUnitOfWork unitOfWork) : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    [HttpGet]
    public ActionResult Get()
    {
        var actorsFromRepo = _unitOfWork.Actor.GetAll();
        return Ok(actorsFromRepo);
    }
}
