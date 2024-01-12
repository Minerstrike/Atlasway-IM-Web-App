using AtlaswayInternalAPI.Controllers.Base;
using AtlaswayInternalAPI.Models;
using AtlaswayInternalAPI.SQLBusinessLogic.SQL;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace AtlaswayInternalAPI.Controllers;


public class ClientsController : BaseController
{
    #region Constructors

    public ClientsController(AtlaswayInternalDbContext dbContext) : base(dbContext) { }

    #endregion

    #region Network Requests

    //GET: api/Clients
    [HttpGet]
    [ProducesResponseType(typeof(List<Client_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get()
    {
        return Ok(context.GetClients());
    }

    //GET: api/Clients/100
    [HttpGet("{clientNo}")]
    [ProducesResponseType(typeof(List<Client_Json>), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType(typeof(Error))]
    public IActionResult Get(int clientNo)
    {
        return Ok(context
            .GetClients()
            .Where(x => x.ClientNo == clientNo)
            );
    }

    #endregion
}
