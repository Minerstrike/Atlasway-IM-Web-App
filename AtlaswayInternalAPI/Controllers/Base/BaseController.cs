using AtlaswayInternalAPI.Logic;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace AtlaswayInternalAPI.Controllers.Base;


[ApiController]
[Route("api/[controller]")]
public abstract class BaseController : ControllerBase
{
    private protected ApiInterfaceContext context { get; }

    private protected BaseController(AtlaswayInternalDbContext dbContext)
    {
        context = new ApiInterfaceContext(dbContext);
    }
}
