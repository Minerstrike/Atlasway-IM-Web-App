using AtlaswayInternalAPI.Authentication;
using AtlaswayInternalAPI.Controllers.Base;
using AtlaswayInternalAPI.Models;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AtlaswayInternalAPI.Controllers;

public class ProjectStatusTypesController : BaseController
{
    #region Constructors

    public ProjectStatusTypesController(AtlaswayInternalDbContext dbContext) : base(dbContext) { }

    #endregion

    #region Network Requests

    //GET: api/projectStatusTypes
    [HttpGet]
    [ProducesResponseType(typeof(List<ProjectStatusType_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get()
    {
        return Ok(context.GetProjectStatusTypes());
    }

    //GET: api/projectStatusTypes/1
    [HttpGet("{typeNo}")]
    [ProducesResponseType(typeof(List<ProjectStatusType_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get(int typeNo)
    {
        return Ok(context
            .GetProjectStatusTypes()
            .Where(x => x.TypeNo == typeNo)
            );
    }

    #endregion
}

[ApiKeyAuthFilter]
public class ProjectStatusTypesV2Controller : BaseController
{
    #region Constructors

    public ProjectStatusTypesV2Controller(AtlaswayInternalDbContext dbContext) : base(dbContext) { }

    #endregion

    #region Network Requests

    //GET: api/projectStatusTypes
    [HttpGet]
    [ProducesResponseType(typeof(List<ProjectStatusType_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get()
    {
        return Ok(context.GetProjectStatusTypes());
    }

    //GET: api/projectStatusTypes/1
    [HttpGet("{typeNo}")]
    [ProducesResponseType(typeof(List<ProjectStatusType_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get(int typeNo)
    {
        return Ok(context
            .GetProjectStatusTypes()
            .Where(x => x.TypeNo == typeNo)
            );
    }

    #endregion
}
