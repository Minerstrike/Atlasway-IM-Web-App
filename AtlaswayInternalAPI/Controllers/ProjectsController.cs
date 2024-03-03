using AtlaswayInternalAPI.Authentication;
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

    //GET: api/Projects/24000
    [HttpGet("{projectNo}")]
    [ProducesResponseType(typeof(List<Project_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get(int projectNo)
    {
        return Ok(context
            .GetProjects()
            .Where(x => x.ProjectNo == projectNo));
    }

    //POST: api/Projects
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public void Post(NewProject_Json project)
    {
        context.PostProject(project);
    }

    //PUT: api/Projects
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public void Update(Project_Json project)
    {
        context.PutProject(project);
    }

    #endregion

}

[ApiKeyAuthFilter]
public class ProjectsV2Controller : BaseController
{
    #region Constructors

    public ProjectsV2Controller(AtlaswayInternalDbContext dbContext) : base(dbContext) { }

    #endregion

    #region Network Requests

    //GET: api/ProjectsV2
    [HttpGet]
    [ProducesResponseType(typeof(List<Project_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get()
    {
        return Ok(context.GetProjects());
    }

    //GET: api/ProjectsV2/24000
    [HttpGet("{projectNo}")]
    [ProducesResponseType(typeof(List<Project_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get(int projectNo)
    {
        return Ok(context
            .GetProjects()
            .Where(x => x.ProjectNo == projectNo));
    }

    //POST: api/ProjectsV2
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public void Post(NewProject_Json project)
    {
        context.PostProject(project);
    }

    //PUT: api/ProjectsV2
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public void Update(Project_Json project)
    {
        context.PutProject(project);
    }

    #endregion

}
