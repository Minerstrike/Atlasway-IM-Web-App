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

    //GET: api/Projects/100
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

//public class ProjectsV2Controller : BaseController
//{
//    #region Constructors

//    public ProjectsV2Controller(AtlaswayInternalDbContext dbContext) : base(dbContext) { }

//    #endregion

//    #region Network Requests

//    //GET: api/Projects
//    [HttpGet]
//    [ProducesResponseType(typeof(List<Project_JsonV2>), StatusCodes.Status200OK)]
//    [ProducesDefaultResponseType(typeof(Error))]
//    public IActionResult Get()
//    {
//        return Ok(context.GetProjectsV2());
//    }

//    //GET: api/Project/100
//    [HttpGet("{projectNo}")]
//    [ProducesResponseType(typeof(List<Project_JsonV2>), StatusCodes.Status200OK)]
//    [ProducesDefaultResponseType(typeof(Error))]
//    public IActionResult Get(int projectNo)
//    {
//        return Ok(context
//            .GetProjectsV2()
//            .Where(x => x.ProjectNo == projectNo));
//    }

//    #endregion
//}
