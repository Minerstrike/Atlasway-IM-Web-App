using AtlaswayInternalAPI.Controllers.Base;
using AtlaswayInternalAPI.Models;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace AtlaswayInternalAPI.Controllers;

public class ProjectsController : BaseController
{
    #region Constructors

    public ProjectsController(AtlaswayInternalDbContext dbContext) : base(dbContext) { }

    #endregion

    #region Network Requests

    //GET: api/Projects
    [HttpGet]
    [ProducesResponseType(typeof(List<Project_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get()
    {
        return Ok(context.GetProjects());
    }

    //GET: api/Project/100
    [HttpGet("{projectNo}")]
    [ProducesResponseType(typeof(List<Project_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get(int projectNo)
    {
        return Ok(context
            .GetProjects()
            .Where(x => x.ProjectNo == projectNo)
            );
    }

    #endregion
}
