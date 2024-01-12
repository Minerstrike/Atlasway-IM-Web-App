using AtlaswayInternalAPI.Controllers.Base;
using AtlaswayInternalAPI.Models;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL.Models;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace AtlaswayInternalAPI.Controllers;


public class StaffController : BaseController
{
    #region Constructors

    public StaffController(AtlaswayInternalDbContext dbContext) : base(dbContext) { }

    #endregion

    #region Network Requests

    //GET: api/staff
    [HttpGet]
    [ProducesResponseType(typeof(List<Staff_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get()
    {
        return Ok(context.GetStaff());
    }

    //GET: api/staff/1
    [HttpGet("{StaffNo}")]
    [ProducesResponseType(typeof(List<Staff_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get(int StaffNo)
    {
        return Ok(context
            .GetStaff()
            .Where(x => x.StaffNo == StaffNo)
            );
    }

    #endregion
}
